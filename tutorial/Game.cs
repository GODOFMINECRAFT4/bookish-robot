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
        int Popup = 0;              // Show Game Start Notification       {1 = True, 0 = False}
        int WASDTextConsole = 0;    // Show WASD KeyPress info In Console {1 = True, 0 = False}
        bool right;                 // Right KeyPress   Var {True = Pressed, False = Not Pressed}
        bool left;                  // Left  KeyPress   Var {True = Pressed, False = Not Pressed}
        bool up;                    // Up    KeyPress   Var {True = Pressed, False = Not Pressed}
        bool down;                  // Down  KeyPress   Var {True = Pressed, False = Not Pressed}
        bool GodMode = false;       // God Mode Enabled Var {True = Pressed, False = Not Pressed}
        int Apple = 5;              // Apple   Health Gain Value
        int Pear = 10;              // Pear    Health Gain Value
        int Banana = 15;            // Banana  Health Gain Value
        int Speed = 5;              // Speed Value Var
        int Debug = 1;              // Debug  Enabled Var {1 = True, 0 = False}
        int NumPadEnable = 1;       // NumPad Enabled Var {1 = True, 0 = False}
        int HealthBarTotal = 101;   // HealthBarTotal Var {Life.Maximum + 1}
        string DebugText;           // Inv Check Text Store Var
        string downtext;            // downtext = "Down = " + down + "   "
        string uptext;              // uptext = "Up = " + up + "   "
        string lefttext;            // lefttext = "Left = " + left + "   "
        string righttext;           // righttext = "Right = " + right + "   "
        string WASDText;            // WASDText = downtext + uptext + lefttext + righttext
        #endregion
        #region Entity List Vars
        int player;
        int apple_01;
        int apple_02;
        int banana_01;
        int banana_02;
        int pear_01;
        int pear_02;
        int enemy_01;
        string EntityList = "";
        #endregion
        #region Level Vars
        int tree1 = 0;
        int Wall = 10;
        int Level = 1;
        int[] Walls;
        #endregion
        #region Form Init
        public Game()
        {
            InitializeComponent();

        }

        private void Game_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            FormLoad();
            Reset();
    }
        #endregion
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
                Player1.Top -= Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                if (WASDTextConsole == 1)
                {
                    System.Console.WriteLine(WASDText);
                }
            }

            if (down == true)
            {
                Player1.Top += Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                if (WASDTextConsole == 1)
                {
                    System.Console.WriteLine(WASDText);
                }
            }

            if (left == true)
            {
                Player1.Left -= Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                if (WASDTextConsole == 1)
                {
                    System.Console.WriteLine(WASDText);
                }
            }

            if (right == true)
            {
                Player1.Left += Speed;
                richTextBox1.Text = richTextBox1.Text + WASDText + Environment.NewLine;
                if (WASDTextConsole == 1)
                {
                    System.Console.WriteLine(WASDText);
                }
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
             up = false;
            }

            if (key.KeyCode == Keys.S)
            {
             down = false;
            }

            // Left And Right Movement
            if (key.KeyCode == Keys.A)
            {
             left = false;
            }

            if (key.KeyCode == Keys.D)
            {
             right = false;
            }
            #endregion
            #region Number Keys
             if (key.KeyCode == Keys.D1)
            {
                if (Inv_01.Tag == null)
                {
                    Console.WriteLine("Inv_01 Is Currently Null Aka Empty");
                }
                else if (Inv_01.Tag != null)
                {
                    Console.WriteLine("Inv_01 Has a " + Inv_01.Tag + " In it."); ;
                }
            }

            if (key.KeyCode == Keys.D2)
            {
                if (Inv_02.Tag == null)
                {
                    Console.WriteLine("Inv_02 Is Currently Null Aka Empty");
                }
                else if (Inv_02.Tag != null)
                {
                    Console.WriteLine("Inv_02 Has a " + Inv_02.Tag + " In it.");
                }
            }

            if (key.KeyCode == Keys.D3)
            {
                if (Inv_03.Tag == null)
                {
                    Console.WriteLine("Inv_03 Is Currently Null Aka Empty");
                }
                else if (Inv_03.Tag != null)
                {
                    Console.WriteLine("Inv_03 Has a " + Inv_03.Tag + " In it.");
                }
            }

            if (key.KeyCode == Keys.D4)
            {
                if (Inv_04.Tag == null)
                {
                    Console.WriteLine("Inv_04 Is Currently Null Aka Empty");
                }
                else if (Inv_04.Tag != null)
                {
                    Console.WriteLine("Inv_04 Has a " + Inv_04.Tag + " In it.");
                }
            }

            if (key.KeyCode == Keys.D5)
            {
                if (Inv_05.Tag == null)
                {
                    Console.WriteLine("Inv_05 Is Currently Null Aka Empty");
                }
                else if (Inv_05.Tag != null)
                {
                    Console.WriteLine("Inv_05 Has a " + Inv_05.Tag + " In it.");
                }
            }
            #endregion
        }

        private void Game_KeyDown(object sender, KeyEventArgs key)
        {
            #region WASD Keys
// Up And Down Movement
            if (key.KeyCode == Keys.W)
            {
                up = true;
            }

            if (key.KeyCode == Keys.S)
            {
                down = true;
            }

            // Left And Right Movement
            if (key.KeyCode == Keys.A)
            {
                left = true;
            }

            if (key.KeyCode == Keys.D)
            {
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
                if (NumPadEnable == 1)
                {}
                else if(NumPadEnable == 0)
                {}
            }

            if (key.KeyCode == Keys.NumPad1)
            {
                if (NumPadEnable == 1)
                {}
                else if (NumPadEnable == 0)
                {}
            }

            if (key.KeyCode == Keys.NumPad2)
            {
                if (NumPadEnable == 1)
                {}
                else if (NumPadEnable == 0)
                {}
            }

            if (key.KeyCode == Keys.NumPad3)
            {
                if (NumPadEnable == 1)
                {}
                else if (NumPadEnable == 0)
                { }
            }

            if (key.KeyCode == Keys.NumPad4)
            {
                if (NumPadEnable == 1)
                { }
                else if (NumPadEnable == 0)
                { }
            }

            if (key.KeyCode == Keys.NumPad5)
            {
                if (NumPadEnable == 1)
                { }
                else if (NumPadEnable == 0)
                { }
            }

            if (key.KeyCode == Keys.NumPad6)
            {
                if (NumPadEnable == 1)
                { }
                else if (NumPadEnable == 0)
                { }
            }

            if (key.KeyCode == Keys.NumPad7)
            {
                if (NumPadEnable == 1)
                { }
                else if (NumPadEnable == 0)
                { }
            }

            if (key.KeyCode == Keys.NumPad8)
            {
                if (NumPadEnable == 1)
                { }
                else if (NumPadEnable == 0)
                { }
            }

            if (key.KeyCode == Keys.NumPad9)
            {
                if (NumPadEnable == 1)
                { }
                else if (NumPadEnable == 0)
                { }
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
        #region -Click
        private void MenuItemExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
            Reset();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            if (Debug == 1)
            {
                if (richTextBox1.Visible == false)
                {
                    richTextBox1.Visible = true;
                }

                else if (richTextBox1.Visible == true)
                {
                    richTextBox1.Visible = false;
                }
                else if (Debug == 0)
                {
                    richTextBox1.Visible = false;
                }
            }
        }

        public void ButtonIDSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save KeyLog Output File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "test.txt")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        public void ArrayMenuItem_Click(object sender, EventArgs e)
        {
            EntityList = "Player = " + player + Environment.NewLine;
            EntityList += "Apple_01 = " + apple_01 + Environment.NewLine;
            EntityList += "Apple_02 = " + apple_02 + Environment.NewLine;
            EntityList += "Banana_01 = " + banana_01 + Environment.NewLine;
            EntityList += "Banana_02 = " + banana_02 + Environment.NewLine;
            EntityList += "Pear_01 = " + pear_01 + Environment.NewLine;
            EntityList += "Pear_02 = " + pear_02 + Environment.NewLine;
            EntityList += "Enemy_01 = " + enemy_01 + Environment.NewLine;
            MessageBox.Show(EntityList, "EntityList");
        }

        #endregion
        #region Collisions
        public void Collisions()
        {
//Apples
            if (Player1.Bounds.IntersectsWith(Apple_01.Bounds))
            {          
                AddToInv(Apple_01);
            }
           else if (Player1.Bounds.IntersectsWith(Apple_02.Bounds))
            {
                AddToInv(Apple_02);
            }
//Bananas
            else if (Player1.Bounds.IntersectsWith(Banana_01.Bounds))
            {
                AddToInv(Banana_01);
            }
            else if (Player1.Bounds.IntersectsWith(Banana_02.Bounds))
            {
                AddToInv(Banana_02);
            }
//Pears
            else if (Player1.Bounds.IntersectsWith(Pear_01.Bounds))
            {
                AddToInv(Pear_01);
            }
            else if (Player1.Bounds.IntersectsWith(Pear_02.Bounds))
            {
               AddToInv(Pear_02);
            }
        }

        public void EnemyCollisons()
        {
            if (Player1.Bounds.IntersectsWith(Enemy_01.Bounds))
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

                string LHMessage = "You Died, Game Over" + Environment.NewLine + " Would You Like to Restart The Level";
                string LHCaption = "Game Over";
                MessageBoxButtons LHButtons = MessageBoxButtons.RetryCancel;
                DialogResult LHResult;

                LHResult = MessageBox.Show(LHMessage, LHCaption, LHButtons);
                if (LHResult == System.Windows.Forms.DialogResult.Retry)
                {
                    Level = 1;
                    LevelLoad();
                }
                else if(LHResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    Application.Exit();
                }

            }
            else if (Life.Value > Life.Minimum)
            {
                Life.Value -= lose;
                LifeLabel.Text = "Health = " + Life.Value;
                Life2.Value -= lose;
                LifeLabel2.Text = "Health = " + Life2.Value;
                System.Console.Write("Life Value = " + Life.Value + "   " + "Life2 Value = " + Life2.Value + "   " + "Lose Value = " + lose + "   ");
                System.Console.WriteLine(Life.Value > Life.Minimum);
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
                System.Console.Write("Life Value = " + Life.Value + "   " + "Life2 Value = " + Life2.Value + "   " + "Gain Value = " + gain + "   ");
                System.Console.WriteLine(Life.Value + gain < Life.Maximum + 1);
            }

            else if (Life.Value + gain >= Life.Maximum + 1 )
            {
                System.Console.WriteLine("Health Cant Go Above 100 Idiot");
            }

            /*
            else if (gain == 5)
            {
                Life.PerformStep();
                Life2.PerformStep();
                LifeLabel.Text = "Health = " + Life.Value;
                LifeLabel2.Text = "Health = " + Life2.Value;
                System.Console.Write("Life Value = " + Life.Value + "   " + "Life2 Value = " + Life2.Value + "   " + "Gain Value = " + gain + "   ");
                System.Console.WriteLine(Life.Value + gain < Life.Maximum + 1);
            }

            else if (gain == 10)
            {
                Life.PerformStep();
                Life.PerformStep();
                Life2.PerformStep();
                Life2.PerformStep();
                LifeLabel.Text = "Health = " + Life.Value;
                LifeLabel2.Text = "Health = " + Life2.Value;
                System.Console.Write("Life Value = " + Life.Value + "   " + "Life2 Value = " + Life2.Value + "   " + "Gain Value = " + gain + "   ");
                System.Console.WriteLine(Life.Value + gain < Life.Maximum + 1);
            }

            else if (gain == 15)
            {
                Life.PerformStep();
                Life.PerformStep();
                Life.PerformStep();
                Life2.PerformStep();
                Life2.PerformStep();
                Life2.PerformStep();
                LifeLabel.Text = "Health = " + Life.Value;
                LifeLabel2.Text = "Health = " + Life2.Value;
                System.Console.Write("Life Value = " + Life.Value + "   " + "Life2 Value = " + Life2.Value + "   " + "Gain Value = " + gain + "   ");
                System.Console.WriteLine(Life.Value + gain < Life.Maximum + 1);
            }*/
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
                else if (Life.Value  + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_01);
                    Inv_01.Image = Inv_Blank.Image;
                    apple_01 = 0;
                }
            }

           else if (Inv_01.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_01);
                    Inv_01.Image = Inv_Blank.Image;
                    apple_02 = 0;
                }
            }

            // Bananas
            else if (Inv_01.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_01);
                    Inv_01.Image = Inv_Blank.Image;
                    banana_01 = 0;
                }
            }

            else if (Inv_01.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_01);
                    Inv_01.Image = Inv_Blank.Image;
                    banana_02 = 0;
                }
            }

            // Pears
            else if (Inv_01.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_01);
                    Inv_01.Image = Inv_Blank.Image;
                    pear_01 = 0;
                }
            }

            else if (Inv_01.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_01);
                    Inv_01.Image = Inv_Blank.Image;
                    pear_02 = 0;
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
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_02);
                    Inv_02.Image = Inv_Blank.Image;
                    apple_01 = 0;
                }
            }

            else if (Inv_02.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_02);
                    Inv_02.Image = Inv_Blank.Image;
                    apple_02 = 0;
                }
            }

            // Bananas
            else if (Inv_02.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_02);
                    Inv_02.Image = Inv_Blank.Image;
                    banana_01 = 0;
                }
            }

            else if (Inv_02.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_02);
                    Inv_02.Image = Inv_Blank.Image;
                    banana_02 = 0;
                }
            }

            // Pears
            else if (Inv_02.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_02);
                    Inv_02.Image = Inv_Blank.Image;
                    pear_01 = 0;
                }
            }

            else if (Inv_02.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_02);
                    Inv_02.Image = Inv_Blank.Image;
                    pear_02 = 0;
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
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_03);
                    Inv_03.Image = Inv_Blank.Image;
                    apple_01 = 0;
                }
            }

            else if (Inv_03.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_03);
                    Inv_03.Image = Inv_Blank.Image;
                    apple_02 = 0;
                }
            }

            // Bananas
            else if (Inv_03.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_03);
                    Inv_03.Image = Inv_Blank.Image;
                    banana_01 = 0;
                }
            }

            else if (Inv_03.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_03);
                    Inv_03.Image = Inv_Blank.Image;
                }
            }

            // Pears
            else if (Inv_03.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_03);
                    Inv_03.Image = Inv_Blank.Image;
                }
            }

            else if (Inv_03.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_03);
                    Inv_03.Image = Inv_Blank.Image;
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
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_04);
                    Inv_04.Image = Inv_Blank.Image;
                }
            }

            else if (Inv_04.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_04);
                    Inv_04.Image = Inv_Blank.Image;
                }
            }

            // Bananas
            else if (Inv_04.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_04);
                    Inv_04.Image = Inv_Blank.Image;
                }
            }

            else if (Inv_04.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_04);
                    Inv_04.Image = Inv_Blank.Image;
                }
            }

            // Pears
            else if (Inv_04.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_04);
                    Inv_04.Image = Inv_Blank.Image;
                }
            }

            else if (Inv_04.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_04);
                    Inv_04.Image = Inv_Blank.Image;
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
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_05);
                    Inv_05.Image = Inv_Blank.Image;
                }
            }

            else if (Inv_05.Tag == Apple_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Apple < HealthBarTotal)
                {
                    GainHealth(Apple);
                    TakeFromInv(Inv_05);
                    Inv_05.Image = Inv_Blank.Image;
                }
            }

            // Bananas
            else if (Inv_05.Tag == Banana_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_05);
                    Inv_05.Image = Inv_Blank.Image;
                }
            }

            else if (Inv_05.Tag == Banana_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Banana < HealthBarTotal)
                {
                    GainHealth(Banana);
                    TakeFromInv(Inv_05);
                    Inv_05.Image = Inv_Blank.Image;
                }
            }

            // Pears
            else if (Inv_05.Tag == Pear_01.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_05);
                    Inv_05.Image = Inv_Blank.Image;
                }
            }

            else if (Inv_05.Tag == Pear_02.Tag)
            {
                if (Life.Value == Life.Maximum)
                {
                    System.Console.WriteLine("Health Max");
                }
                else if (Life.Value + Pear < HealthBarTotal)
                {
                    GainHealth(Pear);
                    TakeFromInv(Inv_05);
                    Inv_05.Image = Inv_Blank.Image;
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
            Debug = 0;
            DebugMenuItem.Visible = false;
        }

        private void Life_Click(object sender, EventArgs e)
        {
            Debug = 1;
            DebugMenuItem.Visible = true;
        }

        private void LifeLabel2_Click(object sender, EventArgs e)
        {
            Debug = 0;
            DebugMenuItem.Visible = false;
        }

        private void Life2_Click(object sender, EventArgs e)
        {
            Debug = 1;
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
            if (Popup == 1)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.Text = "Game";
                notifyIcon1.BalloonTipTitle = "Game";
                notifyIcon1.BalloonTipText = "Game Form Active";
                notifyIcon1.ShowBalloonTip(10000);
            }
            else if (Popup == 0)
            {
                notifyIcon1.Visible = false;
                notifyIcon1.Text = "Game";
                notifyIcon1.BalloonTipTitle = "Game";
                notifyIcon1.BalloonTipText = "Game Form Active";
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

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
            Debug = 0;
            Walls = new int[10];
        }

        #endregion
        #region Level Area

        public void FormLoad()
        {
            player = 0;
            apple_01 = 0;
            apple_02 = 0;
            banana_01 = 0;
            banana_02 = 0;
            pear_01 = 0;
            pear_02 = 0;
            enemy_01 = 0;
            tree1 = 0;
            Level = 1;
            if (Wall == 10)
            {
                Walls = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            }
            LevelCheck();
        }

        public void LevelLoad()
        {
            #region Visible = true

            #region Player/Fruits/Enemys
            if (player == 1)
            {
                //Player.Visible = true;
                Player1.Visible = true;
            }

            if (apple_01 == 1)
            {
                Apple_01.Visible = true;
            }

            if (apple_02 == 1)
            {
                Apple_02.Visible = true;
            }

            if (banana_01 == 1)
            {
                Banana_01.Visible = true;
            }

            if (banana_02 == 1)
            {
                Banana_02.Visible = true;
            }

            if (pear_01 == 1)
            {
                Pear_01.Visible = true;
            }

            if (pear_02 == 1)
            {
                Pear_02.Visible = true;
            }

            if (enemy_01 == 1)
            {
                Enemy_01.Visible = true;
            }
            
            if (tree1 == 1)
            {

            }

            #endregion
            #region Walls
            if (Walls[0] == 1)
            {

            }

            if (Walls[1] == 1)
            {

            }

            if (Walls[2] == 1)
            {

            }

            if (Walls[3] == 1)
            {

            }

            if (Walls[4] == 1)
            {

            }

            if (Walls[5] == 1)
            {

            }

            if (Walls[6] == 1)
            {

            }

            if (Walls[7] == 1)
            {

            }

            if (Walls[8] == 1)
            {

            }

            if (Walls[9] == 1)
            {

            }

            #endregion

            #endregion
            #region Visible = False

            #region Player/Fruits/Enemys
            if (player == 0)
            {
                //Player.Visible = false;
                Player1.Visible = false;
            }

            if (apple_01 == 0)
            {
                Apple_01.Visible = false;
            }

            if (apple_02 == 0)
            {
                Apple_02.Visible = false;
            }

            if (banana_01 == 0)
            {
                Banana_01.Visible = false;
            }

            if (banana_02 == 0)
            {
                Banana_02.Visible = false;
            }

            if (pear_01 == 0)
            {
                Pear_01.Visible = false;
            }

            if (pear_02 == 0)
            {
                Pear_02.Visible = false;
            }

            if (enemy_01 == 0)
            {
                Enemy_01.Visible = false;
            }

            if (tree1 == 0)
            {

            }

            #endregion
            #region Walls
            if (Walls[0] == 0)
            {

            }

            if (Walls[1] == 0)
            {

            }

            if (Walls[2] == 0)
            {

            }

            if (Walls[3] == 0)
            {

            }

            if (Walls[4] == 0)
            {

            }

            if (Walls[5] == 0)
            {

            }

            if (Walls[6] == 0)
            {

            }

            if (Walls[7] == 0)
            {

            }

            if (Walls[8] == 0)
            {

            }

            if (Walls[9] == 0)
            {

            }

            #endregion
            #endregion
        }

        public void LevelCheck()
        {
            if (Level == 1)
            {
                Level1();
            }

            else if (Level == 2)
            {
                Level2();
            }

            else if (Level == 3)
            {
                Level3();
            }

            else if (Level == 4)
            {
                Level4();
            }

            else if (Level == 5)
            {
                Level5();
            }
        }

        #region Levels
        public void Level1()
        {
            //entitylist = player, apple_01, apple_02, banana_01, banana_02, pear_01, pear_02, enemy_01 
            player = 1;
            apple_01 = 1;
            apple_02 = 1;
            banana_01 = 1;
            banana_02 = 1;
            pear_01 = 1;
            pear_02 = 1;
            enemy_01 = 1;
            Walls = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            LevelLoad();
        }

        public void Level2()
        {
            player = 0;
            apple_01 = 0;
            apple_02 = 0;
            banana_01 = 0;
            banana_02 = 0;
            pear_01 = 0;
            pear_02 = 0;
            enemy_01 = 0;
        }

        public void Level3()
        {
            player = 0;
            apple_01 = 0;
            apple_02 = 0;
            banana_01 = 0;
            banana_02 = 0;
            pear_01 = 0;
            pear_02 = 0;
            enemy_01 = 0;
        }

        public void Level4()
        {
            player = 0;
            apple_01 = 0;
            apple_02 = 0;
            banana_01 = 0;
            banana_02 = 0;
            pear_01 = 0;
            pear_02 = 0;
            enemy_01 = 0;
        }

        public void Level5()
        {
            player = 0;
            apple_01 = 0;
            apple_02 = 0;
            banana_01 = 0;
            banana_02 = 0;
            pear_01 = 0;
            pear_02 = 0;
            enemy_01 = 0;
        }

        #endregion
        #endregion

    }
}
