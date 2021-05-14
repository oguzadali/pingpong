using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pingpong
{
    public partial class gameForm : Form
    {

        public int speed_left = 4;
        public int speed_top = 4;
        public int points = 0;



        public gameForm()
        {
            InitializeComponent();

            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;

            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            racket.Top = playGround.Bottom -(playGround.Bottom/10);

            gameOver.Left = (playGround.Width / 2) - (gameOver.Width / 2);
            gameOver.Top = (playGround.Height / 2) - (gameOver.Height / 2);
            gameOver.Visible = false;


           
        }

        private void gameForm_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            ball.Left += speed_left;
            ball.Top += speed_top;

            //Prevents the ball from bouncing out of the frame  sends it in the reverse direction 
            if (ball.Left <= playGround.Left)
            {
                speed_left = -speed_left;
            }
            if (ball.Right >= playGround.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playGround.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playGround.Bottom)
            {
                gameOver.Visible = true;
                timer1.Enabled = false;
            }

            //game rules
            if (ball.Bottom >= racket.Top && ball.Bottom <= racket.Bottom && ball.Left >= racket.Left && ball.Right <= racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                count_Lbl.Text = points.ToString();

                //set random background after every hit
                Random r = new Random();
                playGround.BackColor = Color.FromArgb(r.Next(150, 255), r.Next(150, 255), r.Next(150, 255));
            }


        }

        //game over - game restart - esc - key setups
        private void gameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode==Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                count_Lbl.Text = "0";
                timer1.Enabled = true;
                gameOver.Visible = false;
                playGround.BackColor = Color.White;
            }
        }
    }
}
