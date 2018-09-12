using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFileCopier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = true;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult==DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnBrowseDestination_Click(object sender, EventArgs e)
        {
            var dialogResult = folderBrowserDialog1.ShowDialog();
            if (dialogResult==DialogResult.OK)
            {
                txtDestination.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //Thread thread = new Thread(CopyFile);
           // thread.Start();

            // CopyFile();

            Task task=new Task(CopyFile);
            task.Start();
            task.ContinueWith(t=> {ShowMessage();});
            //ShowMessage();
        }

        private void ShowMessage()
        {
            MessageBox.Show("Download Completed");
        }

      

        private void CopyFile()
        {
            var fileToCopy = txtFilePath.Text;
            var destinationFile = Path.Combine(txtDestination.Text, Path.GetFileName(fileToCopy));

            var buffer = new byte[1024 * 1024];// 1mb buffer
            using (FileStream sourceFile = new FileStream(fileToCopy, FileMode.Open, FileAccess.Read))
            {
                long fileLength = sourceFile.Length;

                using (FileStream destination = new FileStream(destinationFile, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    long totalBytes = 0;
                    int blockSize = 0;
                    var percentage = 0;
                    Thread.Sleep(50);
                    while ((blockSize = sourceFile.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destination.Write(buffer, 0, blockSize);
                        totalBytes += blockSize;
                        percentage = (int)(totalBytes / fileLength * 100);
                        progressBar1.Invoke(new Action(()=> {
                            progressBar1.Value = percentage;//Form elements are modified here
                            lblUpdate.Text =
                                totalBytes +"/" 
                                +fileLength; //Form elements are modified here

                        }));

                       // progressBar1.Value = percentage;//Form elements are modified here
                       // lblUpdate.Text = totalBytes.ToString();//Form elements are modified here
                       
                    }
                }
            }
        }
        
    }
}

