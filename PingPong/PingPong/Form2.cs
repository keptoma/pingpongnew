using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form2 : Form
    {
        int xSpeed = 10;
        int ySpeed = 10;
        int player1 = 0;
        int player2 = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.W)
            {
                paddle1.Top -= 5;
            }
            if(e.KeyCode==Keys.S)
            {
                paddle1.Top += 5;
            }

            if(e.KeyCode==Keys.A)
            {
                paddle2.Top -= 5;

            }
            if (e.KeyCode == Keys.M)
            {
                paddle2.Top += 5;

            }



        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball.Top += ySpeed;
            Ball.Left += xSpeed;

            if(Ball.Location.Y>=420)
            {
                 ySpeed = - ySpeed;
            }

            if(Ball.Location.X>=760)
            {
                xSpeed = -xSpeed;
                player1++;
                label1.Text = player1.ToString();
            }

            if(Ball.Location.X<=0)
            {
                xSpeed = -xSpeed;
                player2++;
                label2.Text = player2.ToString();
            }
           if(Ball.Location.Y<=0)
           {
                ySpeed = -ySpeed;
           }

            if (Ball.Bounds.IntersectsWith(paddle2.Bounds))
            {
                xSpeed = -xSpeed;
            }

            if (Ball.Bounds.IntersectsWith(paddle1.Bounds))
            {
                xSpeed = -xSpeed;
            }
             

        }
    }
}
