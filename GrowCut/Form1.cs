using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace GrowCut
{
    public partial class Form1 : Form
    {
        private Pen myPen; 
        private Bitmap drawBitmap;
        private Bitmap image;
        
        private bool draw = false;
        private Graphics gr;
        private Point point;

        private Color[,] allColors;
        public Form1()
        {
            InitializeComponent();
            myPen = new Pen(Color.Blue);
            myPen.Width = 3f;
            drawBitmap = new Bitmap(drawBox.Width, drawBox.Height);
            image = new Bitmap(imageBox.Width, imageBox.Height);
            drawBox.Image = drawBitmap;
            gr = Graphics.FromImage(drawBitmap);
            allColors = new Color[imageBox.Width - 1, imageBox.Height - 1];
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(ofd.FileName);
                    imageBox.Image = image;
                }
                catch 
                {
                    MessageBox.Show("Can't open this file", "Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void drawBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                gr.DrawLine(myPen, point.X, point.Y, e.X, e.Y);
                point = e.Location;
                drawBox.Invalidate();
            }
        }

        private void drawBox_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            gr.Clear(Color.White);
            drawBox.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Transparent background...  
            drawBox.BackColor = Color.Transparent;
            // Change parent for overlay PictureBox...
            drawBox.Parent = imageBox;
            drawBox.Location = new Point(0, 0);
        }

        private void drawBox_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
            draw = true;
        }

        private void growCutButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (imageBox.Width - 1); i++)
            {
                for (int j = 0; j < (imageBox.Height - 1); j++)
                {
                    allColors[i, j] = image.GetPixel(i, j); //Получаем все цвета в массив.
                }
            }
        }
    }
}