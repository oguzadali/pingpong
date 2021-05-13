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
    }
}
