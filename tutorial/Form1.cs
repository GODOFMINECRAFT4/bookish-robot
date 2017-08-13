using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace tutorial
{
    public partial class Form1 : Form
    {
        int LoginBypass;
        int NumUD1;
        int NumUD2;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DebugButton.Visible = false;
            numericUpDown1.Visible = false;
            username_box.Text = "YouTube";
            password_box.Text = "Videos_2_@";
            if (numericUpDown1.Value == 1)
            {
                DebugLoad();
            }
            else if (numericUpDown1.Value == 0)
            {/* Do Nothing */}
        }

        public void Skip()
        {
            Main_Menu open_form = new Main_Menu();
            open_form.Visible = true;
            this.Hide();
        }

        public void DebugLoad()
        {
            LevelCodeGen open_form = new LevelCodeGen();
            open_form.Visible = true;
            this.Hide();
        }

//Submit Button
        private void submit_button_Click(object sender, EventArgs e)
        {
            if (username_box.Text == "YouTube" && password_box.Text == "Videos_2_@") 
            {
                main_text.Text = "Successfully Logged In!";
                Skip();
            }
            else
            {
                main_text.Text = "Error! Username or Password is incorrect";
            }
        }
#region Debug
//Debug Button Show
        private void main_text_Click(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            DebugButton.Visible = true;
        }

//Debug Button Run
        private void DebugButton_Click(object sender, EventArgs e)
        {
            if(NumUD1 == 1)
            {

            }
            if (NumUD2 == 1)
            {

            }
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumUD1 = Convert.ToInt32(numericUpDown1.Value);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            LoginBypass = Convert.ToInt32(numericUpDown2.Value);
            if (LoginBypass == 1)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Login Menu Bypassed";
                notifyIcon1.BalloonTipTitle = "Login Menu";
                notifyIcon1.BalloonTipText = "Login Menu Bypassed";
                notifyIcon1.ShowBalloonTip(5000);
                Skip();
            }

            else if (LoginBypass == 0)
            {
                notifyIcon1.Visible = false;
                notifyIcon1.Text = "Login Menu";
                notifyIcon1.BalloonTipTitle = "Login Menu";
                notifyIcon1.BalloonTipText = "Login Menu";
                notifyIcon1.ShowBalloonTip(5000);
            }
            else if (LoginBypass == 2)
            {
                notifyIcon1.Visible = false;
                notifyIcon1.Text = "Login Menu Bypassed";
                notifyIcon1.BalloonTipTitle = "Login Menu";
                notifyIcon1.BalloonTipText = "Login Menu Bypassed";
                Skip();
            }
            else if (LoginBypass == 4)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Login Menu";
                notifyIcon1.BalloonTipTitle = "Login Menu";
                notifyIcon1.BalloonTipText = "Login Menu";
                notifyIcon1.ShowBalloonTip(5000);
            }
        }
    }
}
