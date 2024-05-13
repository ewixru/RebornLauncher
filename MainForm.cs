//This file is part of the Requiem reborn project. (c) ewix 2024
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RebornLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        //Global variables for Moving a Borderless Form
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Application.StartupPath + "/system/requiem.exe";
                proc.StartInfo.Arguments = "128.241.93.138 -FromLauncher 0/0 0 0 1 3 0";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc.Start();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n/system/requiem.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Application.StartupPath + "/system/requiem.exe";
                proc.StartInfo.Arguments = "45.91.8.172 -FromLauncher 0/0 0 0 1 3 0";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc.Start();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n/system/requiem.exe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = Application.StartupPath + "/UPDATERUSA.EXE";
                proc.StartInfo.Arguments = "";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                proc.Start();
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nUPDATERUSA.EXE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
