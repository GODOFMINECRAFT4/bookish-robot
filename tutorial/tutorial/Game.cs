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
        public Game()
        {
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            Reset();
        }

// Keyboard Controls
        private void Game_KeyDown(object sender, KeyEventArgs key)
        {
            #region Movement
// Up And Down Movement
            if (key.KeyCode == Keys.W)
            {
                Player.Top -= 5;
            }

            if (key.KeyCode == Keys.S)
            {
                Player.Top += 5;
            }

// Left And Right Movement
            if (key.KeyCode == Keys.A)
            {
                Player.Left -= 5;
            }

            if (key.KeyCode == Keys.D)
            {
                Player.Left += 5;
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

        public void Collisions()
        {
//Apples
            if (Player.Bounds.IntersectsWith(Apple_01.Bounds))
            {
                //Apple_01.Top = 20000;              
                AddToInv(Apple_01);
            }
           else if (Player.Bounds.IntersectsWith(Apple_02.Bounds))
            {
                //Apple_02.Top = 20000;
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
                LoseHealth(10);
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
            }
            //Life.Value += 10;
        }

        #endregion

        public void AddToInv(PictureBox item)
        {
            if (Inv_01.Tag == null)
            {
                Inv_01.Image = item.Image;
                Inv_01.Tag = item;
                item.Top = 2000;        
            }

            else if (Inv_02.Tag == null)
            {
                Inv_02.Image = item.Image;
                Inv_02.Tag = item;
                item.Top = 2000;
            }

            else if (Inv_03.Tag == null)
            {
                Inv_03.Image = item.Image;
                Inv_03.Tag = item;
                item.Top = 2000;
            }

            else if (Inv_04.Tag == null)
            {
                Inv_04.Image = item.Image;
                Inv_04.Tag = item;
                item.Top = 2000;
            }
            
            else if (Inv_05.Tag == null)
            {
                Inv_05.Image = item.Image;
                Inv_05.Tag = item;
                item.Top = 2000;
            }
        }

        public void TakeFromInv(PictureBox item)
        {
            item.Image = null;
        }

        public void Reset()
        {
            Text = "Game";
            Life.Value = 100;
            Inv_01.Tag = null;
            Inv_02.Tag = null;
            Inv_03.Tag = null;
            Inv_04.Tag = null;
            Inv_05.Tag = null;
        }
        #region Inv_Click
        // Inv_01
        private void Inv_01_Click(object sender, EventArgs e)
        {
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
        #region Debug
        private void MenuItemDebugInfo_Click(object sender, EventArgs e)
        {
            #region Inv_Check
            if (Inv_01.Tag != null)
            {
                System.Console.WriteLine("Inv_01 is Full");
            }
            else if (Inv_01.Tag == null)
            {
                System.Console.WriteLine("Inv_01 is Empty");
            }

            if (Inv_02.Tag != null)
            {
                System.Console.WriteLine("Inv_02 is Full");
            }
            else if (Inv_02.Tag == null)
            {
                System.Console.WriteLine("Inv_02 is Empty");
            }

            if (Inv_03.Tag != null)
            {
                System.Console.WriteLine("Inv_03 is Full");
            }
            else if (Inv_03.Tag == null)
            {
                System.Console.WriteLine("Inv_03 is Empty");
            }

            if (Inv_04.Tag != null)
            {
                System.Console.WriteLine("Inv_04 is Full");
            }
            else if (Inv_04.Tag == null)
            {
                System.Console.WriteLine("Inv_04 is Empty");
            }

            if (Inv_05.Tag != null)
            {
                System.Console.WriteLine("Inv_05 is Full");
            }
            else if (Inv_05.Tag == null)
            {
                System.Console.WriteLine("Inv_05 is Empty");
            }
            #endregion
        }

        private void MenuItemDebugInfo_2_Click(object sender, EventArgs e)
        {
            #region Inv_Check
            if (Inv_01.Tag != null)
            {
                Text = "Inv_01 is Full \n";
            }
            else if (Inv_01.Tag == null)
            {
                Text = "Inv_01 is Empty \n";
            }

            if (Inv_02.Tag != null)
            {
                Text = Text + "Inv_02 is Full \n";
            }
            else if (Inv_02.Tag == null)
            {
                Text = Text + "Inv_02 is Empty \n";
            }

            if (Inv_03.Tag != null)
            {
                Text = Text + "Inv_03 is Full \n";
            }
            else if (Inv_03.Tag == null)
            {
                Text = Text + "Inv_03 is Empty \n";
            }

            if (Inv_04.Tag != null)
            {
                Text = Text + "Inv_04 is Full \n";
            }
            else if (Inv_04.Tag == null)
            {
                Text = Text + "Inv_04 is Empty \n";
            }

            if (Inv_05.Tag != null)
            {
                Text = Text + "Inv_05 is Full \n";
            }
            else if (Inv_05.Tag == null)
            {
                Text = Text + "Inv_05 is Empty \n";
            }
            #endregion
            
            MessageBox.Show(Text);
            Text = "Game";
        }
        #endregion

    }
}
