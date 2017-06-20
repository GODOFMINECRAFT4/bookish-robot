using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial
{
    public partial class Form1 : Form
    {
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
            {
                // Do Nothing
            }
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
            DebugButton.Visible = true;
        }

//Debug Button Run
        private void DebugButton_Click(object sender, EventArgs e)
        {
            LevelCodeGen open_form = new LevelCodeGen();
            open_form.Visible = true;
            this.Hide();
            Skip();
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

    }
}
