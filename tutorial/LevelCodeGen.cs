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
        int NumericBox = 0;
        int NumericBox2 = 0;
        int Number = 0;
        int Number2 = 0;

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
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + RandomUtil.GetRandomString() + Environment.NewLine;
        }

        private void Generate2Button_Click(object sender, EventArgs e)
        {
            while (i < Number)
            {
                 richTextBox1.Text += RandomUtil.GetRandomString() + Environment.NewLine;
                i++;
                System.Console.WriteLine("i = " + i);
            }
        }

        public void CodeLength_ValueChanged(object sender, EventArgs e)
        {
           int NumberLocal = Decimal.ToInt32(CodeLength.Value);
           NumericBox = NumberLocal;
           System.Console.WriteLine(CodeLength.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Number = NumericBox;
            Number2 = NumericBox2;
            System.Console.WriteLine("NumericBox = " + NumericBox + "   " + "NumericBox 2 = " + NumericBox2 + "   " + "Number = " + Number + "   " + "Number 2 = " + Number2 + "   " + "i = " + i);
        }

        private void LevelCodeGen_Load(object sender, EventArgs e)
        {
            timer1.Start();
            i = 0;
        }

        public void ButtonIDSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save Code Text File File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "Codes.txt")
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(richTextBox1.Text);
                }
            }
        }

        private void CodeLength_x_ValueChanged(object sender, EventArgs e)
        {
            int NumberLocal2 = Decimal.ToInt32(CodeLength.Value);
            NumericBox2 = NumberLocal2;
            System.Console.WriteLine(CodeLength.Value);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Added Yet", "Error");
        }
    }
}
