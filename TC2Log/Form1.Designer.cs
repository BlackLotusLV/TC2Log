namespace TC2Log
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.fps = new System.Windows.Forms.Timer(this.components);
            this.speed = new System.Windows.Forms.Label();
            this.speed2 = new System.Windows.Forms.Label();
            this.speed3 = new System.Windows.Forms.Label();
            this.mxspdlabel = new System.Windows.Forms.Label();
            this.MaxSpd = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.resetMaxSpeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AverageSpdLabel = new System.Windows.Forms.Label();
            this.AVGSpeed = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // fps
            // 
            this.fps.Enabled = true;
            this.fps.Interval = 16;
            this.fps.Tick += new System.EventHandler(this.Fps_Tick);
            // 
            // speed
            // 
            this.speed.AutoSize = true;
            this.speed.Location = new System.Drawing.Point(17, 35);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(10, 13);
            this.speed.TabIndex = 1;
            this.speed.Text = "-";
            // 
            // speed2
            // 
            this.speed2.AutoSize = true;
            this.speed2.Location = new System.Drawing.Point(30, 35);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(10, 13);
            this.speed2.TabIndex = 2;
            this.speed2.Text = "-";
            // 
            // speed3
            // 
            this.speed3.AutoSize = true;
            this.speed3.Location = new System.Drawing.Point(42, 35);
            this.speed3.Name = "speed3";
            this.speed3.Size = new System.Drawing.Size(10, 13);
            this.speed3.TabIndex = 3;
            this.speed3.Text = "-";
            // 
            // mxspdlabel
            // 
            this.mxspdlabel.AutoSize = true;
            this.mxspdlabel.Location = new System.Drawing.Point(5, 57);
            this.mxspdlabel.Name = "mxspdlabel";
            this.mxspdlabel.Size = new System.Drawing.Size(61, 13);
            this.mxspdlabel.TabIndex = 4;
            this.mxspdlabel.Text = "Max Speed";
            // 
            // MaxSpd
            // 
            this.MaxSpd.AutoSize = true;
            this.MaxSpd.Location = new System.Drawing.Point(72, 57);
            this.MaxSpd.Name = "MaxSpd";
            this.MaxSpd.Size = new System.Drawing.Size(10, 13);
            this.MaxSpd.TabIndex = 5;
            this.MaxSpd.Text = "-";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(247, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetMaxSpeedToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(65, 22);
            this.toolStripSplitButton1.Text = "Settings";
            // 
            // resetMaxSpeedToolStripMenuItem
            // 
            this.resetMaxSpeedToolStripMenuItem.Name = "resetMaxSpeedToolStripMenuItem";
            this.resetMaxSpeedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetMaxSpeedToolStripMenuItem.Text = "Reset Max Speed";
            this.resetMaxSpeedToolStripMenuItem.Click += new System.EventHandler(this.ResetMaxSpeedToolStripMenuItem_Click);
            // 
            // AverageSpdLabel
            // 
            this.AverageSpdLabel.AutoSize = true;
            this.AverageSpdLabel.Location = new System.Drawing.Point(5, 81);
            this.AverageSpdLabel.Name = "AverageSpdLabel";
            this.AverageSpdLabel.Size = new System.Drawing.Size(63, 13);
            this.AverageSpdLabel.TabIndex = 7;
            this.AverageSpdLabel.Text = "AVG Speed";
            // 
            // AVGSpeed
            // 
            this.AVGSpeed.AutoSize = true;
            this.AVGSpeed.Location = new System.Drawing.Point(74, 81);
            this.AVGSpeed.Name = "AVGSpeed";
            this.AVGSpeed.Size = new System.Drawing.Size(10, 13);
            this.AVGSpeed.TabIndex = 8;
            this.AVGSpeed.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 148);
            this.Controls.Add(this.AVGSpeed);
            this.Controls.Add(this.AverageSpdLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MaxSpd);
            this.Controls.Add(this.mxspdlabel);
            this.Controls.Add(this.speed3);
            this.Controls.Add(this.speed2);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fps;
        private System.Windows.Forms.Label speed;
        private System.Windows.Forms.Label speed2;
        private System.Windows.Forms.Label speed3;
        private System.Windows.Forms.Label mxspdlabel;
        private System.Windows.Forms.Label MaxSpd;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem resetMaxSpeedToolStripMenuItem;
        private System.Windows.Forms.Label AverageSpdLabel;
        private System.Windows.Forms.Label AVGSpeed;
    }
}

