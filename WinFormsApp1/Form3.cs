using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
   
    public partial class Form3 : Form
    {
        Point st, end;
        public Form3()
        {
            InitializeComponent();
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label? label = sender as Label;
            this.Text = $"{label!.Location}";
        }

        private void Mouse_Down(object? sender, MouseEventArgs e)
        {
            st = new(e.X, e.Y);
        }

        private void Mouse_Up(object? sender, MouseEventArgs e)
        {
            end = new(e.X, e.Y);
            int width = (st.X - end.X);
            int height = (st.Y - end.Y);
            if (width < 10 || height < 10)
            {
                MessageBox.Show("Size of rectangle can't be lower than 10x10!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Label label = new();
                label.Size = new Size(width, height);
                label.BackColor = Color.Orange;
                label.ForeColor = Color.Orange;
                label.BorderStyle = BorderStyle.FixedSingle;
                int x = st.X - end.X;
                int y = st.Y - end.Y;
                if (x > 0 && y < 0) label.Location = new Point(end.X, st.Y);
                else if (x < 0 && y > 0) label.Location = new Point(st.X, end.Y);
                else if (x > 0 && y > 0) label.Location = end;
                else if (x < 0 && y < 0) label.Location = st;
                label.MouseClick += label_Click;
                Controls.Add(label);

                label.BringToFront();
            }
        }
    }
}
