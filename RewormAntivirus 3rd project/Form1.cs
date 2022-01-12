using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RewormAntivirus_3rd_project
{
    public partial class Form1 : Form
    {
        WebClient w_client = new WebClient();
        private bool home, scan, speed,  update,  report = false;
        public Form1()
        {

            InitializeComponent();

        }
        /// <summary>
        /// Flickering 
        /// </summary>
       protected override CreateParams CreateParams {
           get
            {
                CreateParams handleparams = base.CreateParams;
                handleparams.ExStyle |= 0x02000000; // WX_EX_COMPOSITE
                return handleparams;
            }
        }

      
        /// <summary>
        /// ParentForm Refresh On Closing Child Form ()
        /// SpeedUpForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Speedbutton_Click(object sender, EventArgs e)
        {
            bool isOpen = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Text == "SpeedUpForm") {
                    isOpen = true;
                    form.BringToFront();
                    break;
                }
            }
            if (!isOpen)
            {
                this.BackgroundImage = Properties.Resources.Speedbtn;
                SpeedUpForm speed = new SpeedUpForm();
                speed.FormClosing += Speed_FormClosing;
                speed.Show();
            }
            
        }
        private void Speed_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.BackgroundImage = Properties.Resources.Homebtn;
           
            if (home) this.BackgroundImage = Properties.Resources.Homebtn;
            else if (update) this.BackgroundImage = Properties.Resources.Updatebtn;
            else if (report) this.BackgroundImage = Properties.Resources.Reportbtn;
            else if (scan) this.BackgroundImage = Properties.Resources.Scanbtn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            scanpage.Hide();
            homeControl1.Show();
            homeControl1.BringToFront();
            this.BackgroundImage = Properties.Resources.Homebtn;
            home = true;
            update = false;
            report = false;
            scan = false;

        }
        private void Homebutton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Homebtn;
            scanpage.Hide();
            homeControl1.Show();
            homeControl1.BringToFront();
            home = true;
            update = false;
            report = false;
            scan = false;

        }
        public void Scanbutton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Scanbtn;
            homeControl1.Hide();
            scanpage.Show();
            scanpage.BringToFront();
            scan = true;
            update = false;
            report = false;
            home = false;
        }
    
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Updatebtn;
            homeControl1.Hide();
            scanpage.Hide();
            updateForm1.Show();
            updateForm1.BringToFront();
            update = true;
            home = false;
            report = false;
            scan = false;
               try
               {
                   if (!w_client.DownloadString("https://pastebin.com/raw/2Ywm971b").Contains("1.0"))
                   {
                       if (MessageBox.Show("Update is Available !\nAre you sure, you want to update ?? ", "Updation Confirmation!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                       {
                           var uri = "https://antivirusupdation.weebly.com/";
                           var psi = new System.Diagnostics.ProcessStartInfo();
                           psi.UseShellExecute = true;
                           psi.FileName = uri;
                           System.Diagnostics.Process.Start(psi);
                       }
                   }

               }
               catch
               {
                   MessageBox.Show("Opss! Something went wrong  :( \nPlease check your internet connection and try again!!", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            
        }
        private void Reportbutton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Reportbtn;
            WebClient w_client = new WebClient();

            try
            {
                if (MessageBox.Show("Are you sure, you want to report us?? ", "Report!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var uri = "https://antivirusupdation.weebly.com/report-us.html";
                    var psi = new System.Diagnostics.ProcessStartInfo();
                    psi.UseShellExecute = true;
                    psi.FileName = uri;
                    System.Diagnostics.Process.Start(psi);
                }

            }
            catch
            {
                MessageBox.Show("Opss! Something went wrong  :( \nPlease check your internet connection and try again!!", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            report = true;
            update = false;
            home = false;
            scan = false;

        }

        private void scanpage_Load(object sender, EventArgs e)
        {
            scanpage.BackgroundImage = Properties.Resources.compscan1;
        }
    }
}
