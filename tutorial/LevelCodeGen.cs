using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tutorial
{
    public partial class LevelCodeGen : Form
    {
        int i = 0;
        int Running = 0;
        int NumericBox = 0;
        int NumericBox2 = 0;
        int Number = 0;
        int Number2 = 0;
        int NumberTotal = 0;
        //int NumberTotalValue = 0;
        

        public LevelCodeGen()
        {
            InitializeComponent();
        }
        public class RandomUtil
        {
            /// <summary>
            /// Get random string of 11 characters.
            /// </summary>
            /// <returns>Random string.</returns>
            public static string GetRandomString()
            {
                string path = Path.GetRandomFileName();
                path = path.Replace(".", ""); // Remove period.
                return path;
            }
        }

        private void LevelCodeGen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            ValueTimer.Start();
            i = 0;
        }

        #region NumericUpDownBoxs
        public void CodeLength_ValueChanged(object sender, EventArgs e)
        {
           int NumberLocal = Decimal.ToInt32(CodeLength.Value);
           NumericBox = NumberLocal;
           System.Console.WriteLine(CodeLength.Value);
        }

        public void CodeLength_x_ValueChanged(object sender, EventArgs e)
        {
            int NumberLocal2 = Decimal.ToInt32(CodeLength_x.Value);
            NumericBox2 = NumberLocal2;
            System.Console.WriteLine(CodeLength_x.Value);
        }
        #endregion
        #region Buttons
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + RandomUtil.GetRandomString() + Environment.NewLine;
        }

        private void Generate2Button_Click(object sender, EventArgs e)
        {
            while (i < NumberTotal)
            {
                Running = 1;
                richTextBox1.Text += RandomUtil.GetRandomString() + Environment.NewLine;
                i++;
                System.Console.WriteLine("i = " + i);
            }

            if (i == NumberTotal)
            {
                i = 0;
                Running = 0;
            }
        }

        public void ButtonIDSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Generated Codes To A File";
            saveFileDialog1.FileName = "Generated Codes.rft";
            saveFileDialog1.DefaultExt = ".rtf";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "Codes")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Added Yet", "Error");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Number = 0;
            Number2 = 0;
            NumberTotal = 0;
            NumericBox = 0;
            NumericBox2 = 0;
            CodeLength.Value = 0;
            CodeLength_x.Value = 0;
        }
        #endregion
        #region Timers

        private void timer1_Tick(object sender, EventArgs e)
        {
            System.Console.WriteLine("NumericBox = " + NumericBox + "   " + "NumericBox 2 = " + NumericBox2 + "   " + "Number = " + Number + "   " + "Number 2 = " + Number2 + "   " + "Number Total = " + NumberTotal + "   " + "i = " + i);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Number = NumericBox;
            Number2 = NumericBox2;
        }

        private void ValueTimer_Tick(object sender, EventArgs e)
        {
            if (Number2 == 0)
            {
                NumberTotal = Number + Number2;
            }

            else if (Number2 >= 0)
            {
                NumberTotal = Number * Number2;
            }
            TotalAmount.Text = NumberTotal.ToString();

        }
        #endregion
        #region Options
        private void Option1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Option10_CheckedChanged(object sender, EventArgs e)
        {
            if (Option1.CheckState == CheckState.Checked)
            {
                if (Running == 1)
                {
                    //NumberTotal = NumberTotal + 1;
                }
            }
        }
#endregion
    }
}
