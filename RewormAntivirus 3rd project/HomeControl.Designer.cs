namespace RewormAntivirus_3rd_project
{
    partial class HomeControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl));
            this.speedbig = new System.Windows.Forms.PictureBox();
            this.scanbig = new System.Windows.Forms.PictureBox();
            this.active = new System.Windows.Forms.PictureBox();
            this.buy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.speedbig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanbig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.active)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy)).BeginInit();
            this.SuspendLayout();
            // 
            // speedbig
            // 
            this.speedbig.BackColor = System.Drawing.Color.Transparent;
            this.speedbig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("speedbig.BackgroundImage")));
            this.speedbig.Location = new System.Drawing.Point(301, 296);
            this.speedbig.Name = "speedbig";
            this.speedbig.Size = new System.Drawing.Size(279, 204);
            this.speedbig.TabIndex = 0;
            this.speedbig.TabStop = false;
            this.speedbig.Click += new System.EventHandler(this.speedbig_Click);
            this.speedbig.MouseEnter += new System.EventHandler(this.speedbig_MouseEnter);
            this.speedbig.MouseLeave += new System.EventHandler(this.speedbig_MouseLeave);
            // 
            // scanbig
            // 
            this.scanbig.BackColor = System.Drawing.Color.Transparent;
            this.scanbig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scanbig.BackgroundImage")));
            this.scanbig.Location = new System.Drawing.Point(32, 296);
            this.scanbig.Name = "scanbig";
            this.scanbig.Size = new System.Drawing.Size(271, 204);
            this.scanbig.TabIndex = 0;
            this.scanbig.TabStop = false;
            this.scanbig.Click += new System.EventHandler(this.scanbig_Click);
            this.scanbig.MouseEnter += new System.EventHandler(this.scanbig_MouseEnter);
            this.scanbig.MouseLeave += new System.EventHandler(this.scanbig_MouseLeave);
            // 
            // active
            // 
            this.active.BackColor = System.Drawing.Color.Transparent;
            this.active.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("active.BackgroundImage")));
            this.active.Location = new System.Drawing.Point(282, 223);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(181, 48);
            this.active.TabIndex = 0;
            this.active.TabStop = false;
            this.active.Click += new System.EventHandler(this.active_Click);
            this.active.MouseEnter += new System.EventHandler(this.active_MouseEnter);
            this.active.MouseLeave += new System.EventHandler(this.active_MouseLeave);
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.Transparent;
            this.buy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buy.BackgroundImage")));
            this.buy.Location = new System.Drawing.Point(71, 223);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(181, 48);
            this.buy.TabIndex = 0;
            this.buy.TabStop = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            this.buy.MouseEnter += new System.EventHandler(this.buy_MouseEnter);
            this.buy.MouseLeave += new System.EventHandler(this.buy_MouseLeave);
            // 
            // HomeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.buy);
            this.Controls.Add(this.active);
            this.Controls.Add(this.speedbig);
            this.Controls.Add(this.scanbig);
            this.DoubleBuffered = true;
            this.Name = "HomeControl";
            this.Size = new System.Drawing.Size(676, 650);
            ((System.ComponentModel.ISupportInitialize)(this.speedbig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scanbig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.active)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox speedbig;
        private System.Windows.Forms.PictureBox scanbig;
        private System.Windows.Forms.PictureBox active;
        private System.Windows.Forms.PictureBox buy;
    }
}
