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
        int Troll = 0;
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
            HideForms();
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

        private void LoadGameButton_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        public void HideForms()
        {
            Form1 open_form = new Form1();
            open_form.Visible = true;
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Troll == 1)
            {
                Troll = 2;
            }
            else if (Troll == 50)
            {
                Application.Restart();
                Application.Exit();
            }

            if (Troll >= 2)
            {
                Troll++;
            }
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
