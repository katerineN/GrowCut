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
        private SolidBrush brush;
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
            brush = new SolidBrush(Color.Blue);
            myPen.Width = 5;
            drawBox.BackColor = Color.Transparent;
            drawBox.Parent = imageBox;
            drawBox.Location = new Point(0, 0);
            drawBitmap = new Bitmap(drawBox.Width, drawBox.Height);
            image = new Bitmap(imageBox.Width, imageBox.Height);
            drawBox.Image = drawBitmap;
            allColors = new Color[imageBox.Width - 1, imageBox.Height - 1];
        }

        /*private void Form1_Load(object sender, EventArgs e)
        {
            // Transparent background...  
            drawBox.BackColor = Color.Transparent;
            // Change parent for overlay PictureBox...
            drawBox.Parent = imageBox;
            drawBox.Location = new Point(0, 0);
        }*/

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
                    drawBitmap = new Bitmap(image.Width, image.Height);
                    drawBox.Image = drawBitmap;
                    label1.Text = drawBox.Location.ToString();
                    //drawBox.Location = new Point(0, 0);
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
            gr =  Graphics.FromImage(drawBox.Image);
            if (draw)
            {
                gr.DrawLine(myPen, point.X, point.Y, e.X, e.Y);
                gr.FillEllipse(brush, e.X, e.Y, 10, 10);
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

        private void drawBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (backgroundCheck.Checked)
            {
                myPen = new Pen(Color.Blue);
                brush = new SolidBrush(Color.Blue);
            }
            else
            {
                myPen = new Pen(Color.Red);
                brush = new SolidBrush(Color.Red);
            }
            point = e.Location;
            draw = true;
        }

        private void growCutButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < (imageBox.Width - 1); i++)
            {
                for (int j = 0; j < (imageBox.Height - 1); j++)
                {
                    allColors[i, j] = image.GetPixel(i, j);
                }
            }

            label1.Text += imageBox.Image.Width + " - width image";
            label1.Text += imageBox.Image.Height + " - height image";
            label1.Text += drawBox.Image.Width + " - width draw";
            label1.Text += drawBox.Image.Height + " - height draw";

            //CellDescription[,] test = GrowCut.getCellsMap((Bitmap)pictureBox.Image, (Bitmap)drawBox.Image);
            //GrowCut growCut = new GrowCut((Bitmap)pictureBox.Image.Clone(), test);
            //growCut.evolution(updatePictureWithCells);
        }
        
        /*private void updatePictureWithCells(CellDescription[,] cells)
        {
            Bitmap resultImage = (Bitmap)pictureBox.Image.Clone();
            for (int x = 0; x < resultImage.Width; x++)
            {
                {
                    for (int y = 0; y < resultImage.Height; y++)
                    {
                        int[] currentPixel = GrowCut.colorToVector(resultImage.GetPixel(x, y));
                        if (cells[x, y].label == 1)
                        {
                            int blue = Math.Min(255, currentPixel[2] + 100);
                            resultImage.SetPixel(x, y, Color.FromArgb(currentPixel[0], currentPixel[1], blue));
                        }
                        else
                        {
                            int red = Math.Min(255, currentPixel[0] + 100);
                            resultImage.SetPixel(x, y, Color.FromArgb(red, currentPixel[1], currentPixel[2]));
                        }
                    }
                }
                pictureBox.Image = resultImage;
            }
        }*/
    }
}