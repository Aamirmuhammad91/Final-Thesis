namespace UDP_Client
{
    partial class Form3
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
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.Label_Input = new System.Windows.Forms.Label();
            this.Label_Output = new System.Windows.Forms.Label();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Convert = new System.Windows.Forms.Button();
            this.ToolTipConverting = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // TB_Input
            // 
            this.TB_Input.Location = new System.Drawing.Point(88, 50);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(273, 20);
            this.TB_Input.TabIndex = 0;
            this.TB_Input.TextChanged += new System.EventHandler(this.TB_Input_TextChanged);
            // 
            // Label_Input
            // 
            this.Label_Input.AutoSize = true;
            this.Label_Input.Location = new System.Drawing.Point(12, 53);
            this.Label_Input.Name = "Label_Input";
            this.Label_Input.Size = new System.Drawing.Size(66, 13);
            this.Label_Input.TabIndex = 1;
            this.Label_Input.Text = "Binary Input:";
            // 
            // Label_Output
            // 
            this.Label_Output.AutoSize = true;
            this.Label_Output.Location = new System.Drawing.Point(12, 79);
            this.Label_Output.Name = "Label_Output";
            this.Label_Output.Size = new System.Drawing.Size(70, 13);
            this.Label_Output.TabIndex = 1;
            this.Label_Output.Text = "ASCII output:";
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(88, 76);
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.Size = new System.Drawing.Size(273, 20);
            this.TB_Output.TabIndex = 0;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(12, 201);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(66, 26);
            this.Button_Exit.TabIndex = 2;
            this.Button_Exit.Text = "exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Convert
            // 
            this.Button_Convert.Enabled = false;
            this.Button_Convert.Location = new System.Drawing.Point(88, 102);
            this.Button_Convert.Name = "Button_Convert";
            this.Button_Convert.Size = new System.Drawing.Size(124, 26);
            this.Button_Convert.TabIndex = 2;
            this.Button_Convert.Text = "convert";
            this.Button_Convert.UseVisualStyleBackColor = true;
            this.Button_Convert.Click += new System.EventHandler(this.Button_Convert_Click);
            // 
            // ToolTipConverting
            // 
            this.ToolTipConverting.Popup += new System.Windows.Forms.PopupEventHandler(this.ToolTipConverting_Popup);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 239);
            this.Controls.Add(this.Button_Convert);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Label_Output);
            this.Controls.Add(this.Label_Input);
            this.Controls.Add(this.TB_Output);
            this.Controls.Add(this.TB_Input);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form3_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form3_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.Label Label_Input;
        private System.Windows.Forms.Label Label_Output;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Convert;
        private System.Windows.Forms.ToolTip ToolTipConverting;
    }
}