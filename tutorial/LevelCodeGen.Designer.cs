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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.CodeLength = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Generate2Button = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(259, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(13, 115);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(100, 25);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate One";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // CodeLength
            // 
            this.CodeLength.Location = new System.Drawing.Point(222, 119);
            this.CodeLength.MinimumSize = new System.Drawing.Size(50, 0);
            this.CodeLength.Name = "CodeLength";
            this.CodeLength.Size = new System.Drawing.Size(50, 20);
            this.CodeLength.TabIndex = 2;
            this.CodeLength.ValueChanged += new System.EventHandler(this.CodeLength_ValueChanged);
            // 
            // Generate2Button
            // 
            this.Generate2Button.Location = new System.Drawing.Point(119, 115);
            this.Generate2Button.Name = "Generate2Button";
            this.Generate2Button.Size = new System.Drawing.Size(100, 25);
            this.Generate2Button.TabIndex = 3;
            this.Generate2Button.Text = "Generate Multiple";
            this.Generate2Button.UseVisualStyleBackColor = true;
            this.Generate2Button.Click += new System.EventHandler(this.Generate2Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(259, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save Codes To File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(12, 224);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(128, 25);
            this.GoBackButton.TabIndex = 5;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(144, 224);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(128, 25);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit Program";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // LevelCodeGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Generate2Button);
            this.Controls.Add(this.CodeLength);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "LevelCodeGen";
            this.Text = "LevelCodeGen";
            ((System.ComponentModel.ISupportInitialize)(this.CodeLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.NumericUpDown CodeLength;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Generate2Button;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button ExitButton;
    }
}