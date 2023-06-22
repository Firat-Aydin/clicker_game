using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clicker_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int altın = 0;
        int hit = 10;

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "500 COIN";
            
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "1000 COIN";
            
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "2000 COIN";
           
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "4000 COIN";
           
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "8000 COIN";
            
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "16000 COIN";
            
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "32000 COIN";
            
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "64000 COIN";
            
        }

        private void pictureBox10_MouseHover(object sender, EventArgs e)
        {
            label1.Text = "128000 COIN";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            altın++;
            label3.Text = altın.ToString();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            altın += hit;
            label3.Text = altın.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (altın >= 500)
            {
                pictureBox2.Enabled = false;
                hit = 20;
                altın = altın - 500;
                label3.Text = altın.ToString();
                pictureBox2.BackColor = Color.Green;
                
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (altın >= 1000)
            {
                pictureBox3.Enabled = false;
                hit = 50;
                altın = altın - 1000;
                label3.Text = altın.ToString();
                pictureBox3.BackColor = Color.Green;
                
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (altın >= 2000)
            {
                pictureBox4.Enabled = false;
                hit = 100;
                altın = altın - 2000;
                label3.Text = altın.ToString();
                pictureBox4.BackColor = Color.Green;
                
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (altın >= 4000)
            {
                pictureBox5.Enabled = false;
                hit = 200;
                altın = altın - 4000;
                label3.Text = altın.ToString();
                pictureBox5.BackColor = Color.Green;
                
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (altın >= 8000)
            {
                pictureBox6.Enabled = false;
                hit = 400;
                altın = altın - 8000;
                label3.Text = altın.ToString();
                pictureBox6.BackColor = Color.Green;
                
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (altın >= 16000)
            {
                pictureBox7.Enabled = false;
                hit = 800;
                altın = altın - 16000;
                label3.Text = altın.ToString();
                pictureBox7.BackColor = Color.Green;
                
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (altın >= 32000)
            {
                pictureBox8.Enabled = false;
                hit = 1600;
                altın = altın - 32000;
                label3.Text = altın.ToString();
                pictureBox8.BackColor = Color.Green;
                
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (altın >= 54000)
            {
                pictureBox9.Enabled = false;
                hit = 3200;
                altın = altın - 54000;
                label3.Text = altın.ToString();
                pictureBox9.BackColor = Color.Green;
                
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (altın >= 128000)
            {
                pictureBox10.Enabled = false;
                hit = 6400;
                altın = altın - 128000;
                label3.Text = altın.ToString();
                pictureBox10.BackColor = Color.Green;
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("! the game is closing !");
            this.Close();
        }
    }
}
