namespace RewormAntivirus_3rd_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Scanbutton = new System.Windows.Forms.PictureBox();
            this.Speedbutton = new System.Windows.Forms.PictureBox();
            this.Updatebutton = new System.Windows.Forms.PictureBox();
            this.Reportbutton = new System.Windows.Forms.PictureBox();
            this.Homebutton = new System.Windows.Forms.PictureBox();
            this.homeControl1 = new RewormAntivirus_3rd_project.HomeControl();
            this.scanpage = new RewormAntivirus_3rd_project.scanpage();
            this.updateForm1 = new RewormAntivirus_3rd_project.UpdateForm();
            ((System.ComponentModel.ISupportInitialize)(this.Scanbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speedbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Updatebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reportbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Homebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // Scanbutton
            // 
            this.Scanbutton.BackColor = System.Drawing.Color.Transparent;
            this.Scanbutton.Location = new System.Drawing.Point(0, 225);
            this.Scanbutton.Name = "Scanbutton";
            this.Scanbutton.Size = new System.Drawing.Size(210, 54);
            this.Scanbutton.TabIndex = 0;
            this.Scanbutton.TabStop = false;
            this.Scanbutton.Click += new System.EventHandler(this.Scanbutton_Click);
            // 
            // Speedbutton
            // 
            this.Speedbutton.BackColor = System.Drawing.Color.Transparent;
            this.Speedbutton.Location = new System.Drawing.Point(0, 324);
            this.Speedbutton.Name = "Speedbutton";
            this.Speedbutton.Size = new System.Drawing.Size(210, 54);
            this.Speedbutton.TabIndex = 0;
            this.Speedbutton.TabStop = false;
            this.Speedbutton.Click += new System.EventHandler(this.Speedbutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.Color.Transparent;
            this.Updatebutton.Location = new System.Drawing.Point(0, 421);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(210, 54);
            this.Updatebutton.TabIndex = 0;
            this.Updatebutton.TabStop = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Reportbutton
            // 
            this.Reportbutton.BackColor = System.Drawing.Color.Transparent;
            this.Reportbutton.Location = new System.Drawing.Point(0, 520);
            this.Reportbutton.Name = "Reportbutton";
            this.Reportbutton.Size = new System.Drawing.Size(210, 54);
            this.Reportbutton.TabIndex = 0;
            this.Reportbutton.TabStop = false;
            this.Reportbutton.Click += new System.EventHandler(this.Reportbutton_Click);
            // 
            // Homebutton
            // 
            this.Homebutton.BackColor = System.Drawing.Color.Transparent;
            this.Homebutton.Location = new System.Drawing.Point(0, 127);
            this.Homebutton.Name = "Homebutton";
            this.Homebutton.Size = new System.Drawing.Size(210, 54);
            this.Homebutton.TabIndex = 0;
            this.Homebutton.TabStop = false;
            this.Homebutton.Click += new System.EventHandler(this.Homebutton_Click);
            // 
            // homeControl1
            // 
            this.homeControl1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.homeControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeControl1.BackgroundImage")));
            this.homeControl1.Location = new System.Drawing.Point(227, 0);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(677, 647);
            this.homeControl1.TabIndex = 1;
            // 
            // scanpage
            // 
            this.scanpage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.scanpage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scanpage.BackgroundImage")));
            this.scanpage.Location = new System.Drawing.Point(227, 0);
            this.scanpage.Name = "scanpage";
            this.scanpage.Size = new System.Drawing.Size(677, 650);
            this.scanpage.TabIndex = 3;
            this.scanpage.Load += new System.EventHandler(this.scanpage_Load);
            // 
            // updateForm1
            // 
            this.updateForm1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateForm1.BackgroundImage")));
            this.updateForm1.Location = new System.Drawing.Point(227, 0);
            this.updateForm1.Name = "updateForm1";
            this.updateForm1.Size = new System.Drawing.Size(676, 650);
            this.updateForm1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(902, 649);
            this.Controls.Add(this.updateForm1);
            this.Controls.Add(this.scanpage);
            this.Controls.Add(this.homeControl1);
            this.Controls.Add(this.Homebutton);
            this.Controls.Add(this.Reportbutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.Speedbutton);
            this.Controls.Add(this.Scanbutton);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reworm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scanbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speedbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Updatebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Reportbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Homebutton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Scanbutton;
        private System.Windows.Forms.PictureBox Speedbutton;
        private System.Windows.Forms.PictureBox Updatebutton;
        private System.Windows.Forms.PictureBox Reportbutton;
        private System.Windows.Forms.PictureBox Homebutton;
        private HomeControl homeControl1;
        private scanpage scanpage;
        private UpdateForm updateForm1;
    }
}

