using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbstractClassSmajli2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CenterToParent();
        }
        Graphics g;
        Random r = new Random();
        int k, l, x, y;
        Smajli[] s = new Smajli[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            Width = 1000;
            Height = 800;
            k = ClientRectangle.Width;
            l = ClientRectangle.Height;
            for (int i = 0; i < 10; i++)
                {
                    x = r.Next(100, k - 100);
                    y = r.Next(100, l - 100);
                    int tip = r.Next(3);
                    if (tip == 0)
                    s[i] = new Smajli1(x, y);
                    else if (tip == 1)
                    s[i] = new Smajli2(x, y);
                    else s[i] = new Smajli3(x, y);
                }
       }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            for (int i = 0; i < 10; i++) s[i].Crtaj(g);
        }
    }
}
