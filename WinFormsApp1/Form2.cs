using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public System.Windows.Forms.Timer timer1 = new();
        public System.Windows.Forms.Timer timer2 = new();

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {          
            BackgroundImage = Resources.Baku;
            BackgroundImageLayout = ImageLayout.Zoom;
            timer1.Start();
            button1.Text = DateTime.Now.ToLongTimeString();

        }

        public void Timer1_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.ToLongTimeString();
        }

        public void Timer2_Tick(object sender, EventArgs e)
        {
            Text = DateTime.Now.AddHours(-3).ToLongTimeString();
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundImage = Resources.london;
            BackgroundImageLayout = ImageLayout.Zoom;
            button2.Text = DateTime.Now.AddHours(-3).ToLongTimeString();
        }
    }
}
