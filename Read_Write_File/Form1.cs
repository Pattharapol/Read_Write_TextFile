using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Read_Write_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Temp\config.txt";
            StreamWriter sw = new StreamWriter(filename);
            sw.WriteLine(txtServer.Text);
            sw.WriteLine(txtUSer.Text);
            sw.WriteLine(txtPass.Text);
            sw.WriteLine(txtDB.Text);
            sw.Close();
            Process.Start(@"C:\Temp\config.txt");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string filename = @"C:\Temp\config.txt";
            string[] lines = File.ReadAllLines(filename, Encoding.UTF8);
            txtServer.Text = lines[0];
            txtUSer.Text = lines[1];
            txtPass.Text = lines[2];
            txtDB.Text = lines[3];
        }
    }
}
