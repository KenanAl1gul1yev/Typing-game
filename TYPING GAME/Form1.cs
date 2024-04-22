using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TYPING_GAME
{
    public partial class Form1 : Form
    {
        string[] words = new string[] { "sky", "banana", "important", "various", "tiny", "middle", "little" };

        int correct = 0;
        int incorrect = 0;

        Random random = new Random();

        public Form1()
        {
            InitializeComponent();

            lblword.Text=words[random.Next(0,words.Length)];
        }

        private void checkGame(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == lblword.Text)
                {
                    correct += 1;
                    lblword.Text = words[random.Next(0, words.Length)];
                    textBox1.Clear();
                    
                }
                else
                {
                    incorrect += 1;
                    lblword.Text = words[random.Next(0, words.Length)];
                    textBox1.Clear();
                }

                lblcorrect.Text = "Correct: " + correct;
                lblincorrect.Text="Incorrect: "+ incorrect;
            }

        }
    }
}
