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
    public partial class Main : Form
    {
        //初期設定
        Boolean locked1 = false;
        Boolean locked2 = false;
        Boolean locked3 = false;

        //設定
        int interval = 70;
        int bold = 1;

        public Main()
        {
            InitializeComponent();
        }

        //初期動作
        private void Main_Load(object sender, EventArgs e)
        {
            ResetPosition();
        }

        //ロック
        private void Box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((0 <= e.X && e.X <= box.Height - bold )&&( 0 <= e.Y && e.Y <= box.Height - bold)) //1
            {
                if (locked1)
                {
                    lock1.Visible = false;
                    locked1 = false;
                }
                else
                {
                    lock1.Visible = true;
                    locked1 = true;
                }
            }else if ((box.Height + interval <= e.X && e.X <= box.Height*2 + interval) && (0 <= e.Y && e.Y <= box.Height - bold)) //2
            {
                if (locked2)
                {
                    lock2.Visible = false;
                    locked2 = false;
                }
                else
                {
                    lock2.Visible = true;
                    locked2 = true;
                }
            }
            else if (((box.Height + interval)*2 <= e.X && e.X <= box.Height*3 + interval*2) && (0 <= e.Y && e.Y <= box.Height - bold)) //3
            {
                if (locked3)
                {
                    lock3.Visible = false;
                    locked3 = false;
                }
                else
                {
                    lock3.Visible = true;
                    locked3 = true;
                }
            }
        }

        //初期位置
        public void ResetPosition()
        {
            //ボックスの作成
            Bitmap canvas = new Bitmap(this.box.Width, this.box.Height);
            Graphics g = Graphics.FromImage(canvas);
            Pen p = new Pen(Color.Black, bold);
            Rectangle[] boxs = { new Rectangle(0, 0, box.Height-bold, box.Height-bold),
                new Rectangle(box.Height+interval, 0, box.Height-bold, box.Height-bold),
                new Rectangle((box.Height+interval)*2, 0, box.Height-bold, box.Height-bold)};
            g.DrawRectangles(p, boxs);

            //線の作成
            g.DrawLine(Pens.Black, (float)(this.box.Height + (interval * 0.25)), this.box.Height / 2, (float)(this.box.Height + (interval * 0.75)), this.box.Height / 2);
            g.DrawLine(Pens.Black, (float)(this.box.Height * 2 + (interval * 1.25)), this.box.Height / 2, (float)(this.box.Height * 2 + (interval * 1.75)), this.box.Height / 2);

            p.Dispose();
            g.Dispose();
            this.box.Image = canvas;

            //ロックの位置調整
            lock1.Location = new Point(box.Location.X + 14, lock1.Location.Y);
            lock2.Location = new Point(box.Location.X + box.Height + interval + 14, lock1.Location.Y);
            lock3.Location = new Point(box.Location.X + (box.Height + interval) * 2 + 14, lock1.Location.Y);
        }
    }
}
