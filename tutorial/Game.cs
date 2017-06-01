using System;
using System.IO;
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
        #region Vars
        bool right;
        bool left;
        bool up;
        bool down;
        bool GodMode = false;
        int Apple = 5;
        int Pear = 10;
        int Banana = 15;
        int Speed = 5;
        string DebugText;
        string downtext;
        string uptext;
        string lefttext;
        string righttext;
        string WASDText;
        #endregion

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
            downtext = "Down = " + down + "   ";
            uptext = "Up = " + up + "   ";
            lefttext = "Left = " + left + "   ";
            righttext = "Right = " + right + "   ";
            WASDText = downtext + uptext + lefttext + righttext;

            if (up == true)
            {
                Player.Top -= Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                System.Console.WriteLine(WASDText);
            }

            if (down == true)
            {
                Player.Top += Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                System.Console.WriteLine(WASDText);
            }

            if (left == true)
            {
                Player.Left -= Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                System.Console.WriteLine(WASDText);
            }

            if (right == true)
            {
                Player.Left += Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                System.Console.WriteLine(WASDText);
            }
        }

        public void timer2_Tick(object sender, EventArgs time)
        {
  /*         if (timer2.Equals(timer2))
            {
                EnemyCollisons();
            }  */

            if (timer2.Tag.Equals("on"))
            {
                EnemyCollisons();
            }
        }

        public void timer3_Tick(object sender, EventArgs time)
        {
            /*        if (timer3.Equals(timer2))
                       {
                           Collisions();
                       }  */

            if (timer3.Tag.Equals("on"))
            {
                Collisions();
            }
        }

        #endregion
        #region Controls

        private void Game_KeyUp(object sender, KeyEventArgs key)
        {
            #region WASD Keys
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
            #endregion
            #region NumPad Keys
            if (key.KeyCode == Keys.NumPad0)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad1)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad2)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad3)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad4)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad5)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad6)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad7)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad8)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad9)
            {
                // Enter Code here
            }
            #endregion
        }

        private void Game_KeyDown(object sender, KeyEventArgs key)
        {
            #region WASD Keys
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
            #region NumPad Keys
            if (key.KeyCode == Keys.NumPad0)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad1)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad2)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad3)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad4)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad5)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad6)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad7)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad8)
            {
                // Enter Code here
            }

            if (key.KeyCode == Keys.NumPad9)
            {
                // Enter Code here
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
            if (key.KeyCode == Keys.VolumeUp)
            {
                Speed = Speed + 1;
                SpeedTextBox.Text = "Speed = " + Speed;
                DebugTextBox.Text = "Speed = " + Speed;
                SpeedLabel.Text = "Speed = " + Speed;
                SpeedLabel2.Text = "Speed = " + Speed;
            }

            if(key.KeyCode == Keys.VolumeDown)
            {
                Speed = Speed - 1;
                SpeedTextBox.Text = "Speed = " + Speed;
                DebugTextBox.Text = "Speed = " + Speed;
                SpeedLabel.Text = "Speed = " + Speed;
                SpeedLabel2.Text = "Speed = " + Speed;
            }

            if (key.KeyCode == Keys.VolumeMute)
            {
                Speed = 5;
                SpeedTextBox.Text = "Speed = " + Speed;
                DebugTextBox.Text = "Speed = " + Speed;
                SpeedLabel.Text = "Speed = " + Speed;
                SpeedLabel2.Text = "Speed = " + Speed;
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
                LifeLabel.Text = "Health = " + Life.Value;
                Life2.Value -= lose;
                LifeLabel2.Text = "Health = " + Life2.Value;
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
                LifeLabel.Text = "Health = " + Life.Value;
                Life2.Value += gain;
                LifeLabel2.Text = "Health = " + Life2.Value;
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
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_01);
                }
            }

            else if (Inv_01.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_01);
                }
            }

            // Pears
            else if (Inv_01.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_01);
                }
            }

            else if (Inv_01.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_01);
                }
            }

        }
// Inv_02
        private void Inv_02_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_02.Tag);
            // Apples           
            if (Inv_02.Tag == Apple_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_02);
                }
            }

            else if (Inv_02.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_02);
                }
            }

            // Bananas
            else if (Inv_02.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_02);
                }
            }

            else if (Inv_02.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_02);
                }
            }

            // Pears
            else if (Inv_02.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_02);
                }
            }

            else if (Inv_02.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_02);
                }
            }
        }
// Inv_03
        private void Inv_03_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_03.Tag);
            // Apples           
            if (Inv_03.Tag == Apple_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_03);
                }
            }

            else if (Inv_03.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_03);
                }
            }

            // Bananas
            else if (Inv_03.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_03);
                }
            }

            else if (Inv_03.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_03);
                }
            }

            // Pears
            else if (Inv_03.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_03);
                }
            }

            else if (Inv_03.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_03);
                }
            }
        }
// Inv_04
        private void Inv_04_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_04.Tag);
            // Apples           
            if (Inv_04.Tag == Apple_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_04);
                }
            }

            else if (Inv_04.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_04);
                }
            }

            // Bananas
            else if (Inv_04.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_04);
                }
            }

            else if (Inv_04.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_04);
                }
            }

            // Pears
            else if (Inv_04.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_04);
                }
            }

            else if (Inv_04.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_04);
                }
            }
        }
// Inv_05
        private void Inv_05_CLick(object sender, EventArgs e)
        {
            System.Console.WriteLine(Inv_05.Tag);
            // Apples           
            if (Inv_05.Tag == Apple_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_05);
                }
            }

            else if (Inv_05.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < Life.Maximum)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_05);
                }
            }

            // Bananas
            else if (Inv_05.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_05);
                }
            }

            else if (Inv_05.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < Life.Maximum)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_05);
                }
            }

            // Pears
            else if (Inv_05.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_05);
                }
            }

            else if (Inv_05.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < Life.Maximum)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_05);
                }
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
        #region Show Hidden Debug
        private void LifeLabel_Click(object sender, EventArgs e)
        {
            DebugMenuItem.Visible = false;
        }

        private void Life_Click(object sender, EventArgs e)
        {
            DebugMenuItem.Visible = true;
        }

        private void LifeLabel2_Click(object sender, EventArgs e)
        {
            DebugMenuItem.Visible = false;
        }

        private void Life2_Click(object sender, EventArgs e)
        {
            DebugMenuItem.Visible = true;
        }

        #endregion

        private void DebugMenuItem2_Click(object sender, EventArgs e)
        {
            //God Mode, Infinate Health
            if (!GodMode)
            {
                GodMode = true;
                TextBoxGod.Text = "God Mode = " + GodMode ;
                Life.Value = 100;
                LifeLabel.Text = "Health - " + Life.Value;
                Life2.Value = 100;
                LifeLabel2.Text = "Health - " + Life2.Value;
            }

            else
            {
                GodMode = false;
                TextBoxGod.Text = "God Mode = " + GodMode;
            }
        }

        private void SpeedMenuItem_Click(object sender, EventArgs e)
        {
            Speed = Speed + 10;
            SpeedTextBox.Text = "Speed = " + Speed;
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedLabel.Text = "Speed = " + Speed;
            SpeedLabel2.Text = "Speed = " + Speed;
        }

        private void SpeedMenuItem2_Click(object sender, EventArgs e)
        {
            Speed = Speed - 10;
            SpeedTextBox.Text = "Speed = " + Speed;
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedLabel.Text = "Speed = " + Speed;
            SpeedLabel2.Text = "Speed = " + Speed;
        }

        private void SpeedMenuItem3_Click(object sender, EventArgs e)
        {
            Speed = 5;
            SpeedTextBox.Text = "Speed = " + Speed;
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedLabel.Text = "Speed = " + Speed;
            SpeedLabel2.Text = "Speed = " + Speed;
        }

        #endregion
        #region Game Form Voids
        private void Game_Activated(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Game";
            notifyIcon1.BalloonTipTitle = "Game";
            notifyIcon1.BalloonTipText = "Game Form Active";
            notifyIcon1.ShowBalloonTip(10000);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }
        #endregion

        public void Reset()
        {
            Text = "Game";
            GodMode = false;
            Life.Value = 100;
            Life2.Value = 100;
            Inv_01.Tag = null;
            Inv_02.Tag = null;
            Inv_03.Tag = null;
            Inv_04.Tag = null;
            Inv_05.Tag = null;
            DebugText = null;
            timer2.Tag = "on";
            richTextBox1.Visible = false;
            DebugMenuItem.Visible = false;
            SpeedLabel.Text = "Speed = " + Speed;
            SpeedLabel2.Text = "Speed = " + Speed;
            DebugTextBox.Text = "Speed = " + Speed;
            SpeedTextBox.Text = "Speed = " + Speed;
            TextBoxGod.Text = "God Mode = " + GodMode;
            LifeLabel.Text = "Health = " + Life.Value;
            LifeLabel2.Text = "Health = " + Life2.Value;
            downtext = "Down = " + down;
            uptext = "Up = " + up;
            lefttext = "Left = " + left;
            righttext = "Right = " + right;
            WASDText = downtext + uptext + lefttext + righttext;
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
            Reset();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible == false)
            {
                richTextBox1.Visible = true;
            }

            else if (richTextBox1.Visible == true)
            {
                richTextBox1.Visible = false;
            }               
        }

        public void ButtonIDSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "test.txt")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }
    }
}
