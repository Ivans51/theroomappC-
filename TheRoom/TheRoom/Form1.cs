using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TheRoom
{
    public partial class Form1 : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://giss.tv:8000/TheRoomMusic.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://giss.tv:8000/TheRoomMusic.mp3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000, "theroom", "sonando music", ToolTipIcon.Info);
            Hide();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.ShowBalloonTip(5000, "theroom", "sonando music", ToolTipIcon.Info);
            Show();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.settings.volume = trackBar1.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://giss.tv:8000/TheRoomMusic.mp3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://giss.tv:8001/TheRoomMusic.mp3";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://theroom.net.ve/");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
