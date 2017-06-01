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
            while (i < NumericBox)
            {
                richTextBox1.Text = richTextBox1.Text + RandomUtil.GetRandomString() + Environment.NewLine;
            }
        }

        private void CodeLength_ValueChanged(object sender, EventArgs e)
        {
           int Number = Decimal.ToInt32(CodeLength.Value);
           NumericBox = Number;
        }

    }
}
