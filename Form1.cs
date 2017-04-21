using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26923626___assignment2
{
    public partial class Form1 : Form
    {
        string word = "";
        int btn1click = 0;
        int btn2click = 0;
        int btn3click = 0;
        int btn4click = 0;
        int btn5click = 0;
        int btn7click = 0;
        int btn8click = 0;
        int btn9click = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void modebtn_Click(object sender, EventArgs e)
        {
            settingtxt.Text = "Prediction";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn1click == 5)
            {
                btn1click = 1;
            }
            else
            {
                btn1click++;
            }

                if(btn1click == 1){
                    word += "p";
                }
                else if(btn1click == 2)
                {
                    word = word.Remove(word.Length - 1);
                    word += "q";
                }
                else if (btn1click == 3)
                {
                    word = word.Remove(word.Length - 1);
                    word += "r";
                }
                else if (btn1click == 4)
                {
                    word = word.Remove(word.Length - 1);
                    word += "s";
                }
                else if (btn1click == 5)
                {
                    word = word.Remove(word.Length - 1);
                    word += "1";
                }
                else if (btn1click == 6)
                {
                    word = word.Remove(word.Length - 1);
                    word += "Q";
                }
                else if (btn1click == 7)
                {
                    word = word.Remove(word.Length - 1);
                    word += "R";
                }
                else if (btn1click == 8)
                {
                    word = word.Remove(word.Length - 1);
                    word += "S";
                }
        }

        private void entbtn_Click(object sender, EventArgs e)
        {

        }

        private void triplebtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += richTextBox1.Text;
        }
    }
}
