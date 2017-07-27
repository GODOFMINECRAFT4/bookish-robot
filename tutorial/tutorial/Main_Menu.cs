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
    public partial class Main_Menu : Form
    {
        public Main_Menu()
        {
            InitializeComponent();
        }

//(OpenGameButton) Game Start 
        private void OpenGameButton_Click(object sender, EventArgs e)
        {
            Game open_form = new Game();
            open_form.Visible = true;
            //this.Hide();
        }

//(GoBackButton) Go Back To Login Menu
        private void GoBackButton_Click(object sender, EventArgs e)
        {
            Form1 open_form = new Form1();
            open_form.Visible = true;
            this.Hide();
        }

//(Exit_Button) Closes Program/Application
        private void Exit_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

//(FormClosing) Closes Program/Application
        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
