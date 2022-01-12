using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RewormAntivirus_3rd_project
{
    public partial class SpeedUpForm : Form
    {
        private BackgroundWorker BackgroundWorker = new BackgroundWorker();
        private bool op1 = false, op2 = false, op3 = false, op4 = false, op5 = false, op6 = false,op7=false;
        
        public SpeedUpForm()
        {
            InitializeComponent();
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            BackgroundWorker.WorkerSupportsCancellation = true;
            BackgroundWorker.WorkerReportsProgress = true;
        }


        protected override CreateParams CreateParams
        {

            get
            {
                CreateParams handleparams = base.CreateParams;
                handleparams.ExStyle |= 0x02000000; // WX_EX_COMPOSITE
                return handleparams;
            }

        }

        private void SpeedUpForm_Load(object sender, EventArgs e)
        {
            progressBar1.Hide();
        }
        //Completed Work
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Threading.Thread.Sleep(5000);
            progressBar1.Value = 100;
              this.Hide();
              this.Close();
        }
        //Progress Work
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
        //Function
        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            int i = 0;
            InternetCache.Invoke((Action)(() => InternetCache.Hide()));
            Cookies.Invoke((Action)(() => Cookies.Hide()));
            Temproray.Invoke((Action)(() => Temproray.Hide()));
            AppDataTemp.Invoke((Action)(() => AppDataTemp.Hide()));
            Recycle.Invoke((Action)(() => Recycle.Hide()));
            History.Invoke((Action)(() => History.Hide()));


            this.BackgroundImage = Properties.Resources.Done;
            progressBar1.Invoke((Action)(() => progressBar1.Show()));
            if (op1) internetCacheMethod();
            i += 20;
            BackgroundWorker.ReportProgress(i);
            if (op2) CookiesMethod();
            i += 20;
            BackgroundWorker.ReportProgress(i);
            if (op3) TempMethod();
            i += 20;
            BackgroundWorker.ReportProgress(i);
            if (op4) AppDataMethod();
            i += 20;
            BackgroundWorker.ReportProgress(i);
            if (op5) recycleBinMethod();
            i += 10;
            BackgroundWorker.ReportProgress(i);
            if (op6) HistoryMethod();
            i += 9;
            BackgroundWorker.ReportProgress(i);
         
        }



        /// <summary>
        /// PictureBoxesSwicthes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void InternetCache_MouseDown(object sender, MouseEventArgs e)
        {
            if (!op1)
            {
                InternetCache.BackgroundImage = Properties.Resources.OnSwithc;
                op1 = true;
               
            }
            else
            {
                InternetCache.BackgroundImage = Properties.Resources.OffSwithc;
                this.BackgroundImage = Properties.Resources.Unselected_all;
                op1 = false;
            }
            checkPackageOfSwitches(0);
        }
        private void Cookies_MouseDown(object sender, MouseEventArgs e)
        {
            if (!op2)
            {
                Cookies.BackgroundImage = Properties.Resources.OnSwithc;
                op2 = true;
               
            }
            else
            {
                Cookies.BackgroundImage = Properties.Resources.OffSwithc;
                this.BackgroundImage = Properties.Resources.Unselected_all;
                op2 = false;
            }
            checkPackageOfSwitches(0);
        }
        private void Temp_MouseDown(object sender, MouseEventArgs e)
        {
            if (!op3)
            {
                Temproray.BackgroundImage = Properties.Resources.OnSwithc;
                op3 = true;
               
            }

            else
            {
                Temproray.BackgroundImage = Properties.Resources.OffSwithc;
                this.BackgroundImage = Properties.Resources.Unselected_all;
                op3 = false;
            }
            checkPackageOfSwitches(0);
        }
        private void AppData_MouseDown(object sender, MouseEventArgs e)
        {
            if (!op4)
            {
                AppDataTemp.BackgroundImage = Properties.Resources.OnSwithc;
                op4 = true;
              
            }
            else
            {
                AppDataTemp.BackgroundImage = Properties.Resources.OffSwithc;
                this.BackgroundImage = Properties.Resources.Unselected_all;
                op4 = false;
            }
            checkPackageOfSwitches(0);
        }
        private void Recycle_MouseDown(object sender, MouseEventArgs e)
        {
            if (!op5)
            {
                Recycle.BackgroundImage = Properties.Resources.OnSwithc;
                op5 = true;
               
            }
            else
            {
                Recycle.BackgroundImage = Properties.Resources.OffSwithc;
                this.BackgroundImage = Properties.Resources.Unselected_all;
                op5 = false;
            }
            checkPackageOfSwitches(0);
        }
        private void History_MouseDown(object sender, MouseEventArgs e)
        {
            if (!op6)
            {
                History.BackgroundImage = Properties.Resources.OnSwithc;
                op6 = true;
              
            }
            else
            {
               History.BackgroundImage = Properties.Resources.OffSwithc;
                this.BackgroundImage = Properties.Resources.Unselected_all;
                op6 = false;
            }
            checkPackageOfSwitches(0);
        }
        private void Select_MouseDown(object sender, MouseEventArgs e)
        {
            if (!op7) {
                History.BackgroundImage = Properties.Resources.OnSwithc;
                Recycle.BackgroundImage = Properties.Resources.OnSwithc;
                AppDataTemp.BackgroundImage = Properties.Resources.OnSwithc;
                Temproray.BackgroundImage = Properties.Resources.OnSwithc;
                Cookies.BackgroundImage = Properties.Resources.OnSwithc;
                InternetCache.BackgroundImage = Properties.Resources.OnSwithc;
                this.BackgroundImage = Properties.Resources.select;
                op1 = true;
                op2 = true;
                op3 = true;
                op4 = true;
                op5 = true;
                op6 = true;
                op7 = true;
            }
            else
            {
                History.BackgroundImage = Properties.Resources.OffSwithc;
                Recycle.BackgroundImage = Properties.Resources.OffSwithc;
                AppDataTemp.BackgroundImage = Properties.Resources.OffSwithc;
                Temproray.BackgroundImage = Properties.Resources.OffSwithc;
                Cookies.BackgroundImage = Properties.Resources.OffSwithc;
                InternetCache.BackgroundImage = Properties.Resources.OffSwithc;
                this.BackgroundImage = Properties.Resources.Unselected_all;
                op1 = false;
                op2 = false;
                op3 = false;
                op4 = false;
                op5 = false;
                op6 = false;
                op7 = false;

            }
        }
        private void Proceed_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(op1 || op2 || op3 || op4 || op5 || op6 || op7))
            {
                MessageBox.Show("Please Select any of one ");
            }
            else if (BackgroundWorker.IsBusy) {
                MessageBox.Show("Process is already started please Wait to end this");
            }
            else
            {
                BackgroundWorker.RunWorkerAsync();
            }
        }


       /// <summary>
       /// Methods Calles By The pictureBoxes
       /// </summary>
       /// <param name="n"></param>
       


        private void checkPackageOfSwitches(int n)
        {
            if (n == 0)
            {
                if (op1 || op2 || op3 || op4 || op5 || op6)
                {
                    this.BackgroundImage = Properties.Resources.Proceed;
                }
                if (op1 && op2 && op3 && op4 && op5 && op6) {
                    this.BackgroundImage = Properties.Resources.select;
                    op1 = true;
                    op2 = true;
                    op3 = true;
                    op4 = true;
                    op5 = true;
                    op6 = true;
                    op7 = true;
                }
            }
           
          
        }
        private void internetCacheMethod() {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache);
            var di = new DirectoryInfo(path);
            MessageBox.Show(di.ToString());
          ClearTempData(di);
        }
        private void CookiesMethod() {
            var cookie = Environment.GetFolderPath(Environment.SpecialFolder.Cookies);
            var di = new DirectoryInfo(cookie);
            MessageBox.Show(di.ToString());
            ClearTempData(di);
        }
        private void HistoryMethod() {
            var history = Environment.GetFolderPath(Environment.SpecialFolder.History);
            var di = new DirectoryInfo(history);
            MessageBox.Show(di.ToString());
            ClearTempData(di);
        
        }

        private void TempMethod() {
            var di = new DirectoryInfo(System.IO.Path.GetTempPath());
            MessageBox.Show(di.ToString());
            ClearTempData(di);
        }
        private void AppDataMethod()
        {
            var di = new DirectoryInfo(@"C:\Windows\Temp");
            MessageBox.Show(di.ToString());
            ClearTempData(di);
        }
        private void recycleBinMethod() {
           
             uint result = SHEmptyRecycleBin(IntPtr.Zero, null, 0);
            MessageBox.Show("Deleting Recycle Bin");
        }

         
        /// <summary>
        /// Method Clear Temp Data to clear the data in the directory passed(@"path");
        /// </summary>
        /// <param name="di"></param>
        
        private static void ClearTempData(DirectoryInfo di)
        {
           
            foreach (FileInfo file in di.GetFiles())
            {
                try
                {
                    file.Delete();
                  
                }
                catch (Exception ex)
                {
                    continue;
                }
            }

            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                try
                {
                    dir.Delete(true);
                   
                }
                catch (Exception ex)
                {
                    continue;
                }
            }
        }

        /// <summary>
        /// For RecycleBin Method to Delete
        /// </summary>
        /// <param name="hwnd"></param>
        /// <param name="pszRootPath"></param>
        /// <param name="dwFlags"></param>
        /// <returns></returns>
        
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath,RecycleFlags dwFlags);
        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000001,
            SHERB_NOSOUND = 0x00000004
        }

    }
}
