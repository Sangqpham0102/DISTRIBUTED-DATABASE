using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAI1
{
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
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

        private void setPixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap org = (Bitmap)pictureBox1.Image.Clone();
            Bitmap output = new Bitmap(org.Width, org.Height);
            for (int i = 0; i < output.Height; i++)
                for (int j = 0; j < output.Width; j++)
                {
                    Color c = org.GetPixel(j, i);
                    int g = (int)(c.R * 0.21 + c.G * 0.72 + c.B * 0.07);
                    output.SetPixel(j, i, Color.FromArgb(g, g, g));
                }
            pictureBox2.Image = output;
        }

        private void lockbitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            BitmapData bmpData = bmp.LockBits(rect, ImageLockMode.ReadWrite,
            PixelFormat.Format24bppRgb);
            IntPtr ptr = bmpData.Scan0;
            int Leght = bmpData.Stride * bmp.Height;
            byte[] rgbValues = new byte[Leght];
            Marshal.Copy(ptr, rgbValues, 0, Leght);
            int index = 0;
            try
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    index = y * bmpData.Stride;
                    for (int x = 0; x < bmp.Width; x++)
                    {
                        byte gray = Convert.ToByte(rgbValues[index + 2] * 0.299 +
                            rgbValues[index + 1] * 0.587 + rgbValues[index] * 0.114);
                        rgbValues[index] = rgbValues[index + 1] = rgbValues[index + 2] = gray;
                        index += 3;
                    }
                }
                Marshal.Copy(rgbValues, 0, ptr, Leght);
                bmp.UnlockBits(bmpData);
                pictureBox2.Image = bmp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void equaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }
            Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
            Bitmap equalizedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            // Perform histogram equalization
            int[] histogram = new int[256];
            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    histogram[originalColor.R]++;
                }
            }

            int[] cumulativeHistogram = new int[256];
            cumulativeHistogram[0] = histogram[0];
            for (int i = 1; i < 256; i++)
            {
                cumulativeHistogram[i] = cumulativeHistogram[i - 1] + histogram[i];
            }

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    int equalizedValue = (cumulativeHistogram[originalColor.R] * 255) / (originalBitmap.Width * originalBitmap.Height);
                    Color newColor = Color.FromArgb(equalizedValue, equalizedValue, equalizedValue);
                    equalizedBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = equalizedBitmap;
        }
        private void slideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
            Bitmap brightenedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            int brightnessAdjustment = 50; // Increase brightness by 50

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);

                    int newRed = Math.Min(originalColor.R + brightnessAdjustment, 255);
                    int newGreen = Math.Min(originalColor.G + brightnessAdjustment, 255);
                    int newBlue = Math.Min(originalColor.B + brightnessAdjustment, 255);

                    Color newColor = Color.FromArgb(newRed, newGreen, newBlue);
                    brightenedBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = brightenedBitmap;
        }

        private void strToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
            Bitmap stretchedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            int min = 255, max = 0;

            // Find min and max pixel values
            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    int grayValue = originalColor.R;
                    if (grayValue < min) min = grayValue;
                    if (grayValue > max) max = grayValue;
                }
            }

            // Perform contrast stretching
            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    int stretchedValue = (originalColor.R - min) * 255 / (max - min);
                    Color newColor = Color.FromArgb(stretchedValue, stretchedValue, stretchedValue);
                    stretchedBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = stretchedBitmap;
        }

        private void thrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
            Bitmap thresholdedBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            int threshold = 128; // Example threshold value

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    int grayValue = originalColor.R;
                    Color newColor = grayValue < threshold ? Color.Black : Color.White;
                    thresholdedBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBox2.Image = thresholdedBitmap;
        }

        private void notToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please open an image first.");
                return;
            }

            Bitmap originalBitmap = new Bitmap(pictureBox1.Image);
            Bitmap notBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    Color notColor = Color.FromArgb(255 - originalColor.R, 255 - originalColor.G, 255 - originalColor.B);
                    notBitmap.SetPixel(x, y, notColor);
                }
            }

            pictureBox2.Image = notBitmap;
        }

        private void andToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Please open two images first.");
                return;
            }

            Bitmap bitmap1 = new Bitmap(pictureBox1.Image);
            Bitmap bitmap2 = new Bitmap(pictureBox2.Image);

            if (bitmap1.Width != bitmap2.Width || bitmap1.Height != bitmap2.Height)
            {
                MessageBox.Show("Images must be of the same size.");
                return;
            }

            Bitmap andBitmap = new Bitmap(bitmap1.Width, bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color color1 = bitmap1.GetPixel(x, y);
                    Color color2 = bitmap2.GetPixel(x, y);
                    Color andColor = Color.FromArgb(color1.R & color2.R, color1.G & color2.G, color1.B & color2.B);
                    andBitmap.SetPixel(x, y, andColor);
                }
            }

            pictureBox2.Image = andBitmap;
        }

        private void orToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Please open two images first.");
                return;
            }

            Bitmap bitmap1 = new Bitmap(pictureBox1.Image);
            Bitmap bitmap2 = new Bitmap(pictureBox2.Image);

            if (bitmap1.Width != bitmap2.Width || bitmap1.Height != bitmap2.Height)
            {
                MessageBox.Show("Images must be of the same size.");
                return;
            }

            Bitmap orBitmap = new Bitmap(bitmap1.Width, bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color color1 = bitmap1.GetPixel(x, y);
                    Color color2 = bitmap2.GetPixel(x, y);
                    Color orColor = Color.FromArgb(color1.R | color2.R, color1.G | color2.G, color1.B | color2.B);
                    orBitmap.SetPixel(x, y, orColor);
                }
            }

            pictureBox2.Image = orBitmap;
        }
        private void andNotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Please open two images first.");
                return;
            }

            Bitmap bitmap1 = new Bitmap(pictureBox1.Image);
            Bitmap bitmap2 = new Bitmap(pictureBox2.Image);

            if (bitmap1.Width != bitmap2.Width || bitmap1.Height != bitmap2.Height)
            {
                MessageBox.Show("Images must be of the same size.");
                return;
            }

            Bitmap andNotBitmap = new Bitmap(bitmap1.Width, bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color color1 = bitmap1.GetPixel(x, y);
                    Color color2 = bitmap2.GetPixel(x, y);
                    Color andNotColor = Color.FromArgb(color1.R & ~color2.R, color1.G & ~color2.G, color1.B & ~color2.B);
                    andNotBitmap.SetPixel(x, y, andNotColor);
                }
            }

            pictureBox2.Image = andNotBitmap;
        }
        private void xORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null || pictureBox2.Image == null)
            {
                MessageBox.Show("Please open two images first.");
                return;
            }

            Bitmap bitmap1 = new Bitmap(pictureBox1.Image);
            Bitmap bitmap2 = new Bitmap(pictureBox2.Image);

            if (bitmap1.Width != bitmap2.Width || bitmap1.Height != bitmap2.Height)
            {
                MessageBox.Show("Images must be of the same size.");
                return;
            }

            Bitmap xorBitmap = new Bitmap(bitmap1.Width, bitmap1.Height);

            for (int y = 0; y < bitmap1.Height; y++)
            {
                for (int x = 0; x < bitmap1.Width; x++)
                {
                    Color color1 = bitmap1.GetPixel(x, y);
                    Color color2 = bitmap2.GetPixel(x, y);
                    Color xorColor = Color.FromArgb(color1.R ^ color2.R, color1.G ^ color2.G, color1.B ^ color2.B);
                    xorBitmap.SetPixel(x, y, xorColor);
                }
            }

            pictureBox2.Image = xorBitmap;
        }
    }
}
