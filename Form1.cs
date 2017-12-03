using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PuzzleShuffle
{
    
    public partial class Form1 : Form
    {
        //int count;
        public Form1()
        {
            InitializeComponent();
        }

        public void ShuffleButton(Button btn1, Button btn2)
        {
            if (btn2.Text == "")
            {
                btn2.Text = btn1.Text;
                btn1.Text = "";
            }
        }

        public void generateNumbers()
        {
            int I, J, rd;
            int[] integer = new int[16];
            Boolean flag = false;
            I = 1;

            do
            {
                Random random = new Random();
                rd = Convert.ToInt32(random.Next(16));
                for (J = 1; J <= I; J++)
                {
                    if (integer[J] == rd)
                    {
                        flag = true;
                        break;
                    }

                }
                if (flag == true)
                {
                    flag = false;
                }
                else
                {
                    integer[I] = rd;
                    I += 1;
                }
            }
            while (I <= 15);
            button1.Text = Convert.ToString(integer[1]);
            button2.Text = Convert.ToString(integer[2]);
            button3.Text = Convert.ToString(integer[3]);
            button4.Text = Convert.ToString(integer[4]);
            button5.Text = Convert.ToString(integer[5]);
            button6.Text = Convert.ToString(integer[6]);
            button7.Text = Convert.ToString(integer[7]);
            button8.Text = Convert.ToString(integer[8]);
            button9.Text = Convert.ToString(integer[9]);
            button10.Text = Convert.ToString(integer[10]);
            button11.Text = Convert.ToString(integer[11]);
            button12.Text = Convert.ToString(integer[12]);
            button13.Text = Convert.ToString(integer[13]);
            button14.Text = Convert.ToString(integer[14]);
            button15.Text = Convert.ToString(integer[15]);
            button16.Text = "";
                
        

        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ShuffleButton(button1, button2);
            ShuffleButton(button1, button5);
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShuffleButton(button2, button1);
            ShuffleButton(button2, button3);
            ShuffleButton(button2, button6);
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShuffleButton(button3, button2);
            ShuffleButton(button3, button4);
            ShuffleButton(button3, button7);
           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShuffleButton(button4, button3);
            ShuffleButton(button4, button8);
           
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShuffleButton(button5, button1);
            ShuffleButton(button5, button6);
            ShuffleButton(button5, button9);
         
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShuffleButton(button6, button5);
            ShuffleButton(button6, button2);
            ShuffleButton(button6, button7);
            ShuffleButton(button6, button10);
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShuffleButton(button7, button6);
            ShuffleButton(button7, button3);
            ShuffleButton(button7, button8);
            ShuffleButton(button7, button11);
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShuffleButton(button8, button4);
            ShuffleButton(button8, button7);
            ShuffleButton(button8, button12);
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ShuffleButton(button9, button5);
            ShuffleButton(button9, button10);
            ShuffleButton(button9, button13);
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShuffleButton(button10, button6);
            ShuffleButton(button10, button9);
            ShuffleButton(button10, button11);
            ShuffleButton(button10, button14);
         
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ShuffleButton(button11, button7);
            ShuffleButton(button11, button10);
            ShuffleButton(button11, button12);
            ShuffleButton(button11, button15);
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ShuffleButton(button12, button8);
            ShuffleButton(button12, button11);
            ShuffleButton(button12, button16);
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ShuffleButton(button13, button9);
            ShuffleButton(button13, button9);
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ShuffleButton(button14, button10);
            ShuffleButton(button14, button13);
            ShuffleButton(button14, button15);
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            ShuffleButton(button15, button11);
            ShuffleButton(button15, button14);
            ShuffleButton(button15, button16);
           
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ShuffleButton(button16, button12);
            ShuffleButton(button16, button15);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            generateNumbers();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            generateNumbers();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
