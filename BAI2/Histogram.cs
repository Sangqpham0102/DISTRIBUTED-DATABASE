using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI2
{
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = bitmap;
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save file...";
            saveFileDialog1.InitialDirectory = "C:/Users/Yoo/OneDrive";
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.Filter = "image file (*.BMP, *.JPG, *JPGE|*.bmp, .jpg;*.jpge)";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                pictureBox2.Image.Save(saveFileDialog1.FileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hisogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] h = new int[256];
            Bitmap bmh = new Bitmap(pictureBox1.Image);
            int x, y;
            for (y = 0; y < bmh.Height -1; y++)
            {
                for (x = 0; x < bmh.Width - 1; x++)
                    h[bmh.GetPixel(x, y).R] += 1;
            }
            int max = h[0];
            for (int j = 0; j < 255; j++)
                if (max < h[j])
                    max = h[j];
            Bitmap bmhhistogram = new Bitmap(256, max);
            Graphics gp = Graphics.FromImage(bmhhistogram);
            gp.FillRectangle(new Pen(Color.White).Brush, new Rectangle(0, 0, 256, max));
            for (int i = 0; i < 255; i++)
            {
                gp.DrawLine(new Pen(Color.Gray), i, max, i, max - h[i]);
            }
            pictureBox2.Image = bmhhistogram;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void pointProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
            Bitmap processedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);

                    // Example point processing: increase brightness
                    int newRed = Math.Min(originalColor.R + 50, 255); // Increase red component
                    int newGreen = Math.Min(originalColor.G + 50, 255); // Increase green component
                    int newBlue = Math.Min(originalColor.B + 50, 255); // Increase blue component

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    processedBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = processedBitmap;
        }
    
    }
}
