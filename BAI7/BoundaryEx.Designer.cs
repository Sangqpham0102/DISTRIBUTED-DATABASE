
namespace BAI7
{
    partial class BoundaryEx
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
            this.picBox = new System.Windows.Forms.PictureBox();
            this.chkLivePreview = new System.Windows.Forms.CheckBox();
            this.lblSC = new System.Windows.Forms.Label();
            this.pnlSE = new System.Windows.Forms.Panel();
            this.lblFilterType = new System.Windows.Forms.Label();
            this.cmbFilterType = new System.Windows.Forms.ComboBox();
            this.lblFilterSize = new System.Windows.Forms.Label();
            this.chkB = new System.Windows.Forms.CheckBox();
            this.chkG = new System.Windows.Forms.CheckBox();
            this.chkR = new System.Windows.Forms.CheckBox();
            this.cmbFilterSize = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picBox.Location = new System.Drawing.Point(12, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(555, 647);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // chkLivePreview
            // 
            this.chkLivePreview.AutoSize = true;
            this.chkLivePreview.Checked = true;
            this.chkLivePreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLivePreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLivePreview.Location = new System.Drawing.Point(575, 478);
            this.chkLivePreview.Name = "chkLivePreview";
            this.chkLivePreview.Size = new System.Drawing.Size(202, 35);
            this.chkLivePreview.TabIndex = 47;
            this.chkLivePreview.Text = "Live Preview";
            this.chkLivePreview.UseVisualStyleBackColor = true;
            // 
            // lblSC
            // 
            this.lblSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSC.Location = new System.Drawing.Point(577, 176);
            this.lblSC.Name = "lblSC";
            this.lblSC.Size = new System.Drawing.Size(256, 38);
            this.lblSC.TabIndex = 46;
            this.lblSC.Text = "Structuring Element";
            this.lblSC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSE
            // 
            this.pnlSE.AutoScroll = true;
            this.pnlSE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSE.Location = new System.Drawing.Point(577, 218);
            this.pnlSE.Name = "pnlSE";
            this.pnlSE.Size = new System.Drawing.Size(256, 256);
            this.pnlSE.TabIndex = 45;
            // 
            // lblFilterType
            // 
            this.lblFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterType.Location = new System.Drawing.Point(573, 12);
            this.lblFilterType.Name = "lblFilterType";
            this.lblFilterType.Size = new System.Drawing.Size(260, 41);
            this.lblFilterType.TabIndex = 44;
            this.lblFilterType.Text = "Filter Type";
            this.lblFilterType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFilterType
            // 
            this.cmbFilterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterType.FormattingEnabled = true;
            this.cmbFilterType.Location = new System.Drawing.Point(582, 56);
            this.cmbFilterType.Name = "cmbFilterType";
            this.cmbFilterType.Size = new System.Drawing.Size(256, 37);
            this.cmbFilterType.TabIndex = 43;
            this.cmbFilterType.SelectedIndexChanged += new System.EventHandler(this.FilterValueChangedEvH);
            // 
            // lblFilterSize
            // 
            this.lblFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterSize.Location = new System.Drawing.Point(573, 93);
            this.lblFilterSize.Name = "lblFilterSize";
            this.lblFilterSize.Size = new System.Drawing.Size(111, 41);
            this.lblFilterSize.TabIndex = 42;
            this.lblFilterSize.Text = "Filter Size";
            this.lblFilterSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkB
            // 
            this.chkB.AutoSize = true;
            this.chkB.Checked = true;
            this.chkB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkB.Location = new System.Drawing.Point(755, 144);
            this.chkB.Name = "chkB";
            this.chkB.Size = new System.Drawing.Size(88, 33);
            this.chkB.TabIndex = 41;
            this.chkB.Text = "Blue";
            this.chkB.UseVisualStyleBackColor = true;
            this.chkB.CheckedChanged += new System.EventHandler(this.FilterSizeValueChangedEventH);
            // 
            // chkG
            // 
            this.chkG.AutoSize = true;
            this.chkG.Checked = true;
            this.chkG.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkG.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkG.Location = new System.Drawing.Point(654, 144);
            this.chkG.Name = "chkG";
            this.chkG.Size = new System.Drawing.Size(107, 33);
            this.chkG.TabIndex = 40;
            this.chkG.Text = "Green";
            this.chkG.UseVisualStyleBackColor = true;
            this.chkG.CheckedChanged += new System.EventHandler(this.FilterSizeValueChangedEventH);
            // 
            // chkR
            // 
            this.chkR.AutoSize = true;
            this.chkR.Checked = true;
            this.chkR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkR.Location = new System.Drawing.Point(575, 144);
            this.chkR.Name = "chkR";
            this.chkR.Size = new System.Drawing.Size(83, 33);
            this.chkR.TabIndex = 39;
            this.chkR.Text = "Red";
            this.chkR.UseVisualStyleBackColor = true;
            this.chkR.CheckedChanged += new System.EventHandler(this.FilterSizeValueChangedEventH);
            // 
            // cmbFilterSize
            // 
            this.cmbFilterSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterSize.FormattingEnabled = true;
            this.cmbFilterSize.Items.AddRange(new object[] {
            "None",
            "3",
            "5",
            "7",
            "9",
            "11",
            "13",
            "15",
            "17"});
            this.cmbFilterSize.Location = new System.Drawing.Point(694, 98);
            this.cmbFilterSize.Name = "cmbFilterSize";
            this.cmbFilterSize.Size = new System.Drawing.Size(144, 37);
            this.cmbFilterSize.TabIndex = 38;
            this.cmbFilterSize.SelectedIndexChanged += new System.EventHandler(this.FilterSizeValueChangedEventH);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(577, 566);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 46);
            this.btnSave.TabIndex = 37;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(577, 514);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(253, 46);
            this.btnOpen.TabIndex = 36;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Teal;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(576, 618);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(253, 46);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BoundaryEx
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(843, 672);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.chkLivePreview);
            this.Controls.Add(this.lblSC);
            this.Controls.Add(this.pnlSE);
            this.Controls.Add(this.lblFilterType);
            this.Controls.Add(this.cmbFilterType);
            this.Controls.Add(this.lblFilterSize);
            this.Controls.Add(this.chkB);
            this.Controls.Add(this.chkG);
            this.Controls.Add(this.chkR);
            this.Controls.Add(this.cmbFilterSize);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picBox);
            this.Name = "BoundaryEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Boundary Extraction ";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.CheckBox chkLivePreview;
        private System.Windows.Forms.Label lblSC;
        private System.Windows.Forms.Panel pnlSE;
        private System.Windows.Forms.Label lblFilterType;
        private System.Windows.Forms.ComboBox cmbFilterType;
        private System.Windows.Forms.Label lblFilterSize;
        private System.Windows.Forms.CheckBox chkB;
        private System.Windows.Forms.CheckBox chkG;
        private System.Windows.Forms.CheckBox chkR;
        private System.Windows.Forms.ComboBox cmbFilterSize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnExit;
    }
}

