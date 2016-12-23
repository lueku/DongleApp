using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DongleApp2._0
{
    public partial class Form1 : Form
    {
        private OverlayForm _overlay;

        public Form1()
        {
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            InitializeComponent();
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.None;
            _overlay = new OverlayForm();
            _overlay.Location = new Point(screenLeft, screenTop);
            _overlay.StartPosition = FormStartPosition.Manual;
            _overlay.Show();
        }
    }

    public class OverlayForm : Form
    {
        public OverlayForm()
        {
            int screenLeft = SystemInformation.VirtualScreen.Left;
            int screenTop = SystemInformation.VirtualScreen.Top;
            int screenWidth = SystemInformation.VirtualScreen.Width;
            int screenHeight = SystemInformation.VirtualScreen.Height;

            TopMost = true;
            ShowInTaskbar = false;
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Black;

            Location = new Point(0, 0);
            Width = screenWidth;
            Height = screenHeight;

            Cursor.Hide();

            System.Timers.Timer t = new System.Timers.Timer();
            t.Elapsed += new System.Timers.ElapsedEventHandler(timer_tick);
            t.Interval = 500;
            t.Start();
        }

        private void timer_tick(object s, ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.AddImage));
            }
        }

        public void AddImage()
        {
            Bitmap b = Properties.Resources.accessdenied;
            Random r = new Random();
            PictureBox pb = new PictureBox();
            pb.Image = b;
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.Size = b.Size;
            pb.Location = new Point(r.Next(this.Width), r.Next(this.Height));
            pb.Show();
            this.Controls.Add(pb);
        }


        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Environment.Exit(0);
            //Application.Restart();
        }
    }
}
