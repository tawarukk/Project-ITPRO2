using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_86_Casino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Width = this.Size.Width + 10;
            this.Height = this.Size.Height + 10;

            lbFormSize.Text = "Width : " + this.Size.Width + " Height : " + this.Size.Height;
        }

        private void label1_load(object sender, EventArgs e)
        {
            lbFormSize.Text = "";
            lbFormSize.Text = "Width : " +  this.Size.Width + " Height : " + this.Size.Height;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Width = 700;
            this.Height = 600;

            lbFormSize.Text = "Width : " + this.Size.Width + " Height : " + this.Size.Height;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private bool isRolling = false;
        private Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {

            if (isRolling)
            {
                isRolling = false; 
                return;
            }

            isRolling = true;
            int sumrandom = 0;

            button2.Text = "หยุด!";

            for (int i = 0; i < 100; i++)
            {
                if (!isRolling)
                {
                    button2.Text = "ทอย !";
                    break;
                }

                int randomDice1 = random.Next(1, 7);
                int randomDice2 = random.Next(1, 7);
                sumrandom = randomDice1 + randomDice2;
                string randomImage1 = "d" + randomDice1;
                string randomImage2 = "d" + randomDice2;
                this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(randomImage1);
                this.pictureBox3.Image = (Image)Properties.Resources.ResourceManager.GetObject(randomImage2);

                SumDice.Text = "ทอยได้ : " + sumrandom;
                Dice1.Text = ": " + randomDice1;
                Dice2.Text = ": " + randomDice2;

                System.Threading.Thread.Sleep(50);
                Application.DoEvents();
            }

            isRolling = false;

            if (sumrandom >= 7)
            {
                MessageBox.Show("สูง !");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\tawar\Downloads\e.wav");
                player.Play();
            }
            else
            {
                MessageBox.Show("ต่ำ !");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
