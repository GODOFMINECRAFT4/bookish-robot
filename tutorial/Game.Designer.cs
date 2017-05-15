﻿namespace tutorial
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Player = new System.Windows.Forms.Label();
            this.Life = new System.Windows.Forms.ProgressBar();
            this.Enemy_01 = new System.Windows.Forms.PictureBox();
            this.Pear_02 = new System.Windows.Forms.PictureBox();
            this.Banana_02 = new System.Windows.Forms.PictureBox();
            this.Apple_02 = new System.Windows.Forms.PictureBox();
            this.Pear_01 = new System.Windows.Forms.PictureBox();
            this.Banana_01 = new System.Windows.Forms.PictureBox();
            this.Apple_01 = new System.Windows.Forms.PictureBox();
            this.Inv_05 = new System.Windows.Forms.PictureBox();
            this.Inv_03 = new System.Windows.Forms.PictureBox();
            this.Inv_04 = new System.Windows.Forms.PictureBox();
            this.Inv_02 = new System.Windows.Forms.PictureBox();
            this.Inv_01 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebug = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebugInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDebugInfo_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DebugTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LifeLabel = new System.Windows.Forms.Label();
            this.TextBoxGod = new System.Windows.Forms.ToolStripTextBox();
            this.SpeedMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.SpeedTextBox = new System.Windows.Forms.ToolStripTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple_01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_05)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_01)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.AutoSize = true;
            this.Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player.Location = new System.Drawing.Point(425, 350);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(98, 25);
            this.Player.TabIndex = 0;
            this.Player.Text = "Character";
            // 
            // Life
            // 
            this.Life.Location = new System.Drawing.Point(0, 28);
            this.Life.Name = "Life";
            this.Life.Size = new System.Drawing.Size(183, 23);
            this.Life.TabIndex = 1;
            this.Life.Click += new System.EventHandler(this.Life_Click);
            // 
            // Enemy_01
            // 
            this.Enemy_01.Image = global::tutorial.Properties.Resources.Enemy_01;
            this.Enemy_01.Location = new System.Drawing.Point(604, 77);
            this.Enemy_01.Name = "Enemy_01";
            this.Enemy_01.Size = new System.Drawing.Size(32, 32);
            this.Enemy_01.TabIndex = 13;
            this.Enemy_01.TabStop = false;
            this.Enemy_01.Tag = "Enemy";
            // 
            // Pear_02
            // 
            this.Pear_02.Image = global::tutorial.Properties.Resources.untitled;
            this.Pear_02.Location = new System.Drawing.Point(796, 523);
            this.Pear_02.Name = "Pear_02";
            this.Pear_02.Size = new System.Drawing.Size(32, 32);
            this.Pear_02.TabIndex = 12;
            this.Pear_02.TabStop = false;
            this.Pear_02.Tag = "Pear";
            // 
            // Banana_02
            // 
            this.Banana_02.Image = global::tutorial.Properties.Resources.banana;
            this.Banana_02.Location = new System.Drawing.Point(85, 214);
            this.Banana_02.Name = "Banana_02";
            this.Banana_02.Size = new System.Drawing.Size(32, 32);
            this.Banana_02.TabIndex = 11;
            this.Banana_02.TabStop = false;
            this.Banana_02.Tag = "Banana";
            // 
            // Apple_02
            // 
            this.Apple_02.Image = global::tutorial.Properties.Resources.Apple;
            this.Apple_02.Location = new System.Drawing.Point(771, 174);
            this.Apple_02.Name = "Apple_02";
            this.Apple_02.Size = new System.Drawing.Size(32, 32);
            this.Apple_02.TabIndex = 10;
            this.Apple_02.TabStop = false;
            this.Apple_02.Tag = "Apple";
            // 
            // Pear_01
            // 
            this.Pear_01.Image = global::tutorial.Properties.Resources.untitled;
            this.Pear_01.Location = new System.Drawing.Point(368, 105);
            this.Pear_01.Name = "Pear_01";
            this.Pear_01.Size = new System.Drawing.Size(32, 32);
            this.Pear_01.TabIndex = 9;
            this.Pear_01.TabStop = false;
            this.Pear_01.Tag = "Pear";
            // 
            // Banana_01
            // 
            this.Banana_01.Image = global::tutorial.Properties.Resources.banana;
            this.Banana_01.Location = new System.Drawing.Point(504, 591);
            this.Banana_01.Name = "Banana_01";
            this.Banana_01.Size = new System.Drawing.Size(32, 32);
            this.Banana_01.TabIndex = 8;
            this.Banana_01.TabStop = false;
            this.Banana_01.Tag = "Banana";
            // 
            // Apple_01
            // 
            this.Apple_01.Image = global::tutorial.Properties.Resources.Apple;
            this.Apple_01.Location = new System.Drawing.Point(104, 591);
            this.Apple_01.Name = "Apple_01";
            this.Apple_01.Size = new System.Drawing.Size(32, 32);
            this.Apple_01.TabIndex = 7;
            this.Apple_01.TabStop = false;
            this.Apple_01.Tag = "Apple";
            // 
            // Inv_05
            // 
            this.Inv_05.Image = ((System.Drawing.Image)(resources.GetObject("Inv_05.Image")));
            this.Inv_05.Location = new System.Drawing.Point(812, 12);
            this.Inv_05.Name = "Inv_05";
            this.Inv_05.Size = new System.Drawing.Size(32, 32);
            this.Inv_05.TabIndex = 6;
            this.Inv_05.TabStop = false;
            this.Inv_05.Click += new System.EventHandler(this.Inv_05_CLick);
            // 
            // Inv_03
            // 
            this.Inv_03.Image = ((System.Drawing.Image)(resources.GetObject("Inv_03.Image")));
            this.Inv_03.Location = new System.Drawing.Point(888, 12);
            this.Inv_03.Name = "Inv_03";
            this.Inv_03.Size = new System.Drawing.Size(32, 32);
            this.Inv_03.TabIndex = 5;
            this.Inv_03.TabStop = false;
            this.Inv_03.Click += new System.EventHandler(this.Inv_03_CLick);
            // 
            // Inv_04
            // 
            this.Inv_04.Image = global::tutorial.Properties.Resources.Blank_Inv;
            this.Inv_04.Location = new System.Drawing.Point(850, 12);
            this.Inv_04.Name = "Inv_04";
            this.Inv_04.Size = new System.Drawing.Size(32, 32);
            this.Inv_04.TabIndex = 4;
            this.Inv_04.TabStop = false;
            this.Inv_04.Click += new System.EventHandler(this.Inv_04_CLick);
            // 
            // Inv_02
            // 
            this.Inv_02.Image = ((System.Drawing.Image)(resources.GetObject("Inv_02.Image")));
            this.Inv_02.Location = new System.Drawing.Point(926, 12);
            this.Inv_02.Name = "Inv_02";
            this.Inv_02.Size = new System.Drawing.Size(32, 32);
            this.Inv_02.TabIndex = 3;
            this.Inv_02.TabStop = false;
            this.Inv_02.Click += new System.EventHandler(this.Inv_02_CLick);
            // 
            // Inv_01
            // 
            this.Inv_01.Image = ((System.Drawing.Image)(resources.GetObject("Inv_01.Image")));
            this.Inv_01.Location = new System.Drawing.Point(964, 12);
            this.Inv_01.Name = "Inv_01";
            this.Inv_01.Size = new System.Drawing.Size(32, 32);
            this.Inv_01.TabIndex = 2;
            this.Inv_01.TabStop = false;
            this.Inv_01.Click += new System.EventHandler(this.Inv_01_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.DebugMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(250, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(250, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDebug,
            this.toolStripSeparator1,
            this.MenuItemExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Options";
            // 
            // MenuItemDebug
            // 
            this.MenuItemDebug.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDebugInfo,
            this.MenuItemDebugInfo_2});
            this.MenuItemDebug.Name = "MenuItemDebug";
            this.MenuItemDebug.Size = new System.Drawing.Size(152, 22);
            this.MenuItemDebug.Text = "Debug";
            // 
            // MenuItemDebugInfo
            // 
            this.MenuItemDebugInfo.Name = "MenuItemDebugInfo";
            this.MenuItemDebugInfo.Size = new System.Drawing.Size(207, 22);
            this.MenuItemDebugInfo.Text = "Print Debug Info Console";
            this.MenuItemDebugInfo.Click += new System.EventHandler(this.MenuItemDebugInfo_Click);
            // 
            // MenuItemDebugInfo_2
            // 
            this.MenuItemDebugInfo_2.Name = "MenuItemDebugInfo_2";
            this.MenuItemDebugInfo_2.Size = new System.Drawing.Size(207, 22);
            this.MenuItemDebugInfo_2.Text = "Debug Info MessageBox";
            this.MenuItemDebugInfo_2.Click += new System.EventHandler(this.MenuItemDebugInfo_2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(152, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // DebugMenuItem
            // 
            this.DebugMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DebugMenuItem2,
            this.TextBoxGod,
            this.toolStripSeparator2,
            this.toolStripMenuItem4,
            this.DebugTextBox,
            this.toolStripSeparator3});
            this.DebugMenuItem.Name = "DebugMenuItem";
            this.DebugMenuItem.Size = new System.Drawing.Size(57, 20);
            this.DebugMenuItem.Text = "Debug ";
            // 
            // DebugMenuItem2
            // 
            this.DebugMenuItem2.Name = "DebugMenuItem2";
            this.DebugMenuItem2.Size = new System.Drawing.Size(185, 22);
            this.DebugMenuItem2.Text = "Infinate Health (God)";
            this.DebugMenuItem2.Click += new System.EventHandler(this.DebugMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpeedMenuItem,
            this.SpeedMenuItem2,
            this.SpeedTextBox});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItem4.Text = "Movement Speed";
            // 
            // SpeedMenuItem
            // 
            this.SpeedMenuItem.Name = "SpeedMenuItem";
            this.SpeedMenuItem.Size = new System.Drawing.Size(160, 22);
            this.SpeedMenuItem.Text = "Speed Increase";
            this.SpeedMenuItem.Click += new System.EventHandler(this.SpeedMenuItem_Click);
            // 
            // DebugTextBox
            // 
            this.DebugTextBox.Name = "DebugTextBox";
            this.DebugTextBox.Size = new System.Drawing.Size(125, 23);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LifeLabel
            // 
            this.LifeLabel.AutoSize = true;
            this.LifeLabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LifeLabel.Location = new System.Drawing.Point(185, 31);
            this.LifeLabel.Name = "LifeLabel";
            this.LifeLabel.Size = new System.Drawing.Size(65, 13);
            this.LifeLabel.TabIndex = 15;
            this.LifeLabel.Text = "Health - 100";
            this.LifeLabel.Click += new System.EventHandler(this.LifeLabel_Click);
            // 
            // TextBoxGod
            // 
            this.TextBoxGod.Name = "TextBoxGod";
            this.TextBoxGod.Size = new System.Drawing.Size(125, 23);
            // 
            // SpeedMenuItem2
            // 
            this.SpeedMenuItem2.Name = "SpeedMenuItem2";
            this.SpeedMenuItem2.Size = new System.Drawing.Size(160, 22);
            this.SpeedMenuItem2.Text = "Speed Decrease";
            this.SpeedMenuItem2.Click += new System.EventHandler(this.SpeedMenuItem2_Click);
            // 
            // SpeedTextBox
            // 
            this.SpeedTextBox.Name = "SpeedTextBox";
            this.SpeedTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.LifeLabel);
            this.Controls.Add(this.Enemy_01);
            this.Controls.Add(this.Pear_02);
            this.Controls.Add(this.Banana_02);
            this.Controls.Add(this.Apple_02);
            this.Controls.Add(this.Pear_01);
            this.Controls.Add(this.Banana_01);
            this.Controls.Add(this.Apple_01);
            this.Controls.Add(this.Inv_05);
            this.Controls.Add(this.Inv_03);
            this.Controls.Add(this.Inv_04);
            this.Controls.Add(this.Inv_02);
            this.Controls.Add(this.Inv_01);
            this.Controls.Add(this.Life);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Text = " Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Enemy_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pear_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Banana_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Apple_01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_05)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inv_01)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player;
        private System.Windows.Forms.ProgressBar Life;
        private System.Windows.Forms.PictureBox Inv_01;
        private System.Windows.Forms.PictureBox Inv_02;
        private System.Windows.Forms.PictureBox Inv_04;
        private System.Windows.Forms.PictureBox Inv_03;
        private System.Windows.Forms.PictureBox Inv_05;
        private System.Windows.Forms.PictureBox Apple_01;
        private System.Windows.Forms.PictureBox Banana_01;
        private System.Windows.Forms.PictureBox Pear_01;
        private System.Windows.Forms.PictureBox Apple_02;
        private System.Windows.Forms.PictureBox Banana_02;
        private System.Windows.Forms.PictureBox Pear_02;
        private System.Windows.Forms.PictureBox Enemy_01;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebug;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebugInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDebugInfo_2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LifeLabel;
        private System.Windows.Forms.ToolStripMenuItem DebugMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DebugMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem SpeedMenuItem;
        private System.Windows.Forms.ToolStripTextBox DebugTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripTextBox TextBoxGod;
        private System.Windows.Forms.ToolStripMenuItem SpeedMenuItem2;
        private System.Windows.Forms.ToolStripTextBox SpeedTextBox;
    }
}