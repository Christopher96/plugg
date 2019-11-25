using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab5
{
    public partial class Lab5 : Form
    {
        BackgroundWorker worker;
        Ball currentBall;

        public Lab5()
        {
            InitializeComponent();
            currentBall = new Ball(Image.FromFile("../../assets/football.png"));
            currentBall.Location = new Point(20, panel.Height - currentBall.Height - 20);

            panel.Controls.Add(currentBall);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private bool isShooting = false;

        private void FireButton_Click(object sender, EventArgs e)
        {
            if (!isShooting)
            {
                isShooting = true;
                FireButton.Text = "Fire!";
            }

            while (isShooting)
            {
                progressLoop();
            }
        }

        private bool progressIncrease = true;

        private void progressLoop()
        {
            if (ShootProgress.Value >= 100)
            {
                ShootProgress.Value = 100;
                progressIncrease = false;
            }
            else if (ShootProgress.Value <= 0)
            {
                ShootProgress.Value = 0;
                progressIncrease = true;
            }

            if (progressIncrease)
            {
                ShootProgress.Value += 1;
            }
            else
            {
                ShootProgress.Value -= 1;
            }
            Thread.Sleep(100);
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
