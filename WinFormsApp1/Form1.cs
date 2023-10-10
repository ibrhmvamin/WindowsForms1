using System;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();
            int newX = random.Next(0, this.Width - label1.Width);
            int newY = random.Next(0, this.Height - label1.Height);
            label1.Location = new Point(newX, newY);
        }
    }
}