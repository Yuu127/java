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

namespace hoatest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            string c = "D:\\java\\";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = $"{c}minhhoa.java {a} {b}";
            startInfo.FileName = "D:\\jdk\\bin\\java.exe";
            try
            {
                Process process = Process.Start(startInfo);
                StreamReader sr = process.StandardOutput;

                this.textBox3.AppendText(sr.ReadToEnd());
            }
            catch (Exception ex)
            {
                this.textBox3.AppendText(ex.Message);
            }
        }

        private void btn_Python_Click(object sender, EventArgs e)
        {
            string msg = this.py_text_box.Text;
            string c = "D:\\java\\";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = c;
            startInfo.Arguments = $"python.py \"{msg}";
            startInfo.FileName = "C:\\Users\\YUU\\AppData\\Local\\Programs\\Python\\Python311\\python.exe";
            try
            {
                Process process = Process.Start(startInfo);
                StreamReader sr = process.StandardOutput;
                this.textBox3.Text = "";
                MessageBox.Show(sr.ReadToEnd());
                this.textBox3.AppendText(sr.ReadToEnd());
            }
            catch (Exception ex)
            {
                this.textBox3.Text = "";
                this.textBox3.AppendText(ex.Message);
            }
        }
    }
}
