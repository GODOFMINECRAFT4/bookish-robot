﻿namespace tutorial
{
    partial class Main_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Menu));
            this.OpenGameButton = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // OpenGameButton
            // 
            this.OpenGameButton.Location = new System.Drawing.Point(13, 12);
            this.OpenGameButton.Name = "OpenGameButton";
            this.OpenGameButton.Size = new System.Drawing.Size(259, 179);
            this.OpenGameButton.TabIndex = 0;
            this.OpenGameButton.Text = "Start Game";
            this.OpenGameButton.UseVisualStyleBackColor = true;
            this.OpenGameButton.Click += new System.EventHandler(this.OpenGameButton_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Location = new System.Drawing.Point(147, 226);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(126, 23);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "Exit Program";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(13, 226);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(127, 23);
            this.GoBackButton.TabIndex = 2;
            this.GoBackButton.Text = "Go Back";
            this.GoBackButton.UseVisualStyleBackColor = true;
            this.GoBackButton.Click += new System.EventHandler(this.GoBackButton_Click);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Location = new System.Drawing.Point(13, 197);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(260, 23);
            this.LoadGameButton.TabIndex = 3;
            this.LoadGameButton.Text = "Level Code ";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.LoadGameButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.GoBackButton);
            this.Controls.Add(this.LoadGameButton);
            this.Controls.Add(this.OpenGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_Menu";
            this.Text = "Main_Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Menu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenGameButton;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}