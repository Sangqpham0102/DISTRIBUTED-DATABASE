using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace BAI6
{
    public partial class DoG : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        public DoG()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(picBox.Width);
                picBox.Image = previewBitmap;

                ApplyFilter(true);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplyFilter(false);

            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }
        private void ApplyFilter(bool preview)
        {
            if (previewBitmap == null || cmbEdgeDetection.SelectedIndex == -1)
            {
                return;
            }

            Bitmap selectedSource = null;
            Bitmap bitmapResult = null;

            if (preview == true)
            {
                selectedSource = previewBitmap;
            }
            else
            {
                selectedSource = originalBitmap;
            }

            if (selectedSource != null)
            {
                if (cmbEdgeDetection.SelectedItem.ToString() == "None")
                {
                    bitmapResult = selectedSource;
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "DoG Type 1")
                {
                    bitmapResult = selectedSource.DifferenceOfGaussians3x5Type1();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "DoG Type 2")
                {
                    bitmapResult = selectedSource.DifferenceOfGaussians3x5Type2();
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "DoG Type 1 - Invert")
                {
                    bitmapResult = selectedSource.DifferenceOfGaussians3x5Type1(true, true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "DoG Type 2 - Invert")
                {
                    bitmapResult = selectedSource.DifferenceOfGaussians3x5Type2(true, true);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "DoG Type 1 - 128 Bias")
                {
                    bitmapResult = selectedSource.DifferenceOfGaussians3x5Type1(true, false, 128);
                }
                else if (cmbEdgeDetection.SelectedItem.ToString() == "DoG Type 2 - 96 Bias")
                {
                    bitmapResult = selectedSource.DifferenceOfGaussians3x5Type2(true, false, 96);
                }
            }

            if (bitmapResult != null)
            {
                if (preview == true)
                {
                    picBox.Image = bitmapResult;
                }
                else
                {
                    resultBitmap = bitmapResult;
                }
            }
        }

        private void NeighbourCountValueChangedEvH(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }
    }
}