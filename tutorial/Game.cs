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
    public partial class Game : Form
    {
        bool right;
        bool left;
        bool up;
        bool down;
        bool GodMode = false;
        int Speed = 10;
        string DebugText ;
        
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Reset();
        }

        #region Controls
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up == true)
            {
                Player.Top -= Speed;
            }

            if (down == true)
            {
                Player.Top += Speed;
            }

            if (left == true)
            {
                Player.Left -= Speed;
            }

            if (right == true)
            {
                Player.Left += Speed;
            }
        }

        private void Game_KeyUp(object sender, KeyEventArgs key)
        {
// Up And Down Movement
         if (key.KeyCode == Keys.W)
            {
             //enter Code Here
             up = false;
            }

            if (key.KeyCode == Keys.S)
            {
             //enter Code Here
             down = false;
            }

            // Left And Right Movement
            if (key.KeyCode == Keys.A)
            {
             //enter Code Here
             left = false;
            }
            if (key.KeyCode == Keys.D)
            {
             //enter Code Here
             right = false;
            }
        }

        private void Game_KeyDown(object sender, KeyEventArgs key)
        {
            #region Movement
// Up And Down Movement
            if (key.KeyCode == Keys.W)
            {
                //Player.Top -= 5;
                up = true;
            }

            if (key.KeyCode == Keys.S)
            {
                //Player.Top += 5;
                down = true;
            }

            // Left And Right Movement
            if (key.KeyCode == Keys.A)
            {
                //Player.Left -= 5;
                left = true;
            }

            if (key.KeyCode == Keys.D)
            {
                //Player.Left += 5;
                right = true;
            }
            // Left + Right  Movement keys at once
            if (key.KeyCode == Keys.Left && key.KeyCode == Keys.Right)
            { 
                right = false;
                left = false;
            }
            #endregion
            #region Life_Test
            // Life
            if (key.KeyCode == Keys.H)
            {
                LoseHealth(10);
            }

            if (key.KeyCode == Keys.J)
            {
                GainHealth(10);
            }

            #endregion
            Collisions();
        }

        #endregion

        public void Collisions()
        {
//Apples
            if (Player.Bounds.IntersectsWith(Apple_01.Bounds))
            {          
                AddToInv(Apple_01);
            }
           else if (Player.Bounds.IntersectsWith(Apple_02.Bounds))
            {
                AddToInv(Apple_02);
            }
//Bananas
            else if (Player.Bounds.IntersectsWith(Banana_01.Bounds))
            {
                AddToInv(Banana_01);
            }
            else if (Player.Bounds.IntersectsWith(Banana_02.Bounds))
            {
                AddToInv(Banana_02);
            }
//Pears
            else if (Player.Bounds.IntersectsWith(Pear_01.Bounds))
            {
                AddToInv(Pear_01);
            }
            else if (Player.Bounds.IntersectsWith(Pear_02.Bounds))
            {
               AddToInv(Pear_02);
            }
//Enemys
            else if (Player.Bounds.IntersectsWith(Enemy_01.Bounds))
            {
                if (GodMode == false)
                {
                  //DamageValues(10);
                  LoseHealth(1 * 5);
                }

                if (GodMode == true)
                {
                    LoseHealth(1 * 0);
                }
            }
        }

        #region Health  
             
        public void LoseHealth(int lose)
        {
            if (Life.Value == Life.Minimum)
            {
                MessageBox.Show("Error Cannot Go Lower Than 0");
            }
            else if (Life.Value > Life.Minimum)
            {
                Life.Value -= lose;
                LifeLabel.Text = "Health - " + Life.Value;
            }
            //Life.Value -= 10;
        }

        public void GainHealth(int gain)
        {
            if (Life.Value == Life.Maximum)
            {
                MessageBox.Show("Error Cannot Go Higher Than 100");
            }
            else if (Life.Value < Life.Maximum)
            {
                Life.Value += gain;
                LifeLabel.Text = "Health - " + Life.Value;
            }
            //Life.Value += 10;
        }

        public void DamageValues(int Damage)
        { 
            if (Player.Bounds.IntersectsWith(Enemy_01.Bounds))
                Damage = 10;
        }

        #endregion

        public void AddToInv(PictureBox item)
        {
            if (Inv_01.Tag == null)
            {
                Inv_01.Image = item.Image;
                Inv_01.Tag = item.Tag;
                item.Top = 2000;        
            }

            else if (Inv_02.Tag == null)
            {
                Inv_02.Image = item.Image;
                Inv_02.Tag = item.Tag;
                item.Top = 2000;
            }

            else if (Inv_03.Tag == null)
            {
                Inv_03.Image = item.Image;
                Inv_03.Tag = item.Tag;
                item.Top = 2000;
            }

            else if (Inv_04.Tag == null)
            {
                Inv_04.Image = item.Image;
                Inv_04.Tag = item.Tag;
                item.Top = 2000;
            }
            
            else if (Inv_05.Tag == null)
            {
                Inv_05.Image = item.Image;
                Inv_05.Tag = item.Tag;
                item.Top = 2000;
            }
        }

        public void TakeFromInv(PictureBox item)
        {
            item.Image = null;
            item.Tag = null;
        }

        public void Reset()
        {
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedTextBox.Text = "Speed = " + Speed;
            TextBoxGod.Text = "God Mode = " + GodMode;
            LifeLabel.Text = "Health - " + Life.Value;
            DebugMenuItem.Visible = false;
            Inv_01.Tag = null;
            Inv_02.Tag = null;
            Inv_03.Tag = null;
            Inv_04.Tag = null;
            Inv_05.Tag = null;
            DebugText = null;
            Life.Value = 100;
            GodMode = false;
            Text = "Game";
        }

        #region Inv_Click
        // Inv_01
        private void Inv_01_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_01.Tag);
            // Apples           
            if (Inv_01.Tag == Apple_01.Tag)
            {
                TakeFromInv(Inv_01);
                GainHealth(5);
            }

           else if (Inv_01.Tag == Apple_02.Tag)
            {
                TakeFromInv(Inv_01);
                GainHealth(5);
            }

            // Bananas
            else if (Inv_01.Tag == Banana_01.Tag)
            {
                TakeFromInv(Inv_01);
                GainHealth(10);

            }
            else if (Inv_01.Tag == Banana_02.Tag)
            {

                TakeFromInv(Inv_01);
                GainHealth(10);
            }

            // Pears
            else if (Inv_01.Tag == Pear_01.Tag)
            {

                TakeFromInv(Inv_01);
                GainHealth(10);
            }

            else if (Inv_01.Tag == Pear_02.Tag)
            {

                TakeFromInv(Inv_01);
                GainHealth(10);
            }

        }
// Inv_02
        private void Inv_02_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_02.Tag);
            // Apples           
            if (Inv_02.Tag == Apple_01.Tag)
            {
                TakeFromInv(Inv_02);
                GainHealth(5);
            }

            else if (Inv_02.Tag == Apple_02.Tag)
            {
                TakeFromInv(Inv_02);
                GainHealth(5);
            }

            // Bananas
            else if (Inv_02.Tag == Banana_01.Tag)
            {
                TakeFromInv(Inv_02);
                GainHealth(10);

            }
            else if (Inv_02.Tag == Banana_02.Tag)
            {

                TakeFromInv(Inv_02);
                GainHealth(10);
            }

            // Pears
            else if (Inv_02.Tag == Pear_01.Tag)
            {

                TakeFromInv(Inv_02);
                GainHealth(10);
            }

            else if (Inv_02.Tag == Pear_02.Tag)
            {

                TakeFromInv(Inv_02);
                GainHealth(10);
            }
        }
// Inv_03
        private void Inv_03_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_03.Tag);
            // Apples           
            if (Inv_03.Tag == Apple_01.Tag)
            {
                TakeFromInv(Inv_03);
                GainHealth(5);
            }

            else if (Inv_03.Tag == Apple_02.Tag)
            {
                TakeFromInv(Inv_03);
                GainHealth(5);
            }

            // Bananas
            else if (Inv_03.Tag == Banana_01.Tag)
            {
                TakeFromInv(Inv_03);
                GainHealth(10);

            }
            else if (Inv_03.Tag == Banana_02.Tag)
            {

                TakeFromInv(Inv_03);
                GainHealth(10);
            }

            // Pears
            else if (Inv_03.Tag == Pear_01.Tag)
            {

                TakeFromInv(Inv_03);
                GainHealth(10);
            }

            else if (Inv_03.Tag == Pear_02.Tag)
            {

                TakeFromInv(Inv_03);
                GainHealth(10);
            }
        }
// Inv_04
        private void Inv_04_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_04.Tag);
            // Apples           
            if (Inv_04.Tag == Apple_01.Tag)
            {
                TakeFromInv(Inv_04);
                GainHealth(5);
            }

            else if (Inv_04.Tag == Apple_02.Tag)
            {
                TakeFromInv(Inv_04);
                GainHealth(5);
            }

            // Bananas
            else if (Inv_04.Tag == Banana_01.Tag)
            {
                TakeFromInv(Inv_04);
                GainHealth(10);

            }
            else if (Inv_04.Tag == Banana_02.Tag)
            {

                TakeFromInv(Inv_04);
                GainHealth(10);
            }

            // Pears
            else if (Inv_04.Tag == Pear_01.Tag)
            {

                TakeFromInv(Inv_04);
                GainHealth(10);
            }

            else if (Inv_04.Tag == Pear_02.Tag)
            {

                TakeFromInv(Inv_04);
                GainHealth(10);
            }
        }
// Inv_05
        private void Inv_05_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_05.Tag);
            // Apples           
            if (Inv_05.Tag == Apple_01.Tag)
            {
                TakeFromInv(Inv_05);
                GainHealth(5);
            }

            else if (Inv_05.Tag == Apple_02.Tag)
            {
                TakeFromInv(Inv_05);
                GainHealth(5);
            }

            // Bananas
            else if (Inv_05.Tag == Banana_01.Tag)
            {
                TakeFromInv(Inv_05);
                GainHealth(10);

            }
            else if (Inv_05.Tag == Banana_02.Tag)
            {

                TakeFromInv(Inv_05);
                GainHealth(10);
            }

            // Pears
            else if (Inv_05.Tag == Pear_01.Tag)
            {

                TakeFromInv(Inv_05);
                GainHealth(10);
            }

            else if (Inv_05.Tag == Pear_02.Tag)
            {

                TakeFromInv(Inv_05);
                GainHealth(10);
            }
        }
        #endregion
        #region Debug menu 1
        private void MenuItemDebugInfo_Click(object sender, EventArgs e)
        {
            #region Inv_Check
            if (Inv_01.Tag != null)
            {
                System.Console.WriteLine("Inv_01 is Full");
                System.Console.WriteLine(Inv_01);
                System.Console.WriteLine(" ");
            }
            else if (Inv_01.Tag == null)
            {
                System.Console.WriteLine("Inv_01 is Empty");
                System.Console.WriteLine("Inv_01 = null");
                System.Console.WriteLine(" ");
            }

            if (Inv_02.Tag != null)
            {
                System.Console.WriteLine("Inv_02 is Full");
                System.Console.WriteLine(Inv_02.Tag);
                System.Console.WriteLine(" ");
            }
            else if (Inv_02.Tag == null)
            {
                System.Console.WriteLine("Inv_02 is Empty");
                System.Console.WriteLine("Inv_02 = null");
                System.Console.WriteLine(" ");
            }

            if (Inv_03.Tag != null)
            {
                System.Console.WriteLine("Inv_03 is Full");
                System.Console.WriteLine(Inv_01.Tag);
                System.Console.WriteLine(" ");
            }
            else if (Inv_03.Tag == null)
            {
                System.Console.WriteLine("Inv_03 is Empty");
                System.Console.WriteLine("Inv_03 = null");
                System.Console.WriteLine(" ");
            }

            if (Inv_04.Tag != null)
            {
                System.Console.WriteLine("Inv_04 is Full");
                System.Console.WriteLine(Inv_01.Tag);
                System.Console.WriteLine(" ");
            }
            else if (Inv_04.Tag == null)
            {
                System.Console.WriteLine("Inv_04 is Empty");
                System.Console.WriteLine("Inv_04 = null");
                System.Console.WriteLine(" ");
            }

            if (Inv_05.Tag != null)
            {
                System.Console.WriteLine("Inv_05 is Full");
                System.Console.WriteLine(Inv_01.Tag);
                System.Console.WriteLine(" ");
            }
            else if (Inv_05.Tag == null)
            {
                System.Console.WriteLine("Inv_05 is Empty");
                System.Console.WriteLine("Inv_05 = null");
                System.Console.WriteLine(" ");
            }
            #endregion
        }
        private void MenuItemDebugInfo_2_Click(object sender, EventArgs e)
        {
            #region Inv_Check
            if (Inv_01.Tag != null)
            {
                DebugText = "Inv_01 is Full \n";
            }
            else if (Inv_01.Tag == null)
            {
                DebugText = "Inv_01 is Empty \n";
            }

            if (Inv_02.Tag != null)
            {
                DebugText = DebugText + "Inv_02 is Full \n";
            }
            else if (Inv_02.Tag == null)
            {
                DebugText = DebugText + "Inv_02 is Empty \n";
            }

            if (Inv_03.Tag != null)
            {
                DebugText = DebugText + "Inv_03 is Full \n";
            }
            else if (Inv_03.Tag == null)
            {
                DebugText = DebugText + "Inv_03 is Empty \n";
            }

            if (Inv_04.Tag != null)
            {
                DebugText = DebugText + "Inv_04 is Full \n";
            }
            else if (Inv_04.Tag == null)
            {
                DebugText = DebugText + "Inv_04 is Empty \n";
            }

            if (Inv_05.Tag != null)
            {
                DebugText = DebugText + "Inv_05 is Full \n";
            }
            else if (Inv_05.Tag == null)
            {
                DebugText = DebugText + "Inv_05 is Empty \n";
            }
            #endregion
            
            MessageBox.Show(Text);
            Text = "Game";
        }
        #endregion
        #region Debug Menu 2

        private void LifeLabel_Click(object sender, EventArgs e)
        {
            DebugMenuItem.Visible = false;
        }

        private void Life_Click(object sender, EventArgs e)
        {
            DebugMenuItem.Visible = true;
        }

        private void DebugMenuItem2_Click(object sender, EventArgs e)
        {
            //God Mode, Infinate Health
            if (!GodMode)
            {
                GodMode = true;
                TextBoxGod.Text = "God Mode = " + GodMode ;
                Life.Value = 100;
                LifeLabel.Text = "Health - " + Life.Value;
            }

            else
            {
                GodMode = false;
                TextBoxGod.Text = "God Mode = " + GodMode;
            }
        }

        private void SpeedMenuItem_Click(object sender, EventArgs e)
        {
            Speed = Speed + 1;
            SpeedTextBox.Text = "Speed" + Speed;
            DebugTextBox.Text = "Speed" + Speed;
        }

        private void SpeedMenuItem2_Click(object sender, EventArgs e)
        {
            Speed = Speed - 1;
            SpeedTextBox.Text = "Speed" + Speed;
            DebugTextBox.Text = "Speed" + Speed;
        }

        #endregion

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Reset();
        }

    }
}
