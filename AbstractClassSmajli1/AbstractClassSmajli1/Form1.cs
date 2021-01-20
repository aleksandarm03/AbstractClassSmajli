using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CenterToParent();
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1200;
            Height = 800;
            numericUpDown1.Maximum = 2;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            Graphics g = CreateGraphics();
            if (numericUpDown1.Value == 0)
            {
                Smajli1 s = new Smajli1(x, y);
                s.Crtaj(g);
            }
            if (numericUpDown1.Value == 1)
            {
                Smajli2 s = new Smajli2(x, y);
                s.Crtaj(g);
            }
            if (numericUpDown1.Value == 2)
            {
                Smajli3 s = new Smajli3(x, y);
                s.Crtaj(g);
            }
        }
    }
}
