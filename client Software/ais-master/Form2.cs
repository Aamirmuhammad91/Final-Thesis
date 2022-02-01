#define VERSION_1


using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;


namespace UDP_Client
{
    struct Sensor_s
    {
        public bool Init;
        public float Class;
        public int Distance;
        public int DistanceOffset;
        public int DistanceOffsetCounter;
        public int DistanceCounter;

        private int ClassFiltIndex;
        private float[] ClassFiltArray;
        private float ClassFiltSum;

        private int DistFiltIndex;
        private int[] DistFiltArray;
        private int DistFiltSum;

        public void Reset(int CountMembers=1, int DistanceOffsetCounterIn=10)
        {
            this.Init = false;
            this.Class = 0;
            this.Distance = 0;
            this.DistanceOffset = 0;
            this.DistanceOffsetCounter = DistanceOffsetCounterIn;
            this.DistanceCounter = this.DistanceOffsetCounter;
            this.ClassFiltIndex = 0;
            this.ClassFiltArray = new float[CountMembers];
            this.ClassFiltSum = 0;
            this.DistFiltIndex = 0;
            this.DistFiltArray = new int[CountMembers];
            this.DistFiltSum = 0;
        }
        public void SetValues(int Class_In, int Distance_In)
        {
            this.ClassFiltSum += (float)(Class_In) - this.ClassFiltArray[ClassFiltIndex];
            this.ClassFiltArray[ClassFiltIndex++] = Class_In;
            this.ClassFiltIndex %= ClassFiltArray.Length;
            this.Class = this.ClassFiltSum / this.ClassFiltArray.Length;

            this.DistFiltSum += Distance_In - this.DistFiltArray[ DistFiltIndex ];
            this.DistFiltArray[DistFiltIndex++] = Distance_In;
            this.DistFiltIndex %= DistFiltArray.Length;
            this.Distance = this.DistFiltSum / this.DistFiltArray.Length;
        }
        public bool Initialize(int DistanceIn)
        {
            if( ( this.DistanceCounter > 0 ) && (!this.Init) )
            {
                // is the object (seat) between 10 cm and 150 cm??
                if(DistanceIn > 10 && DistanceIn <= 150)
                {
                    this.DistanceOffset += DistanceIn;
                    this.Init = ( ( --this.DistanceCounter ) == 0);
                    if (this.Init)
                    {
                        this.DistanceOffset /= this.DistanceOffsetCounter;
                    }
                }
            }
            // will return "true" for initialized status else "false"
            return (this.Init);
        }
        public bool ValidateClass(ref int ClassIn)
        {
            bool ret = ( this.Distance < (this.DistanceOffset - 5) );
            if( ret )
            {
                ClassIn = (this.Class >= 1.5) ? ((int)2) : ( (int)1);
            }
            else
            {
                ClassIn = 0;
            }
            return ( this.Distance <= this.DistanceOffset );
        }
        public int GetHeight()
        {
            return ( (this.DistanceOffset > this.Distance) ? (this.DistanceOffset - this.Distance) : (0) );
        }
    }



    public partial class Form2 : Form
    {
        //readonly String[] ActiveSensorsNames = { "None", "First", "Second", "Both" };
        readonly String[] Modes = {  "Seat empty",               // 0
                                    "Object detected",          // 1
                                    "Small object detected",    // 2
                                    "Large object detected",    // 3
                                    "Human detected",           // 4
                                    "Small human detected",     // 5
                                    "Large human detected",     // 6
                                    "Seat initialize"           // 7
                                    };
        readonly Color[,] Colors1 = {   { Color.Green, Color.White },           // 0
                                        { Color.Red, Color.Black },             // 1
                                        { Color.Red, Color.Black },             // 2
                                        { Color.Red, Color.Black },             // 3
                                        { Color.Blue, Color.White },            // 4
                                        { Color.Blue, Color.White },            // 5
                                        { Color.Blue, Color.White },            // 6
                                        { Color.Yellow, Color.Black } };        // 7

        private Sensor_s[] Sensors = new Sensor_s[2];
        private byte[] DataIn;
        private int Mode = 0;
        private int Feature_1 = 160;
        private int Feature_10 = 12000;
        private int ThresholdSmallObject = 60;
        private int ThresholdMediumObject = 30;
        private uint ActiveSensors = 0;
        private bool SizeDetection = false;
        private static TextBox[] TB;
        private AutoResetEvent DataThreadSignal = new AutoResetEvent(false);

        internal static Form1 FM1 = Form1.FM1;

        public Form2()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

            // Create, configure and start the background thread for data reception
            Thread Th_DataThread= new Thread( new ParameterizedThreadStart( DataThread ) );
            Th_DataThread.Priority = ThreadPriority.AboveNormal;
            Th_DataThread.IsBackground = true;
            Th_DataThread.Start();


            TB = new TextBox[] { TbSensor1Class, TbSensor2Class, TbSensor1Distance, TbSensor2Distance };

            TbF1.Text = Feature_1.ToString();
            TbF10.Text = Feature_10.ToString();
            TbThresholdSmallObject.Text = ThresholdSmallObject.ToString();

            // init the sensor information
            TestSensors();

            // send threshold values to sensor(s)
            // and initialize the demo-mode
            ButSendThresholds.PerformClick();
            ButSendOffset.PerformClick();

            // this timer tests every 2 seconds, which sensor is active
            TimerSensor.Interval=5000;
            TimerSensor.Start();

        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            FM1.UDPSendData("-d 0",0);
            FM1.UDPSendData("-d 0",1);
        }



        public void ReceiveData(ref byte[] PayLoadIn )
        {

            // Payload has to be 6 bytes --> 3 x uint16_t data
            if( PayLoadIn.Length == 6 )
            {
                DataIn = new byte[PayLoadIn.Length];
                // copy the data and send signal to background thread
                PayLoadIn.CopyTo(DataIn, 0);
                DataThreadSignal.Set();
            }
        }



        private void ButtonSetOffset_Klick(object sender, EventArgs e)
        {
            for (int ix = 0; ix < Sensors.Length; ix++){
                Sensors[ix].Reset(10, 20);
            }
            SetStatus();
            TestSensors();
            Mode = 0;
            FM1.UDPSendData("-d 0", 0);
            FM1.UDPSendData("-d 0", 1);

            FM1.UDPSendData("-i 1", 0);
            FM1.UDPSendData("-i 2", 1);
            FM1.UDPSendData("-d 1", 0);
            Thread.Sleep(50);
            FM1.UDPSendData("-d 1", 1);
            
        }



        private void ButSendThresholds_Click(object sender, EventArgs e)
        {
            String Tmp = "-t " + Feature_1.ToString() + " " + Feature_10.ToString();
            FM1.UDPSendData(Tmp,0);
            FM1.UDPSendData(Tmp,1);
        }



        private void TimerSensorPing(object sender, EventArgs e)
        {
            TestSensors();
        }



        private void TestSensors()
        {
            ActiveSensors = FM1.PingSensor();
            SizeDetection = (ActiveSensors == 3);
        }



        // ***** Thread for Data reception ***** //
        public void DataThread(object Data)
        {
            int SensorID, SensorClass, SensorDistance, ClassSensor1;
            bool bShowData = true;

            for (;;)
            {
                bShowData = true;
                SensorID= SensorClass= SensorDistance= ClassSensor1 = 0;

                // The thread waits here for the signal from UDP
                // in blocked mode
                DataThreadSignal.WaitOne();
                MethodInvoker QuestionDelegate = delegate
                {
                    if (DataIn.Length == 6)
                    {
                        SensorID = ( BitConverter.ToUInt16(DataIn, 0) - 1) % Sensors.Length;     // 0 or 1
                        SensorClass = BitConverter.ToUInt16(DataIn, 2);
                        SensorDistance = BitConverter.ToUInt16(DataIn, 4);

                        Sensors[SensorID].SetValues(SensorClass, SensorDistance);

                        // Mode == 0 is measuring the distance offset to the seat
                        // Mode == 1 is showing actual data of both sensors
                        if (Mode == 0)
                        {
                            Sensors[SensorID].Initialize(SensorDistance);

                            // Seat init mode
                            if (Sensors[0].Init && Sensors[1].Init && SizeDetection)
                            {
                                TbOffset.Text = Sensors[0].DistanceOffset.ToString("0 cm");
                                SetStatus(0);
                                Mode = 1;
                            }
                            else if ((Sensors[SensorID].Init) && !SizeDetection)
                            {
                                TbOffset.Text = Sensors[0].DistanceOffset.ToString("0 cm");
                                SetStatus(0);
                                Mode = 1;
                            }

                            }
                        else if (Mode == 1)
                        {
                            if (Sensors[0].ValidateClass(ref ClassSensor1))
                            {
                                // either 1 or 4 ( 1*1 or 2*2)
                                ClassSensor1 *= ClassSensor1;
                                if (SizeDetection && (ClassSensor1 != 0))
                                {
                                    // gets either 2,3 or 5,6
                                    if (Sensors[1].GetHeight() >= ThresholdSmallObject)
                                    {
                                        ClassSensor1 += 2;
                                    }
                                    else if (Sensors[1].GetHeight() >= ThresholdMediumObject)
                                    {
                                        ClassSensor1 += 3;
                                    }
                                    else
                                    {
                                        ClassSensor1 += 1;
                                    }
                                }
                                SetStatus(ClassSensor1);
                            }
                            else
                            {
                                bShowData = false;
                            }
                        }

                        if (bShowData)
                        {
                            // fill textboxes with received data
                            TB[SensorID].Text = SensorClass.ToString("0");
                            TB[SensorID + 2].Text = SensorDistance.ToString("0") + " cm";
                        }

                    }
                };
                Invoke(QuestionDelegate);

            } // end for(;;)
        }



        private void SetStatus(int NewStatus=7)
        {
            LabelStatus.BackColor = Colors1[NewStatus,0];
            LabelStatus.ForeColor = Colors1[NewStatus,1];
            LabelStatus.Text = Modes[NewStatus];
        }



        private void ButtonExitClick(object sender, EventArgs e)
        {
            this.Close();
        }



        private void TbF1_TextChanged(object sender, EventArgs e)
        {
            Feature_1 = int.Parse(TbF1.Text);
        }



        private void TbF10_TextChanged(object sender, EventArgs e)
        {
            Feature_10 = int.Parse(TbF10.Text);
        }



        private void TbThresholdChanged(object sender, EventArgs e)
        {
            TextBox TB = (TextBox)(sender);
            if(TB.Name == "TbThresholdSmallObject" && (TB.Text.Length >= 2))
            {
                ThresholdSmallObject = int.Parse(TbThresholdSmallObject.Text);
            }
            else if(TB.Name == "TbThresholdMediumObject" && (TB.Text.Length >=2) )
            {
                ThresholdMediumObject = int.Parse(TbThresholdMediumObject.Text);
            }

            if(ThresholdSmallObject > ThresholdMediumObject)
            {
                ThresholdMediumObject = ThresholdSmallObject;
            }
            
        }



    }
}
