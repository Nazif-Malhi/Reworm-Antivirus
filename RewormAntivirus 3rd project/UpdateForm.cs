using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace RewormAntivirus_3rd_project
{
    public partial class UpdateForm : UserControl
    {
        WebClient w_client = new WebClient();
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
           

           /* try
            {
                if (!w_client.DownloadString("https://pastebin.com/raw/2Ywm971b").Contains("1.0"))
                {
                    System.Threading.Thread.Sleep(100);
                    if (MessageBox.Show("Are you sure, you want to update ?? ", "Updation Confirmation!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            }*/
        }
    }
}
