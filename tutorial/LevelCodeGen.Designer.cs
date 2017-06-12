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
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CodeLength = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Generate2Button = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CodeLength_x = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ButtonIDSaveAs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength_x)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(440, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(12, 114);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(190, 25);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate One";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CodeLength
            // 
            this.CodeLength.Location = new System.Drawing.Point(403, 118);
            this.CodeLength.MinimumSize = new System.Drawing.Size(50, 0);
            this.CodeLength.Name = "CodeLength";
            this.CodeLength.Size = new System.Drawing.Size(50, 20);
            this.CodeLength.TabIndex = 2;
            this.CodeLength.ValueChanged += new System.EventHandler(this.CodeLength_ValueChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.CreatePrompt = true;
            this.saveFileDialog1.DefaultExt = "rtf";
            this.saveFileDialog1.Filter = " \"Text files (*.txt)|(*.rft)|*.txt|*.rft|All files (*.*)|*.*\"";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            // 
            // Generate2Button
            // 
            this.Generate2Button.Location = new System.Drawing.Point(207, 114);
            this.Generate2Button.Name = "Generate2Button";
            this.Generate2Button.Size = new System.Drawing.Size(190, 25);
            this.Generate2Button.TabIndex = 3;
            this.Generate2Button.Text = "Generate Multiple";
            this.Generate2Button.UseVisualStyleBackColor = true;
            this.Generate2Button.Click += new System.EventHandler(this.Generate2Button_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 404);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(207, 25);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(225, 404);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(228, 25);
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
            this.CodeLength_x.Location = new System.Drawing.Point(403, 144);
            this.CodeLength_x.Name = "CodeLength_x";
            this.CodeLength_x.Size = new System.Drawing.Size(50, 20);
            this.CodeLength_x.TabIndex = 7;
            this.CodeLength_x.ValueChanged += new System.EventHandler(this.CodeLength_x_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox1.Location = new System.Drawing.Point(12, 145);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "For Generating More Than 100 Codes  Incease This ->";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ButtonIDSaveAs
            // 
            this.ButtonIDSaveAs.Location = new System.Drawing.Point(13, 375);
            this.ButtonIDSaveAs.Name = "ButtonIDSaveAs";
            this.ButtonIDSaveAs.Size = new System.Drawing.Size(440, 23);
            this.ButtonIDSaveAs.TabIndex = 9;
            this.ButtonIDSaveAs.Text = "Save Codes To File";
            this.ButtonIDSaveAs.UseVisualStyleBackColor = true;
            this.ButtonIDSaveAs.Click += new System.EventHandler(this.ButtonIDSaveAs_Click);
            // 
            // LevelCodeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 441);
            this.Controls.Add(this.ButtonIDSaveAs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CodeLength_x);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.Generate2Button);
            this.Controls.Add(this.CodeLength);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.richTextBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelCodeGen";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LevelCodeGen";
            this.Load += new System.EventHandler(this.LevelCodeGen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength_x)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.NumericUpDown CodeLength;
        private System.Windows.Forms.Button Generate2Button;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown CodeLength_x;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ButtonIDSaveAs;
    }
}