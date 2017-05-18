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
        int Apple = 5;
        int Pear = 10;
        int Banana = 15;
        int Speed = 5;
        string DebugText ;
        
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            Reset();
        }

        #region Timers

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
        public void timer2_Tick(object sender, EventArgs time)
        {
  /*         if (timer2.Equals(timer2))
            {
                EnemyCollisons();
            }  */

            if (timer2.Tag == "on")
            {
                EnemyCollisons();
            }
        }

        #endregion
        #region Controls

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
            #region Speed Test
            //Speed Values
            if (key.KeyCode == Keys.PageUp)
            {
                Speed = Speed + 1;
                SpeedTextBox.Text = "Speed = " + Speed;
                DebugTextBox.Text = "Speed = " + Speed;
                SpeedLabel.Text = "Speed = " + Speed;
            }

            if(key.KeyCode == Keys.PageDown)
            {
                Speed = Speed - 1;
                SpeedTextBox.Text = "Speed = " + Speed;
                DebugTextBox.Text = "Speed = " + Speed;
                SpeedLabel.Text = "Speed = " + Speed;
            }
           

            #endregion
            Collisions();
            EnemyCollisons();
        }

        #endregion
        #region Collisions
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
        }

        public void EnemyCollisons()
        {
            if (Player.Bounds.IntersectsWith(Enemy_01.Bounds))
            {
                if (GodMode == false)
                {
                    //DamageValues(10);
                    LoseHealth(1 * 5);
                }

                else if (GodMode == true)
                {
                    LoseHealth(1 * 0);
                }
            }
        }
         
        #endregion
        #region Health

        public void LoseHealth(int lose)
        {
            if (Life.Value == Life.Minimum)
            {
                System.Console.WriteLine("Health Min");

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
                System.Console.WriteLine("Health Max");
            }
            else if (Life.Value + gain < Life.Maximum + 1)
            {
                Life.Value += gain;
                LifeLabel.Text = "Health - " + Life.Value;
            }

            else if (Life.Value + gain > Life.Maximum)
            {
                System.Console.WriteLine("Health Cant Go Above 100 Idiot");
            }
            //Life.Value += 10;
        }

        public void DamageValues(int Damage)
        { 
            if (Player.Bounds.IntersectsWith(Enemy_01.Bounds))
                Damage = 10;
        }

        #endregion
        #region Inv
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
        #endregion
        public void Reset()
        {
            Text = "Game";
            GodMode = false;
            Life.Value = 100;
            Inv_01.Tag = null;
            Inv_02.Tag = null;
            Inv_03.Tag = null;
            Inv_04.Tag = null;
            Inv_05.Tag = null;
            DebugText = null;
            timer2.Tag = "on";
            DebugMenuItem.Visible = false;
            SpeedLabel.Text = "Speed = " + Speed;
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedTextBox.Text = "Speed = " + Speed;
            TextBoxGod.Text = "God Mode = " + GodMode;
            LifeLabel.Text = "Health - " + Life.Value;
        }

        #region Inv_Click
        // Inv_01
        private void Inv_01_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_01.Tag);
            // Apples           
            if (Inv_01.Tag == Apple_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value  + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_01);
                }
            }

           else if (Inv_01.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_01);
                }
            }

            // Bananas
            else if (Inv_01.Tag == Banana_01.Tag)
            {
                TakeFromInv(Inv_01);
                GainHealth(Banana);

            }
            else if (Inv_01.Tag == Banana_02.Tag)
            {

                TakeFromInv(Inv_01);
                GainHealth(Banana);
            }

            // Pears
            else if (Inv_01.Tag == Pear_01.Tag)
            {

                TakeFromInv(Inv_01);
                GainHealth(Pear);
            }

            else if (Inv_01.Tag == Pear_02.Tag)
            {

                TakeFromInv(Inv_01);
                GainHealth(Pear);
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
                System.Console.WriteLine(Inv_01.Tag);
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
                System.Console.WriteLine(Inv_03.Tag);
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
                System.Console.WriteLine(Inv_04.Tag);
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
                System.Console.WriteLine(Inv_05.Tag);
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
                DebugText = DebugText + Inv_01.Tag + "\n";
            }
            else if (Inv_01.Tag == null)
            {
                DebugText = "Inv_01 is Empty \n";
                DebugText = DebugText + "Inv_01 = null \n";
            }

            if (Inv_02.Tag != null)
            {
                DebugText = DebugText + "Inv_02 is Full \n";
                DebugText = DebugText + Inv_02.Tag + "\n";
            }
            else if (Inv_02.Tag == null)
            {
                DebugText = DebugText + "Inv_02 is Empty \n";
                DebugText = DebugText + "Inv_02 = null \n";
            }

            if (Inv_03.Tag != null)
            {
                DebugText = DebugText + "Inv_03 is Full \n";
                DebugText = DebugText + Inv_03.Tag + "\n";
            }
            else if (Inv_03.Tag == null)
            {
                DebugText = DebugText + "Inv_03 is Empty \n";
                DebugText = DebugText + "Inv_03 = null \n";
            }

            if (Inv_04.Tag != null)
            {
                DebugText = DebugText + "Inv_04 is Full \n";
                DebugText = DebugText + Inv_04.Tag + "\n";
            }
            else if (Inv_04.Tag == null)
            {
                DebugText = DebugText + "Inv_04 is Empty \n";
                DebugText = DebugText + "Inv_04 = null \n";
            }

            if (Inv_05.Tag != null)
            {
                DebugText = DebugText + "Inv_05 is Full \n";
                DebugText = DebugText + Inv_05.Tag + "\n";
            }
            else if (Inv_05.Tag == null)
            {
                DebugText = DebugText + "Inv_05 is Empty \n";
                DebugText = DebugText + "Inv_05 = null \n";
            }
            #endregion
            
            MessageBox.Show(DebugText);
            DebugText = null;
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
            Speed = Speed + 5;
            SpeedTextBox.Text = "Speed = " + Speed;
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedLabel.Text = "Speed = " + Speed;
        }

        private void SpeedMenuItem2_Click(object sender, EventArgs e)
        {
            Speed = Speed - 5;
            SpeedTextBox.Text = "Speed = " + Speed;
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedLabel.Text = "Speed = " + Speed;
        }

        #endregion

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Reset();
        }
    }
}
