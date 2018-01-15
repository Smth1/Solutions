using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WpfContols;

namespace NonCustom
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Draw();
        }        
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);
            Pen pen = new Pen(Color.Black);
            g.DrawEllipse(pen, 10, 50, 150, 250);
            g.DrawLine(pen, 10, 50, 150, 250);
            g.DrawBezier(pen, 10, 50, 150, 250,100,100,100,100);
            pictureBox1.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_DragDrop(object sender, DragEventArgs e)
        {
            
        }
    }
}
