using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace RewormAntivirus_3rd_project
{
    public partial class HomeControl : UserControl
    {
        // Flickering 
        protected override CreateParams CreateParams
        {

            get
            {
                CreateParams handleparams = base.CreateParams;
                handleparams.ExStyle |= 0x02000000; // WX_EX_COMPOSITE
                return handleparams;
            }

        }
        public HomeControl()
        {
            InitializeComponent();
        }

        private void speedbig_MouseEnter(object sender, EventArgs e)
        {
            speedbig.BackgroundImage = Properties.Resources.hover_speed_big_btn_unselected;
        }

        private void speedbig_MouseLeave(object sender, EventArgs e)
        {
            speedbig.BackgroundImage = Properties.Resources.speed_big_btn_unselected;
        }

        private void scanbig_MouseEnter(object sender, EventArgs e)
        {
            scanbig.BackgroundImage = Properties.Resources.hover_scan_big_btn_unselected;
        }

        private void scanbig_MouseLeave(object sender, EventArgs e)
        {
            scanbig.BackgroundImage = Properties.Resources.scan_big_btn_unselected;
        }

        private void active_MouseEnter(object sender, EventArgs e)
        {
            active.BackgroundImage = Properties.Resources.hoveractivate;
        }

        private void active_MouseLeave(object sender, EventArgs e)
        {
            active.BackgroundImage = Properties.Resources.activatebtn;
        }

        private void buy_MouseEnter(object sender, EventArgs e)
        {
            buy.BackgroundImage = Properties.Resources.hoverlicense;
        }

        private void buy_MouseLeave(object sender, EventArgs e)
        {
            buy.BackgroundImage = Properties.Resources.buybtn;
        }

        private void buy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is In Testing Mode Fully Activated Version");
        }

        private void active_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is In Testing Mode Fully Activated Version No need To Buy");
        }

        private void scanbig_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Enter the Scan button ");
        }

      

        private void speedbig_Click(object sender, EventArgs e)
        {
            SpeedUpForm speed = new SpeedUpForm();
            speed.Show(); 
        }
    }
}
