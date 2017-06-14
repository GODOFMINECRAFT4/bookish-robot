namespace tutorial
{
    partial class LevelCodeGen
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CodeLength_x = new System.Windows.Forms.NumericUpDown();
            this.ButtonIDSaveAs = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TotalAmount = new System.Windows.Forms.Label();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.MultplierLabel = new System.Windows.Forms.Label();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.Generate2Button = new System.Windows.Forms.Button();
            this.CodeLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Option10 = new System.Windows.Forms.CheckBox();
            this.Option9 = new System.Windows.Forms.CheckBox();
            this.Option8 = new System.Windows.Forms.CheckBox();
            this.Option7 = new System.Windows.Forms.CheckBox();
            this.Option6 = new System.Windows.Forms.CheckBox();
            this.Option5 = new System.Windows.Forms.CheckBox();
            this.Option4 = new System.Windows.Forms.CheckBox();
            this.Option1 = new System.Windows.Forms.CheckBox();
            this.Option3 = new System.Windows.Forms.CheckBox();
            this.Option2 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LogClearButton = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ValueTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength_x)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(440, 140);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "rtf";
            this.saveFileDialog1.FileName = "Generated Codes";
            this.saveFileDialog1.Filter = " \"Text files (*.txt)|(*.rtf)|*.txt|*.rtf|All files (*.*)|*.*\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(6, 74);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(212, 25);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(6, 105);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(212, 25);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CodeLength_x
            // 
            this.CodeLength_x.Location = new System.Drawing.Point(311, 45);
            this.CodeLength_x.Name = "CodeLength_x";
            this.CodeLength_x.Size = new System.Drawing.Size(50, 20);
            this.CodeLength_x.TabIndex = 7;
            this.CodeLength_x.ValueChanged += new System.EventHandler(this.CodeLength_x_ValueChanged);
            // 
            // ButtonIDSaveAs
            // 
            this.ButtonIDSaveAs.Location = new System.Drawing.Point(6, 46);
            this.ButtonIDSaveAs.Name = "ButtonIDSaveAs";
            this.ButtonIDSaveAs.Size = new System.Drawing.Size(212, 23);
            this.ButtonIDSaveAs.TabIndex = 9;
            this.ButtonIDSaveAs.Text = "Save Codes To File";
            this.ButtonIDSaveAs.UseVisualStyleBackColor = true;
            this.ButtonIDSaveAs.Click += new System.EventHandler(this.ButtonIDSaveAs_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TotalAmount);
            this.groupBox2.Controls.Add(this.TotalAmountLabel);
            this.groupBox2.Controls.Add(this.MultplierLabel);
            this.groupBox2.Controls.Add(this.NumberLabel);
            this.groupBox2.Controls.Add(this.ResetButton);
            this.groupBox2.Controls.Add(this.GenerateButton);
            this.groupBox2.Controls.Add(this.Generate2Button);
            this.groupBox2.Controls.Add(this.CodeLength);
            this.groupBox2.Controls.Add(this.CodeLength_x);
            this.groupBox2.Location = new System.Drawing.Point(13, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 112);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generation Menu";
            // 
            // TotalAmount
            // 
            this.TotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmount.Location = new System.Drawing.Point(314, 82);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(126, 22);
            this.TotalAmount.TabIndex = 12;
            this.TotalAmount.Text = "0";
            this.TotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAmountLabel.Location = new System.Drawing.Point(201, 81);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(106, 23);
            this.TotalAmountLabel.TabIndex = 11;
            this.TotalAmountLabel.Text = "Total Amount";
            this.TotalAmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MultplierLabel
            // 
            this.MultplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultplierLabel.Location = new System.Drawing.Point(202, 45);
            this.MultplierLabel.Name = "MultplierLabel";
            this.MultplierLabel.Size = new System.Drawing.Size(78, 23);
            this.MultplierLabel.TabIndex = 10;
            this.MultplierLabel.Text = "Multiplier";
            this.MultplierLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberLabel
            // 
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.Location = new System.Drawing.Point(201, 19);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(78, 23);
            this.NumberLabel.TabIndex = 9;
            this.NumberLabel.Text = "Number";
            this.NumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(7, 82);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(188, 23);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset Values";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(4, 19);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(191, 25);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate One";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // Generate2Button
            // 
            this.Generate2Button.Location = new System.Drawing.Point(4, 50);
            this.Generate2Button.Name = "Generate2Button";
            this.Generate2Button.Size = new System.Drawing.Size(191, 25);
            this.Generate2Button.TabIndex = 3;
            this.Generate2Button.Text = "Generate Multiple";
            this.Generate2Button.UseVisualStyleBackColor = true;
            this.Generate2Button.Click += new System.EventHandler(this.Generate2Button_Click);
            // 
            // CodeLength
            // 
            this.CodeLength.Location = new System.Drawing.Point(311, 19);
            this.CodeLength.MinimumSize = new System.Drawing.Size(50, 0);
            this.CodeLength.Name = "CodeLength";
            this.CodeLength.Size = new System.Drawing.Size(50, 20);
            this.CodeLength.TabIndex = 2;
            this.CodeLength.ValueChanged += new System.EventHandler(this.CodeLength_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Option10);
            this.groupBox1.Controls.Add(this.Option9);
            this.groupBox1.Controls.Add(this.Option8);
            this.groupBox1.Controls.Add(this.Option7);
            this.groupBox1.Controls.Add(this.Option6);
            this.groupBox1.Controls.Add(this.Option5);
            this.groupBox1.Controls.Add(this.Option4);
            this.groupBox1.Controls.Add(this.Option1);
            this.groupBox1.Controls.Add(this.Option3);
            this.groupBox1.Controls.Add(this.Option2);
            this.groupBox1.Location = new System.Drawing.Point(13, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 140);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // Option10
            // 
            this.Option10.AutoSize = true;
            this.Option10.Location = new System.Drawing.Point(92, 111);
            this.Option10.Name = "Option10";
            this.Option10.Size = new System.Drawing.Size(84, 17);
            this.Option10.TabIndex = 19;
            this.Option10.Text = "Infinate Gen";
            this.Option10.UseVisualStyleBackColor = true;
            this.Option10.CheckedChanged += new System.EventHandler(this.Option10_CheckedChanged);
            // 
            // Option9
            // 
            this.Option9.AutoSize = true;
            this.Option9.Location = new System.Drawing.Point(92, 86);
            this.Option9.Name = "Option9";
            this.Option9.Size = new System.Drawing.Size(80, 17);
            this.Option9.TabIndex = 18;
            this.Option9.Text = "checkBox9";
            this.Option9.UseVisualStyleBackColor = true;
            this.Option9.CheckedChanged += new System.EventHandler(this.Option9_CheckedChanged);
            // 
            // Option8
            // 
            this.Option8.AutoSize = true;
            this.Option8.Location = new System.Drawing.Point(92, 65);
            this.Option8.Name = "Option8";
            this.Option8.Size = new System.Drawing.Size(80, 17);
            this.Option8.TabIndex = 17;
            this.Option8.Text = "checkBox8";
            this.Option8.UseVisualStyleBackColor = true;
            this.Option8.CheckedChanged += new System.EventHandler(this.Option8_CheckedChanged);
            // 
            // Option7
            // 
            this.Option7.AutoSize = true;
            this.Option7.Location = new System.Drawing.Point(92, 42);
            this.Option7.Name = "Option7";
            this.Option7.Size = new System.Drawing.Size(80, 17);
            this.Option7.TabIndex = 16;
            this.Option7.Text = "checkBox7";
            this.Option7.UseVisualStyleBackColor = true;
            this.Option7.CheckedChanged += new System.EventHandler(this.Option7_CheckedChanged);
            // 
            // Option6
            // 
            this.Option6.AutoSize = true;
            this.Option6.Location = new System.Drawing.Point(92, 19);
            this.Option6.Name = "Option6";
            this.Option6.Size = new System.Drawing.Size(80, 17);
            this.Option6.TabIndex = 15;
            this.Option6.Text = "checkBox6";
            this.Option6.UseVisualStyleBackColor = true;
            this.Option6.CheckedChanged += new System.EventHandler(this.Option6_CheckedChanged);
            // 
            // Option5
            // 
            this.Option5.AutoSize = true;
            this.Option5.Location = new System.Drawing.Point(6, 111);
            this.Option5.Name = "Option5";
            this.Option5.Size = new System.Drawing.Size(80, 17);
            this.Option5.TabIndex = 14;
            this.Option5.Text = "checkBox5";
            this.Option5.UseVisualStyleBackColor = true;
            this.Option5.CheckedChanged += new System.EventHandler(this.Option5_CheckedChanged);
            // 
            // Option4
            // 
            this.Option4.AutoSize = true;
            this.Option4.Location = new System.Drawing.Point(6, 88);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(80, 17);
            this.Option4.TabIndex = 13;
            this.Option4.Text = "checkBox4";
            this.Option4.UseVisualStyleBackColor = true;
            this.Option4.CheckedChanged += new System.EventHandler(this.Option4_CheckedChanged);
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(6, 19);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(80, 17);
            this.Option1.TabIndex = 10;
            this.Option1.Text = "checkBox1";
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(6, 65);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(80, 17);
            this.Option3.TabIndex = 12;
            this.Option3.Text = "checkBox3";
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.CheckedChanged += new System.EventHandler(this.Option3_CheckedChanged);
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(6, 42);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(80, 17);
            this.Option2.TabIndex = 11;
            this.Option2.Text = "checkBox2";
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.Option2_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LogClearButton);
            this.groupBox3.Controls.Add(this.ExitButton);
            this.groupBox3.Controls.Add(this.ButtonIDSaveAs);
            this.groupBox3.Controls.Add(this.GoBackButton);
            this.groupBox3.Location = new System.Drawing.Point(229, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 136);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu";
            // 
            // LogClearButton
            // 
            this.LogClearButton.Location = new System.Drawing.Point(6, 19);
            this.LogClearButton.Name = "LogClearButton";
            this.LogClearButton.Size = new System.Drawing.Size(211, 23);
            this.LogClearButton.TabIndex = 10;
            this.LogClearButton.Text = "Clear Log ";
            this.LogClearButton.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(465, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ValueTimer
            // 
            this.ValueTimer.Interval = 50;
            this.ValueTimer.Tick += new System.EventHandler(this.ValueTimer_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 25;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LevelCodeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelCodeGen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelCodeGen";
            this.Load += new System.EventHandler(this.LevelCodeGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength_x)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown CodeLength_x;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ButtonIDSaveAs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Option10;
        private System.Windows.Forms.CheckBox Option9;
        private System.Windows.Forms.CheckBox Option8;
        private System.Windows.Forms.CheckBox Option7;
        private System.Windows.Forms.CheckBox Option6;
        private System.Windows.Forms.CheckBox Option5;
        private System.Windows.Forms.CheckBox Option4;
        private System.Windows.Forms.CheckBox Option1;
        private System.Windows.Forms.CheckBox Option3;
        private System.Windows.Forms.CheckBox Option2;
        private System.Windows.Forms.Button Generate2Button;
        private System.Windows.Forms.NumericUpDown CodeLength;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button LogClearButton;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label MultplierLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.Label TotalAmount;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Timer ValueTimer;
        private System.Windows.Forms.Timer timer2;
    }
}