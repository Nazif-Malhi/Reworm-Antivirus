using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace RewormAntivirus_3rd_project
{
    public partial class scanpage : UserControl
    {
        private int driveLength, Folderlength, p = 0, NumberOfiles = 0, detection = 0;
        private ArrayList arrlistForFolders = new ArrayList();
        private ArrayList arrlistForFiles = new ArrayList();
        private ArrayList deletePath = new ArrayList();
        private BackgroundWorker BackgroundWorker = new BackgroundWorker();
        private BinaryTree binaryTree = new BinaryTree();

        private bool selected, scanInitiated, flawOfQuickLeave, flawforadvancesearch,flawforScan,flawforDelete;
        public scanpage()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.compscan1;
            initialprogressbar.Hide();
            BackgroundWorker.DoWork += BackgroundWorker_DoWork;
            BackgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            BackgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            BackgroundWorker.WorkerSupportsCancellation = true;
            BackgroundWorker.WorkerReportsProgress = true;

            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Hide();
            label2.Hide();
            label3.Hide();
            Quick.Hide();
            pictureBox1.AllowDrop = true;
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






        // after completing progress barr
        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Hide();
            label3.Hide();
            label3.Text = "";
            detection = 0;
            initialprogressbar.Value = 100;
            MessageBox.Show("Done");
            selected = false;
            scanInitiated = false;
            flawforadvancesearch = false;
            flawOfQuickLeave = false;
            flawforScan = true;
            label2.Hide();
            initialprogressbar.Hide();
            this.BackgroundImage = Properties.Resources.compscan;
            arrlistForFolders.Clear();
            arrlistForFolders.Clear();
            deletePath.Clear();
            textScanPath.Show();
            smallScanBtn.Show();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if ((flawforDelete)||(deletePath.Count>0))
            {
                if (MessageBox.Show("Do You want to Delete Your Files ?", "Deleting Files Warining !", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    delete(deletePath);
                }
            }
            flawforDelete = true;
        }

        //Progress bar status
        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            initialprogressbar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            initialprogressbar.Value = 0;
           
            if (scanInitiated)
            {
                scanInitiated = false;

                writeStatment();
            }
            main();

        }



        private void scanbox_Click(object sender, EventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            this.BackgroundImage = Properties.Resources.final_scan_progress;
            initialprogressbar.Value = 0;
            initialprogressbar.Show();
            selected = true;
            if (!BackgroundWorker.IsBusy)
            {
                label1.Show();
                label3.Show();
                textScanPath.Hide();
                smallScanBtn.Hide();
                pictureBox1.Hide();
                flawforScan = false;
                BackgroundWorker.RunWorkerAsync();
            }
            else
            {
                flawforDelete = false;
                BackgroundWorker.CancelAsync();
                label3.Text = "";
                initialprogressbar.Value = 0;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }


        }
        private void scanbox_MouseEnter(object sender, EventArgs e)
        {

            if (selected)
            {
                return;
            }
            else if (!flawforScan) {
                return;
            } 
            else
            {
                this.BackgroundImage = Properties.Resources.systemscanhover;
            }

        }
        private void scanbox_MouseLeave(object sender, EventArgs e)
        {
           
            if (selected)
            {
                return;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.compscan;
            }

        }


        /// <summary>
        /// Main function Calling by the background worker to Geting Files Path 
        /// </summary>

        public void main()
        {

            string[] drives = new string[driveLength];

            // Calling Drive Functions

            drives = Drives();
            for (int i = 0; i < driveLength - 1; i++)
            {
                Folders(drives[i]);
            }

            writeStatment();
        }

        //Geting Grive Path and infromation
        /// <summary>
        /// Obtaing Regression From Drive to Main Regression (Folders-->Files)
        /// </summary>
        /// <returns></returns>

        public string[] Drives()
        {

            var drv = DriveInfo.GetDrives();
            driveLength = DriveInfo.GetDrives().Length;
            Console.WriteLine("Drives Are = " + driveLength);
            string[] drive = new string[driveLength];
            int i = 0;
            Console.WriteLine("Drives are ....");
            foreach (DriveInfo dInfo in drv)
            {
                drive[i] = dInfo.Name;
                i++;
            }
            return drive;
        }
        public void Folders(string folderpath)
        {
            string[] d = Directory.GetDirectories(folderpath);
            Folderlength = Directory.GetDirectories(folderpath).Length;

            int i = 0;
            foreach (string di in d)
            {
                if (!di.Equals(@"D:\$RECYCLE.BIN") || !!di.Equals(@"C:\$RECYCLE.BIN"))
                {
                    Files(di);
                    i++;
                    try
                    {
                        Folders(di);

                    }
                    catch (UnauthorizedAccessException)
                    {
                    }
                    p++;

                }
                if (BackgroundWorker.CancellationPending)
                {
                    break;
                }

            }
        }
        public void Files(string filepath)
        {
            string slash = @"\";
            try
            {
                string[] fileString = Directory.GetFiles(filepath);
                foreach (string files in fileString)
                {
                    NumberOfiles++;
                    var filename = Path.GetFileName(files);
                    arrlistForFiles.Add(filepath + slash + filename);
                    arrlistForFolders.Add(filename);
                }
            }
            catch (Exception)
            {
            }
        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("FileName"))
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                    foreach (string Files in files)
                    {
                        string Filename = Path.GetFullPath(Files);
                        if (File.Exists(Filename))
                        {
                            string mdf = getMD5FromFile(Filename);
                            if (matchingHashCodes(mdf))
                            {
                                MessageBox.Show("Contain Viruses");
                                break;
                            }
                            else
                            {
                                MessageBox.Show("No virus Found");
                            }
                        }
                        else MessageBox.Show("Please only Drops files");
                    }
                }
            }
        }
        private void pictureBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private void AdvanceScan_MouseClick(object sender, MouseEventArgs e)
        {
          
            if (BackgroundWorker.IsBusy) {
                BackgroundWorker.CancelAsync();
                label3.Text = "";
                initialprogressbar.Value = 0;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            if (flawforadvancesearch) return;
            else
            {
                Quick.Show();
                Quick.BackgroundImage = Properties.Resources.quickscan;
            }
        }

        private void AdvanceScan_MouseEnter(object sender, EventArgs e)
        {
          
             if (flawforadvancesearch) return;
            else if (!flawforScan)
            {
                return;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.AdvanceScanPage;
            }
        }

        private void AdvanceScan_MouseLeave(object sender, EventArgs e)
        {
           
            if (flawforadvancesearch) return;
            else if (!flawforScan)
            {
                return;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.compscan;

            }
        }


        private void Quick_MouseEnter(object sender, EventArgs e)
        { 
           this.BackgroundImage = Properties.Resources.compscan;
            Quick.BackgroundImage = Properties.Resources.quickScanHover;
        }


        private void Quick_MouseLeave(object sender, EventArgs e)
        {
            if (flawOfQuickLeave)
            {
                flawOfQuickLeave = false;
                Quick.Hide();
            }
            else
            {
               this.BackgroundImage = Properties.Resources.compscan;
                Quick.Hide();
            }

        }

     
        private void Quick_MouseClick(object sender, MouseEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            scanInitiated = true;
            flawOfQuickLeave = true;
            flawforadvancesearch = true;
            string Desktoppath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Folders(Desktoppath);
            this.BackgroundImage = Properties.Resources.final_quick_progress;
            initialprogressbar.Value = 0;
            initialprogressbar.Show();
            selected = true;
            if (!BackgroundWorker.IsBusy)
            {
                label1.Show();
                label3.Show();
                textScanPath.Hide();
                smallScanBtn.Hide();
                pictureBox1.Hide();
                BackgroundWorker.RunWorkerAsync();
                Quick.Hide();
            }
            else
            {
                flawforDelete = false;
                BackgroundWorker.CancelAsync();
                initialprogressbar.Value = 0;
               
            }

        }

        private void smallScanBtn_Click(object sender, EventArgs e)
        {

            if (textScanPath.Equals(null)) MessageBox.Show("Please Give the Path");
            else
            {
                string path = textScanPath.Text;
                if (File.Exists(path))
                {
                    string mdf = getMD5FromFile(path);
                    if (matchingHashCodes(mdf))
                    {
                        MessageBox.Show("Contain Viruses");
                    }
                    else
                    {
                        MessageBox.Show("No virus Found");
                    }
                }
                else MessageBox.Show("Please only enter the File path ending with file (name.extension)");

            }

        }

        public void writeStatment()
        {
            try
            {
                TextWriter tw = new StreamWriter("C:/Users//Nazif/Desktop//opop.txt");
                TextWriter tw1 = new StreamWriter("C:/Users//Nazif/Desktop//opopop.txt");

              
                DateTime my = DateTime.Now;
                var m = my.ToString();
                tw.WriteLine(m);
                int i = 0;
                int p = 0;
                label1.Invoke((Action)(() => label1.Hide()));
                label2.Invoke((Action)(() => label2.Show()));
                for (int k = 0; k < arrlistForFiles.Count; k++)
                {
                    if (BackgroundWorker.CancellationPending)
                    {

                        break;
                    }
                    tw.WriteLine(arrlistForFiles[k]);
                    string op = getMD5FromFile(arrlistForFiles[k].ToString());
                    tw1.WriteLine(op);
                    if (matchingHashCodes(op))
                    {
                        deletePath.Add(arrlistForFiles[k].ToString());
                        detection++;
                        label2.Invoke((Action)(() => label2.Text = (detection.ToString())));
                    }
                    label3.Invoke((Action)(() => label3.Text = (arrlistForFiles[k].ToString())));
                    int getCalculationOfProgress = arrlistForFiles.Count / 100;
                    if (i > getCalculationOfProgress)
                    {
                        i = 0;
                        p++;
                        BackgroundWorker.ReportProgress(p);
                    }

                    i++;
                   

                }


                tw.WriteLine("Folders are {0} >>>>", p);

                tw.WriteLine("Files are {0}>>>>>>>>>>", NumberOfiles);
                DateTime mp = DateTime.Now;
                var mu = mp.ToString();
                tw.WriteLine(mu);
                tw.Close();
                tw1.Close();


                GC.Collect();
                GC.WaitForPendingFinalizers();

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }



        /// <summary>
        /// Matching The Hash Codes From The HashCodesSapmles
        /// </summary>
        /// <param name="hashcodes"></param>
        /// <returns></returns>
        private bool matchingHashCodes(string hashcodes)
        {
            string firstLetterOfHashCode = hashcodes.Substring(0, 1);
            int sendingLink = (int)Convert.ToChar(firstLetterOfHashCode);
            if (binaryTree.callBtree(sendingLink).Contains(hashcodes)) return true;
            return false;
        }



        /// <summary>
        /// Geting MD5 Hash codes of files (FilePath saved in arraylistForFiles)
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        private string getMD5FromFile(string filepath)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filepath))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();

                }

            }
        }
        private void delete(ArrayList list) {
           
            try
            {
                // access exception 
                foreach (string item in list)
                {
                    File.Delete(item);
                }
            }
            catch (IOException ioExp)
            {
                MessageBox.Show(ioExp.Message);
            }
            catch (UnauthorizedAccessException)
            { 
            
            }
            MessageBox.Show("Done");
        }
    }
}
