using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Trifecta
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            //設定
            int interval = 70;
            int bold = 1;

            //ボックスの作成
            Bitmap canvas = new Bitmap(box1.Width, box1.Height);
            Graphics g = Graphics.FromImage(canvas);
            Pen p = new Pen(Color.Black, bold);
            Rectangle[] box = { new Rectangle(0, 0, box1.Height-bold, box1.Height-bold),
                new Rectangle(box1.Height+interval, 0, box1.Height-bold, box1.Height-bold),
                new Rectangle((box1.Height+interval)*2, 0, box1.Height-bold, box1.Height-bold)};
            g.DrawRectangles(p, box);

            //線の作成
            g.DrawLine(Pens.Black, (float)(box1.Height + (interval * 0.25)), box1.Height/2, (float)(box1.Height + (interval * 0.75)), box1.Height / 2);
            g.DrawLine(Pens.Black, (float)(box1.Height*2 + (interval * 1.25)), box1.Height/2, (float)(box1.Height*2 + (interval * 1.75)), box1.Height / 2);

            p.Dispose();
            g.Dispose();
            box1.Image = canvas;
        }

        private void box1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //設定
            int interval = 70;
            int bold = 1;

            if ((0 <= e.X && e.X <= box1.Height - bold )&&( 0 <= e.Y && e.Y <= box1.Height - bold)) //1
            {
                
            }else if ((box1.Height + interval <= e.X && e.X <= box1.Height*2 + interval) && (0 <= e.Y && e.Y <= box1.Height - bold)) //2
            {
                button1.Enabled = false;
            }else if (((box1.Height + interval)*2 <= e.X && e.X <= box1.Height*3 + interval*2) && (0 <= e.Y && e.Y <= box1.Height - bold)) //3
            {
                button2.Enabled = false;
            }
        }
    }
}
