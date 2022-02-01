namespace UDP_Client
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TbSensor1Distance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbSensor1Class = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TbSensor2Class = new System.Windows.Forms.TextBox();
            this.TbSensor2Distance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbThresholdMediumObject = new System.Windows.Forms.TextBox();
            this.TbThresholdSmallObject = new System.Windows.Forms.TextBox();
            this.TbF10 = new System.Windows.Forms.TextBox();
            this.TbOffset = new System.Windows.Forms.TextBox();
            this.TbF1 = new System.Windows.Forms.TextBox();
            this.ButSendThresholds = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ButSendOffset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.TimerSensor = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ButSendOffset);
            this.groupBox1.Location = new System.Drawing.Point(12, 568);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(980, 157);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sensor(s)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TbSensor1Distance);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.TbSensor1Class);
            this.groupBox3.Controls.Add(this.TbOffset);
            this.groupBox3.Location = new System.Drawing.Point(608, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 132);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sensor 1";
            // 
            // TbSensor1Distance
            // 
            this.TbSensor1Distance.Location = new System.Drawing.Point(115, 13);
            this.TbSensor1Distance.Name = "TbSensor1Distance";
            this.TbSensor1Distance.Size = new System.Drawing.Size(61, 20);
            this.TbSensor1Distance.TabIndex = 15;
            this.TbSensor1Distance.Text = "-";
            this.TbSensor1Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Distance:";
            // 
            // TbSensor1Class
            // 
            this.TbSensor1Class.Location = new System.Drawing.Point(115, 39);
            this.TbSensor1Class.Name = "TbSensor1Class";
            this.TbSensor1Class.Size = new System.Drawing.Size(61, 20);
            this.TbSensor1Class.TabIndex = 15;
            this.TbSensor1Class.Text = "-";
            this.TbSensor1Class.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TbSensor2Class);
            this.groupBox4.Controls.Add(this.TbSensor2Distance);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(794, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(180, 132);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sensor 2";
            // 
            // TbSensor2Class
            // 
            this.TbSensor2Class.Location = new System.Drawing.Point(113, 39);
            this.TbSensor2Class.Name = "TbSensor2Class";
            this.TbSensor2Class.Size = new System.Drawing.Size(61, 20);
            this.TbSensor2Class.TabIndex = 15;
            this.TbSensor2Class.Text = "-";
            this.TbSensor2Class.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TbSensor2Distance
            // 
            this.TbSensor2Distance.Location = new System.Drawing.Point(113, 13);
            this.TbSensor2Distance.Name = "TbSensor2Distance";
            this.TbSensor2Distance.Size = new System.Drawing.Size(61, 20);
            this.TbSensor2Distance.TabIndex = 15;
            this.TbSensor2Distance.Text = "-";
            this.TbSensor2Distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Distance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "medium threshold [cm]: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "small threshold [cm]: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "F10: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "F1: ";
            // 
            // TbThresholdMediumObject
            // 
            this.TbThresholdMediumObject.Location = new System.Drawing.Point(152, 91);
            this.TbThresholdMediumObject.Name = "TbThresholdMediumObject";
            this.TbThresholdMediumObject.Size = new System.Drawing.Size(61, 20);
            this.TbThresholdMediumObject.TabIndex = 15;
            this.TbThresholdMediumObject.Text = "30";
            this.TbThresholdMediumObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbThresholdMediumObject.TextChanged += new System.EventHandler(this.TbThresholdChanged);
            // 
            // TbThresholdSmallObject
            // 
            this.TbThresholdSmallObject.Location = new System.Drawing.Point(152, 65);
            this.TbThresholdSmallObject.Name = "TbThresholdSmallObject";
            this.TbThresholdSmallObject.Size = new System.Drawing.Size(61, 20);
            this.TbThresholdSmallObject.TabIndex = 15;
            this.TbThresholdSmallObject.Text = "30";
            this.TbThresholdSmallObject.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbThresholdSmallObject.TextChanged += new System.EventHandler(this.TbThresholdChanged);
            // 
            // TbF10
            // 
            this.TbF10.Location = new System.Drawing.Point(152, 39);
            this.TbF10.Name = "TbF10";
            this.TbF10.Size = new System.Drawing.Size(61, 20);
            this.TbF10.TabIndex = 15;
            this.TbF10.Text = "-";
            this.TbF10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbF10.TextChanged += new System.EventHandler(this.TbF10_TextChanged);
            // 
            // TbOffset
            // 
            this.TbOffset.Location = new System.Drawing.Point(115, 65);
            this.TbOffset.Name = "TbOffset";
            this.TbOffset.Size = new System.Drawing.Size(61, 20);
            this.TbOffset.TabIndex = 15;
            this.TbOffset.Text = "-";
            this.TbOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbOffset.TextChanged += new System.EventHandler(this.TbF1_TextChanged);
            // 
            // TbF1
            // 
            this.TbF1.Location = new System.Drawing.Point(152, 13);
            this.TbF1.Name = "TbF1";
            this.TbF1.Size = new System.Drawing.Size(61, 20);
            this.TbF1.TabIndex = 15;
            this.TbF1.Text = "-";
            this.TbF1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TbF1.TextChanged += new System.EventHandler(this.TbF1_TextChanged);
            // 
            // ButSendThresholds
            // 
            this.ButSendThresholds.Location = new System.Drawing.Point(254, 53);
            this.ButSendThresholds.Name = "ButSendThresholds";
            this.ButSendThresholds.Size = new System.Drawing.Size(85, 28);
            this.ButSendThresholds.TabIndex = 14;
            this.ButSendThresholds.Text = "set thresholds";
            this.ButSendThresholds.UseVisualStyleBackColor = true;
            this.ButSendThresholds.Click += new System.EventHandler(this.ButSendThresholds_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "exit demo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonExitClick);
            // 
            // ButSendOffset
            // 
            this.ButSendOffset.Location = new System.Drawing.Point(6, 19);
            this.ButSendOffset.Name = "ButSendOffset";
            this.ButSendOffset.Size = new System.Drawing.Size(70, 28);
            this.ButSendOffset.TabIndex = 14;
            this.ButSendOffset.Text = "set offset";
            this.ButSendOffset.UseVisualStyleBackColor = true;
            this.ButSendOffset.Click += new System.EventHandler(this.ButtonSetOffset_Klick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LabelStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(980, 550);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Object recognition";
            // 
            // LabelStatus
            // 
            this.LabelStatus.BackColor = System.Drawing.Color.Transparent;
            this.LabelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStatus.Location = new System.Drawing.Point(3, 16);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(974, 531);
            this.LabelStatus.TabIndex = 14;
            this.LabelStatus.Text = "status";
            this.LabelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerSensor
            // 
            this.TimerSensor.Tick += new System.EventHandler(this.TimerSensorPing);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Distance Offset:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(113, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "-";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.TbF1_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Distance Offset:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TbF1);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.TbF10);
            this.groupBox5.Controls.Add(this.ButSendThresholds);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.TbThresholdSmallObject);
            this.groupBox5.Controls.Add(this.TbThresholdMediumObject);
            this.groupBox5.Location = new System.Drawing.Point(161, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 132);
            this.groupBox5.TabIndex = 20;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sensor 1 and 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1004, 737);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "DEMO - UDP client - UAS Frankfurt @2020";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButSendOffset;
        private System.Windows.Forms.TextBox TbSensor1Distance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.TextBox TbSensor2Distance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbF10;
        private System.Windows.Forms.TextBox TbF1;
        private System.Windows.Forms.Button ButSendThresholds;
        private System.Windows.Forms.Timer TimerSensor;
        private System.Windows.Forms.TextBox TbSensor1Class;
        private System.Windows.Forms.TextBox TbSensor2Class;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbThresholdSmallObject;
        private System.Windows.Forms.TextBox TbOffset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TbThresholdMediumObject;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}