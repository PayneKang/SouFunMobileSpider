using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SouFunMobileSpider.Client
{
    public partial class Form1 : Form
    {
        public string InputFile { get { return this.txtInputFile.Text; } set { this.txtInputFile.Text = value; } }
        public string FileContent { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "选择文件";
            file.Filter = "text files (*.txt)|*.txt";
            file.FilterIndex = 1;
            file.RestoreDirectory = true;
            if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.InputFile = file.FileName;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
        }
    }
}
