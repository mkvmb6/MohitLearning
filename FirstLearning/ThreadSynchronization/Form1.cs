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

namespace ThreadSynchronization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(LongOperation);
            t.Start();
            //LongOperation();
        }

        private static void LongOperation()
        {
           // Thread.Sleep(5000);
           File.Copy(@"C:\All\MOVIES\Arjun Reddy (2017) Telugu HDRip x264 700MB ESubs.mkv","Nayana.mkv",true);
        }
    }
}
