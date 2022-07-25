using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           await Task.Run(DownloadFile);
            MessageBox.Show("Download complete");
        }

        public static void DownloadFile()
        {
            //simulating delay!
            Console.Beep(500, 5000);
        }

        }
    }

