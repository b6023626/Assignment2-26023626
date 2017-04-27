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
        string buttonpressed = "";

        ListBox CurrentListbox;
        

        public Form1()
        {
            InitializeComponent();

        }

        private void anybtn_Click(object sender, EventArgs e)
        {
            if (buttonpressed == ((Button)sender).Name && timer1.Enabled == true)
            {

                timer1.Enabled = false;
            }else{


            }
            buttonpressed = ((Button)sender).Name;
        }


        private void modebtn_Click(object sender, EventArgs e)
        {

            if (settingtxt.Text == "Multi-Press")
            {
                settingtxt.Text = "Prediction";
            }
            else
            {
                settingtxt.Text = "Multi-Press";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void entbtn_Click(object sender, EventArgs e)
        {

        }

        private void triplebtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += richTextBox1.Text;
            richTextBox1.Text = "";
            timer1.Enabled = false;
            word = "";
        }

        public void wordbuilder()
        {
            richTextBox1.Text += word;

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }
        }

           

    }
}
