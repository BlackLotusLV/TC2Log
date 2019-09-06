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
        int[,] Bold = new int[,] { { 0, 0 }, { 13, 0 }, { 26, 0 }, { 0, 13 }, { 13, 13 }, { 26, 13 }, { 0, 24 }, { 13, 26 }, { 24, -13 } };
        int[,] CarSpeedLoc = { { 92, 940 }, { 136, 940 }, { 180, 940 } };

        int x;
        int y;

        public Form1()
        {
            x = Bold[6,0]+136;
            y = Bold[6, 1]+940;

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
            label2.Text = Win32.GetPixelColor(hwnd, x, y).ToString();
            label2.BackColor = Win32.GetPixelColor(hwnd, x, y);
        }
        bool IsWhite(int x,int y)
        {
            bool iswhite = false;
            var title = "TheCrew2";
            var hwnd = FindWindowByCaption(title);
            Color white = Color.FromArgb(255, 255, 255, 255);
            Color white2 = Color.FromArgb(255, 250, 250, 250);
            Color pixel = Win32.GetPixelColor(hwnd, x, y);
            if ((pixel.R <= white.R && pixel.R >= white2.R)&& (pixel.G <= white.G && pixel.G >= white2.G)&& (pixel.B <= white.B && pixel.B >= white2.B))
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
            speed.Text = GetBoldNumber(CarSpeedLoc[0,0], CarSpeedLoc[0, 1]);
            speed2.Text = GetBoldNumber(CarSpeedLoc[1, 0], CarSpeedLoc[1, 1]);
            speed3.Text = GetBoldNumber(CarSpeedLoc[2, 0], CarSpeedLoc[2, 1]);
            ChangeColour(x, y);
            int maxspeed, spdcheck;
            int.TryParse(speed.Text + speed2.Text + speed3.Text,out maxspeed);
            int.TryParse(MaxSpd.Text, out spdcheck);
            if (maxspeed>spdcheck)
            {
                MaxSpd.Text = maxspeed.ToString();
            }
        }

        private string GetBoldNumber(int x,int y)
        {
            string number="-";
            if (IsWhite(Bold[1, 0]+x, Bold[1, 1]+y) && IsWhite(Bold[4, 0]+x, Bold[4, 1]+y) && IsWhite(Bold[7, 0]+x, Bold[7, 1]+y))
            {
                number = "1";
            }
            else if (!IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && !IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && !IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && !IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "2";
            }
            else if (!IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && !IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && !IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && !IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "3";
            }
            else if (IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && !IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && !IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && !IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && !IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && !IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "4";
            }
            else if (IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && !IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && !IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && !IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "5";
            }
            else if (IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && !IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && !IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && !IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "6";
            }
            else if (!IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && !IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && !IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && !IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && !IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "7";
            }
            else if (IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && !IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && !IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "8";
            }
            else if (IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && !IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && !IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && !IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && !IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "9";
            }
            else if (IsWhite(Bold[0, 0] + x, Bold[0, 1] + y) && !IsWhite(Bold[1, 0] + x, Bold[1, 1] + y) && IsWhite(Bold[2, 0] + x, Bold[2, 1] + y) && IsWhite(Bold[3, 0] + x, Bold[3, 1] + y) && !IsWhite(Bold[4, 0] + x, Bold[4, 1] + y) && IsWhite(Bold[5, 0] + x, Bold[5, 1] + y) && IsWhite(Bold[6, 0] + x, Bold[6, 1] + y) && IsWhite(Bold[7, 0] + x, Bold[7, 1] + y) && IsWhite(Bold[8, 0] + x, Bold[8, 1] + y))
            {
                number = "0";
            }
            return number;
        }

        private void ResetMaxSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MaxSpd.Text = "-";
        }
    }
}
