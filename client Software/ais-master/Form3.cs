using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDP_Client
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;

            ToolTipConverting.SetToolTip(Button_Convert, "Click to convert");
            ToolTipConverting.AutoPopDelay = 5000;
            ToolTipConverting.InitialDelay = 1000;
            ToolTipConverting.ReshowDelay = 500;
            ToolTipConverting.ShowAlways = true;

        }


        
        private void Form3_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }



        private void Form3_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList;

            FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            TB_Input.Text = FileList[0];
        }



        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Button_Convert_Click(object sender, EventArgs e)
        {
            bool save = false;
            string OutputPath = "";
            string Output = "";
            int SampleCounter = 0;
            int Samples = (int)(Math.Pow(2, 14));
            BinaryReader BR = null;
            Button Butt_In = (Button)(sender);


            Butt_In.Enabled = false;
            if ( File.Exists(TB_Input.Text) )
            {
                try
                {
                    BR = new BinaryReader(new FileStream(TB_Input.Text, FileMode.Open));
                    OutputPath = TB_Output.Text;

                    for(; ; )
                    {
                        for (int ix = 0; ix < Samples; ix++)
                        {
                            Output += (BitConverter.ToInt16(BR.ReadBytes(2), 0)).ToString("0") + "\t";
                            SampleCounter++;
                        }
                        File.AppendAllText(OutputPath, Output + "\n");
                        Output = "";
                    }
                }
                catch
                {
                    
                }


                if(BR != null)
                {
                    BR.Close();
                }
                Butt_In.Enabled = true;
                

            }
        }



        private void TB_Input_TextChanged(object sender, EventArgs e)
        {
            bool Checked = File.Exists(TB_Input.Text);

            Button_Convert.Enabled = Checked;
            TB_Output.Text = (Checked) ? (TB_Input.Text.Substring(0, TB_Input.Text.Length - 4) + ".txt") : ("---");
        }



        private void ToolTipConverting_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
