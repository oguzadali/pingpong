
namespace pingpong
{
    partial class gameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playGround = new System.Windows.Forms.Panel();
            this.gameOver = new System.Windows.Forms.Label();
            this.count_Lbl = new System.Windows.Forms.Label();
            this.scr_Lbl = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.racket = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playGround.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            this.SuspendLayout();
            // 
            // playGround
            // 
            this.playGround.Controls.Add(this.gameOver);
            this.playGround.Controls.Add(this.count_Lbl);
            this.playGround.Controls.Add(this.scr_Lbl);
            this.playGround.Controls.Add(this.ball);
            this.playGround.Controls.Add(this.racket);
            this.playGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playGround.Location = new System.Drawing.Point(0, 0);
            this.playGround.Name = "playGround";
            this.playGround.Size = new System.Drawing.Size(800, 450);
            this.playGround.TabIndex = 0;
            // 
            // gameOver
            // 
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gameOver.Location = new System.Drawing.Point(432, 109);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(137, 136);
            this.gameOver.TabIndex = 2;
            this.gameOver.Text = "Game Over\r\n\r\nRestart-F1\r\n\r\nExit-ESC";
            this.gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // count_Lbl
            // 
            this.count_Lbl.AutoSize = true;
            this.count_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.count_Lbl.Location = new System.Drawing.Point(95, 22);
            this.count_Lbl.Name = "count_Lbl";
            this.count_Lbl.Size = new System.Drawing.Size(19, 20);
            this.count_Lbl.TabIndex = 2;
            this.count_Lbl.Text = "0";
            // 
            // scr_Lbl
            // 
            this.scr_Lbl.AutoSize = true;
            this.scr_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.scr_Lbl.Location = new System.Drawing.Point(25, 22);
            this.scr_Lbl.Name = "scr_Lbl";
            this.scr_Lbl.Size = new System.Drawing.Size(64, 20);
            this.scr_Lbl.TabIndex = 2;
            this.scr_Lbl.Text = "Score:";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.DarkRed;
            this.ball.Location = new System.Drawing.Point(336, 285);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(20, 20);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(391, 382);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(210, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // gameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playGround);
            this.Name = "gameForm";
            this.Text = "Ping Pong Game";
            this.Load += new System.EventHandler(this.gameForm_Load);
            this.playGround.ResumeLayout(false);
            this.playGround.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel playGround;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Label count_Lbl;
        private System.Windows.Forms.Label scr_Lbl;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.Timer timer1;
    }
}

