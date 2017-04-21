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

                btn1click++;

                if(btn1click == 1){
                    if (btn1timer.Enabled == true)
                    { richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    btn1timer.Enabled = false;
                    }
                    btn1timer.Enabled = true;
                    word += "p";
                    wordbuilder();

                }
                else if(btn1click == 2)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    word = word.Remove(word.Length - 1, 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "q";
                    wordbuilder();
                }
                else if (btn1click == 3)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    word = word.Remove(word.Length - 1, 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "r";
                    wordbuilder();
                }
                else if (btn1click == 4)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    word = word.Remove(word.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "s";
                    wordbuilder();
                }
                else if (btn1click == 5)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    word = word.Remove(word.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "1";
                    wordbuilder();
                }
                else if (btn1click == 6)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    word = word.Remove(word.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "P";
                    wordbuilder();
                }
                else if (btn1click == 7)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    word = word.Remove(word.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "Q";
                    wordbuilder();
                }
                else if (btn1click == 8)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    word = word.Remove(word.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "R";
                    wordbuilder();
                }
                else if (btn1click == 9)
                {
                    btn1timer.Enabled = false;
                    btn1timer.Enabled = true;
                    btn1click = 0;
                    word = word.Remove(word.Length - 1);
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    word += "S";
                    wordbuilder();
                    word = "";
                    
                }
        }

        private void entbtn_Click(object sender, EventArgs e)
        {

        }

        private void triplebtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += richTextBox1.Text;
            richTextBox1.Text = "";

            btn1timer.Enabled = false;
            btn1click = 0;
            word = "";

        }

        public void wordbuilder()
        {
            richTextBox1.Text += word;

        }

        private void btn1timer_Tick(object sender, EventArgs e)
        {
            word = "";
            btn1timer.Enabled = false;
            btn1click = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn2click++;

            if (btn2click == 1)
            {
                if (btn2timer.Enabled == true)
                {
                    richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                    btn2timer.Enabled = false;
                }
                btn2timer.Enabled = true;
                word += "p";
                wordbuilder();

            }
            else if (btn2click == 2)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                word = word.Remove(word.Length - 1, 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "q";
                wordbuilder();
            }
            else if (btn2click == 3)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                word = word.Remove(word.Length - 1, 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "r";
                wordbuilder();
            }
            else if (btn2click == 4)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "s";
                wordbuilder();
            }
            else if (btn2click == 5)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "1";
                wordbuilder();
            }
            else if (btn2click == 6)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "P";
                wordbuilder();
            }
            else if (btn2click == 7)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "Q";
                wordbuilder();
            }
            else if (btn2click == 8)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                word = word.Remove(word.Length - 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "R";
                wordbuilder();
            }
            else if (btn2click == 9)
            {
                btn2timer.Enabled = false;
                btn2timer.Enabled = true;
                btn2click = 0;
                word = word.Remove(word.Length - 1);
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                word += "S";
                wordbuilder();
                word = "";


            }
        }

        private void btn2timer_Tick(object sender, EventArgs e)
        {
            word = "";
            btn2timer.Enabled = false;
            btn2click = 0;
        }

           

    }
}
