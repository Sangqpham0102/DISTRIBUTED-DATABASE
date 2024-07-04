
namespace BAI8
{
    partial class ImgCartoonEe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSmoothingFilter = new System.Windows.Forms.Label();
            this.cmbSmoothingFilter = new System.Windows.Forms.ComboBox();
            this.pnlThreshold = new System.Windows.Forms.Panel();
            this.lblThresholdInfo = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.trcThreshold = new System.Windows.Forms.TrackBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlThreshold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Gainsboro;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(600, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPreview.TabIndex = 14;
            this.picPreview.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblSmoothingFilter);
            this.panel1.Controls.Add(this.cmbSmoothingFilter);
            this.panel1.Location = new System.Drawing.Point(618, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 76);
            this.panel1.TabIndex = 36;
            // 
            // lblSmoothingFilter
            // 
            this.lblSmoothingFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSmoothingFilter.Location = new System.Drawing.Point(6, 1);
            this.lblSmoothingFilter.Name = "lblSmoothingFilter";
            this.lblSmoothingFilter.Size = new System.Drawing.Size(217, 30);
            this.lblSmoothingFilter.TabIndex = 26;
            this.lblSmoothingFilter.Text = "Smoothing Filter";
            this.lblSmoothingFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbSmoothingFilter
            // 
            this.cmbSmoothingFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmoothingFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSmoothingFilter.FormattingEnabled = true;
            this.cmbSmoothingFilter.Location = new System.Drawing.Point(10, 34);
            this.cmbSmoothingFilter.Name = "cmbSmoothingFilter";
            this.cmbSmoothingFilter.Size = new System.Drawing.Size(213, 37);
            this.cmbSmoothingFilter.TabIndex = 20;
            this.cmbSmoothingFilter.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEvH);
            // 
            // pnlThreshold
            // 
            this.pnlThreshold.BackColor = System.Drawing.Color.Silver;
            this.pnlThreshold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlThreshold.Controls.Add(this.lblThresholdInfo);
            this.pnlThreshold.Controls.Add(this.lblThreshold);
            this.pnlThreshold.Controls.Add(this.trcThreshold);
            this.pnlThreshold.Location = new System.Drawing.Point(618, 94);
            this.pnlThreshold.Name = "pnlThreshold";
            this.pnlThreshold.Size = new System.Drawing.Size(228, 76);
            this.pnlThreshold.TabIndex = 35;
            // 
            // lblThresholdInfo
            // 
            this.lblThresholdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThresholdInfo.Location = new System.Drawing.Point(3, 0);
            this.lblThresholdInfo.Name = "lblThresholdInfo";
            this.lblThresholdInfo.Size = new System.Drawing.Size(142, 30);
            this.lblThresholdInfo.TabIndex = 28;
            this.lblThresholdInfo.Text = "Threshold:";
            this.lblThresholdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblThreshold
            // 
            this.lblThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreshold.Location = new System.Drawing.Point(142, 0);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(74, 30);
            this.lblThreshold.TabIndex = 29;
            this.lblThreshold.Text = "0";
            this.lblThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // trcThreshold
            // 
            this.trcThreshold.AutoSize = false;
            this.trcThreshold.BackColor = System.Drawing.SystemColors.Control;
            this.trcThreshold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trcThreshold.Location = new System.Drawing.Point(7, 33);
            this.trcThreshold.Maximum = 256;
            this.trcThreshold.Name = "trcThreshold";
            this.trcThreshold.Size = new System.Drawing.Size(213, 30);
            this.trcThreshold.TabIndex = 27;
            this.trcThreshold.ValueChanged += new System.EventHandler(this.FilterValueChangedEvH);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(618, 479);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(228, 46);
            this.btnOpen.TabIndex = 37;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(618, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(228, 46);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(618, 567);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(228, 46);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ImgCartoonEe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 621);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlThreshold);
            this.Controls.Add(this.picPreview);
            this.Name = "ImgCartoonEe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Cartoon Effect";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlThreshold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trcThreshold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSmoothingFilter;
        private System.Windows.Forms.ComboBox cmbSmoothingFilter;
        private System.Windows.Forms.Panel pnlThreshold;
        private System.Windows.Forms.Label lblThresholdInfo;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.TrackBar trcThreshold;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
    }
}

