namespace RewormAntivirus_3rd_project
{
    partial class scanpage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(scanpage));
            this.scanbox = new System.Windows.Forms.PictureBox();
            this.initialprogressbar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textScanPath = new System.Windows.Forms.TextBox();
            this.smallScanBtn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AdvanceScan = new System.Windows.Forms.PictureBox();
            this.Quick = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scanbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallScanBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quick)).BeginInit();
            this.SuspendLayout();
            // 
            // scanbox
            // 
            this.scanbox.BackColor = System.Drawing.Color.Transparent;
            this.scanbox.InitialImage = null;
            this.scanbox.Location = new System.Drawing.Point(81, 126);
            this.scanbox.Name = "scanbox";
            this.scanbox.Size = new System.Drawing.Size(249, 89);
            this.scanbox.TabIndex = 0;
            this.scanbox.TabStop = false;
            this.scanbox.Click += new System.EventHandler(this.scanbox_Click);
            this.scanbox.MouseEnter += new System.EventHandler(this.scanbox_MouseEnter);
            this.scanbox.MouseLeave += new System.EventHandler(this.scanbox_MouseLeave);
            // 
            // initialprogressbar
            // 
            this.initialprogressbar.Location = new System.Drawing.Point(140, 387);
            this.initialprogressbar.Name = "initialprogressbar";
            this.initialprogressbar.Size = new System.Drawing.Size(494, 10);
            this.initialprogressbar.Step = 1;
            this.initialprogressbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.initialprogressbar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(51, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(285, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please wait it will take upto 2 minutes ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(304, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "0";
            // 
            // textScanPath
            // 
            this.textScanPath.Location = new System.Drawing.Point(115, 280);
            this.textScanPath.Name = "textScanPath";
            this.textScanPath.Size = new System.Drawing.Size(404, 23);
            this.textScanPath.TabIndex = 5;
            // 
            // smallScanBtn
            // 
            this.smallScanBtn.BackColor = System.Drawing.Color.Transparent;
            this.smallScanBtn.Location = new System.Drawing.Point(525, 290);
            this.smallScanBtn.Name = "smallScanBtn";
            this.smallScanBtn.Size = new System.Drawing.Size(109, 25);
            this.smallScanBtn.TabIndex = 6;
            this.smallScanBtn.TabStop = false;
            this.smallScanBtn.Click += new System.EventHandler(this.smallScanBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(100, 328);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 194);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragDrop);
            this.pictureBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox1_DragEnter);
            // 
            // AdvanceScan
            // 
            this.AdvanceScan.BackColor = System.Drawing.Color.Transparent;
            this.AdvanceScan.InitialImage = null;
            this.AdvanceScan.Location = new System.Drawing.Point(385, 126);
            this.AdvanceScan.Name = "AdvanceScan";
            this.AdvanceScan.Size = new System.Drawing.Size(249, 70);
            this.AdvanceScan.TabIndex = 8;
            this.AdvanceScan.TabStop = false;
            this.AdvanceScan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AdvanceScan_MouseClick);
            this.AdvanceScan.MouseEnter += new System.EventHandler(this.AdvanceScan_MouseEnter);
            this.AdvanceScan.MouseLeave += new System.EventHandler(this.AdvanceScan_MouseLeave);
            // 
            // Quick
            // 
            this.Quick.BackColor = System.Drawing.Color.Transparent;
            this.Quick.InitialImage = null;
            this.Quick.Location = new System.Drawing.Point(385, 193);
            this.Quick.Name = "Quick";
            this.Quick.Size = new System.Drawing.Size(206, 59);
            this.Quick.TabIndex = 9;
            this.Quick.TabStop = false;
            this.Quick.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Quick_MouseClick);
            this.Quick.MouseEnter += new System.EventHandler(this.Quick_MouseEnter);
            this.Quick.MouseLeave += new System.EventHandler(this.Quick_MouseLeave);
            // 
            // scanpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.Quick);
            this.Controls.Add(this.AdvanceScan);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.smallScanBtn);
            this.Controls.Add(this.textScanPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.initialprogressbar);
            this.Controls.Add(this.scanbox);
            this.DoubleBuffered = true;
            this.Name = "scanpage";
            this.Size = new System.Drawing.Size(676, 650);
            ((System.ComponentModel.ISupportInitialize)(this.scanbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallScanBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdvanceScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quick)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox scanbox;
        private System.Windows.Forms.ProgressBar initialprogressbar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textScanPath;
        private System.Windows.Forms.PictureBox smallScanBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AdvanceScan;
        private System.Windows.Forms.PictureBox Quick;
    }
}
