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

                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);

                try
                {
                    CurrentListbox.SelectedIndex += 1;
                    richTextBox1.Text += CurrentListbox.SelectedItem; 
                }
                catch
                {
                    CurrentListbox.SelectedIndex = 1;
                    richTextBox1.Text += CurrentListbox.SelectedItem;

                }
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
                richTextBox1.Text += CurrentListbox.SelectedItem;

                timer1.Enabled = false;
                timer1.Enabled = true;  // resets the timer
            }else{
                buttonpressed = ((Button)sender).Name;
                // https://msdn.microsoft.com/en-us/library/tabh47cf(v=vs.110).aspx information on spliting was found here
                
                string clickednumber = buttonpressed.Split('n')[1];
                CurrentListbox = (ListBox)this.Controls["listbutton" + clickednumber];
                CurrentListbox.SelectedIndex = 1;
                richTextBox1.Text += CurrentListbox.SelectedItem;

                timer1.Enabled = true;
            }
            
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
            richTextBox2.Text = richTextBox2.Text + Environment.NewLine; 
        }

        private void triplebtn_Click(object sender, EventArgs e)
        {
            richTextBox2.Text += richTextBox1.Text;
            richTextBox2.Text += " ";
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
            timer1.Enabled = false;
        }

        private void prevbtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.Text.Length - 1);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string savetext = richTextBox2.Text;
            
            System.IO.File.WriteAllText(@"C:\Users\Public\TestFolder\WriteText.txt", savetext);
            MessageBox.Show("File have been saved to C:.Users.Public.TestFolder.WriteText.txt");
        }

           

    }
}
