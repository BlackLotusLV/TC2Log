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

namespace TC2Log
{
    public partial class Form1 : Form
    {
        int[,] nr1 = new int[,] { { 103, 967 }, { 116, 944 }, { 91, 944 }, { 103, 944 }, { 103, 936 }, { 103, 954 }, { 92, 950 } };
        int[,] nr2 = new int[,] { { 148, 967 }, { 160, 944 }, { 135, 944 }, { 147, 944 }, { 147, 936 }, { 147, 954 }, { 136, 950 } };
        int[,] nr3 = new int[,] { { 192, 967 }, { 204, 944 }, { 179, 944 }, { 191, 944 }, { 191, 936 }, { 191, 954 }, { 180, 950 } };

        int x;
        int y;

        public Form1()
        {
            x = nr1[6, 0];
            y = nr1[6, 1];

            InitializeComponent();
            this.TopMost = true;
            ChangeColour(x, y);
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(x, y);

        }

        void ChangeColour(int x,int y)
        {
            var title = "TheCrew2";
            var hwnd = FindWindowByCaption(title);
            label1.Text = Win32.GetPixelColor(hwnd, x, y).ToString();
            label1.BackColor = Win32.GetPixelColor(hwnd, x, y);
        }
        bool IsWhite(int x,int y)
        {
            bool iswhite = false;
            var title = "TheCrew2";
            var hwnd = FindWindowByCaption(title);
            Color white = Color.FromArgb(255, 255, 255, 255);
            if (Win32.GetPixelColor(hwnd,x,y)==white)
            {
                iswhite = true;
            }
            return iswhite;
        }

        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
        static extern IntPtr FindWindowByCaption(IntPtr ZeroOnly, string lpWindowName);

        static IntPtr FindWindowByCaption(string caption)
        {
            return FindWindowByCaption(IntPtr.Zero, caption);
        }

        private void Fps_Tick(object sender, EventArgs e)
        {
            UpdateSpeed(speed, nr1);
            UpdateSpeed(speed2, nr2);
            UpdateSpeed(speed3, nr3);
            ChangeColour(x, y);
            int maxspeed, spdcheck;
            int.TryParse(speed.Text + speed2.Text + speed3.Text,out maxspeed);
            int.TryParse(MaxSpd.Text, out spdcheck);
            if (maxspeed>spdcheck)
            {
                MaxSpd.Text = maxspeed.ToString();
            }
        }
        private void UpdateSpeed(Label label, int[,] nr)
        {

            if (IsWhite(nr2[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && IsWhite(nr[2, 0], nr[2, 1]) && !IsWhite(nr[3, 0], nr[3, 1]) && !IsWhite(nr[4, 0], nr[4, 1]) && !IsWhite(nr[5, 0], nr[5, 1]) && IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "0";
            }
            else if (IsWhite(nr[0, 0], nr[0, 1]) && !IsWhite(nr[1, 0], nr[1, 1]) && !IsWhite(nr[2, 0], nr[2, 1]) && IsWhite(nr[3, 0], nr[3, 1]) && IsWhite(nr[4, 0], nr[4, 1]) && IsWhite(nr[5, 0], nr[5, 1]) && !IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "1";
            }
            else if (IsWhite(nr[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && !IsWhite(nr[2, 0], nr[2, 1]) && !IsWhite(nr[3, 0], nr[3, 1]) && !IsWhite(nr[4, 0], nr[4, 1]) && IsWhite(nr[5, 0], nr[5, 1]) && !IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "2";
            }
            else if (IsWhite(nr[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && !IsWhite(nr[2, 0], nr[2, 1]) && IsWhite(nr[3, 0], nr[3, 1]) && IsWhite(nr[4, 0], nr[4, 1]) && !IsWhite(nr[5, 0], nr[5, 1]) && !IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "3";
            }
            else if (!IsWhite(nr[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && IsWhite(nr[2, 0], nr[2, 1]) && !IsWhite(nr[3, 0], nr[3, 1]) && IsWhite(nr[4, 0], nr[4, 1]) && IsWhite(nr[5, 0], nr[5, 1]) && IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "4";
            }
            else if (IsWhite(nr[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && IsWhite(nr[2, 0], nr[2, 1]) && IsWhite(nr[3, 0], nr[3, 1]) && !IsWhite(nr[4, 0], nr[4, 1]) && !IsWhite(nr[5, 0], nr[5, 1]) && !IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "5";
            }
            else if (IsWhite(nr[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && IsWhite(nr[2, 0], nr[2, 1]) && IsWhite(nr[3, 0], nr[3, 1]) && IsWhite(nr[4, 0], nr[4, 1]) && !IsWhite(nr[5, 0], nr[5, 1]) && IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "6";
            }
            else if (!IsWhite(nr[0, 0], nr[0, 1]) && !IsWhite(nr[1, 0], nr[1, 1]) && !IsWhite(nr[2, 0], nr[2, 1]) && IsWhite(nr[3, 0], nr[3, 1]) && !IsWhite(nr[4, 0], nr[4, 1]) && IsWhite(nr[5, 0], nr[5, 1]) && !IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "7";
            }
            else if (IsWhite(nr[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && IsWhite(nr[2, 0], nr[2, 1]) && IsWhite(nr[3, 0], nr[3, 1]) && !IsWhite(nr[4, 0], nr[4, 1]) && !IsWhite(nr[5, 0], nr[5, 1]) && IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "8";
            }
            else if (IsWhite(nr[0, 0], nr[0, 1]) && IsWhite(nr[1, 0], nr[1, 1]) && IsWhite(nr[2, 0], nr[2, 1]) && IsWhite(nr[3, 0], nr[3, 1]) && !IsWhite(nr[4, 0], nr[4, 1]) && IsWhite(nr[5, 0], nr[5, 1]) && IsWhite(nr[6, 0], nr[6, 1]))
            {
                label.Text = "9";
            }
            else
            {
                label.Text = "-";
            }
        }

        private void ResetMaxSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaxSpd.Text = "-";
        }
    }
}
