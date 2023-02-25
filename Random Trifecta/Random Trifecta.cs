using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        memo Memo = new memo();

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
            //設定読み込み
            this.TopMost = Properties.Settings.Default.topmost;
            if (Properties.Settings.Default.value)
            {
                value.Value = Properties.Settings.Default.before_num;
            }
            else
            {
                value.Value = Properties.Settings.Default.reset_num;
            }
            ResetPosition();
            LoadValue();
        }

        //リストの選択解除
        private void Main_MouseClick(object sender, MouseEventArgs e)
        {
            list.SelectedIndex = -1;
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
            lock1.Location = new Point(box.Location.X + 14, box.Height-75);
            lock2.Location = new Point(box.Location.X + box.Height + interval + 14, box.Height - 75);
            lock3.Location = new Point(box.Location.X + (box.Height + interval) * 2 + 14, box.Height - 75);

            //ラベルの透明化
            num1.Parent = box;
            num1.Location -= (Size)box.Location;
            num2.Parent = box;
            num2.Location -= (Size)box.Location;
            num3.Parent = box;
            num3.Location -= (Size)box.Location;
        }

        //馬数の読み込み
        public void LoadValue()
        {
            list.Items.Clear();

            for (int i = 1; i < value.Value+1; i++)
            {
                if (locked1&&num1.Text==i.ToString())
                {
                }else if(locked2 && num2.Text == i.ToString())
                {
                }else if (locked3 && num3.Text == i.ToString())
                {
                }
                else
                {
                    list.Items.Add(i);
                }
            }
        }

        private void value_ValueChanged(object sender, EventArgs e)
        {
            LoadValue();
            Properties.Settings.Default.before_num = (int)value.Value;
            Properties.Settings.Default.Save();
        }

        private void generate_Click(object sender, EventArgs e)
        {
            list.SelectedIndex = -1;
            num1.Visible = true;
            num2.Visible = true;
            num3.Visible = true;
            int inx1;
            int inx2;
            int inx3;
            System.Random r = new System.Random();
            List<string> num_list = new List<string>();
            List<string> no_checked = new List<string>();
            num_list.Clear();

            //ロックシステム
            int locked_num = 0;
            if (locked1) { locked_num++; }
            if (locked2) { locked_num++; }
            if (locked3) { locked_num++; }
            if (locked_num == 3) { return; }

            //処理落ち回避
            if(value.Value == 4 && locked_num == 2 && list.CheckedItems.Count == 0)
            {
                inx1 = r.Next(list.Items.Count);
                if (locked1 && locked2)
                {
                    num3.Text = list.Items[inx1].ToString();
                }else if(locked1 && locked3)
                {
                    num2.Text = list.Items[inx1].ToString();
                }else if (locked2 && locked3)
                {
                    num1.Text = list.Items[inx1].ToString();
                }
                return;
            }
            else if(value.Value == 3 && locked_num == 2 && list.CheckedItems.Count == 0)
            {
                if (locked1 && locked2)
                {
                    num3.Text = list.Items[0].ToString();
                }
                else if (locked1 && locked3)
                {
                    num2.Text = list.Items[0].ToString();
                }
                else if (locked2 && locked3)
                {
                    num1.Text = list.Items[0].ToString();
                }
                return;
            }

            //ロックパターン
            //XOO
            if (locked1 && !locked2 && !locked3 && 0 < list.CheckedItems.Count)
            {
                //チェック1
                if (list.CheckedItems.Count == 1)
                {
                    num_list.Add(list.CheckedItems[0].ToString());
                    no_checked = no_check_list();
                    num_list.Add(no_checked[r.Next(no_checked.Count)]);

                    inx1 = r.Next(2);
                    inx2 = r.Next(2);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(2);
                    }
                    num2.Text = num_list[inx1].ToString();
                    num3.Text = num_list[inx2].ToString();
                    return;
                }
                else if(list.CheckedItems.Count == 2) //チェック2
                {
                    num_list.Add(list.CheckedItems[0].ToString());
                    num_list.Add(list.CheckedItems[1].ToString());
                    inx1 = r.Next(2);
                    inx2 = r.Next(2);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(2);
                    }
                    num2.Text = num_list[inx1].ToString();
                    num3.Text = num_list[inx2].ToString();
                    return;
                }
                else //チェック3以上
                {
                    inx1 = r.Next(list.CheckedItems.Count);
                    inx2 = r.Next(list.CheckedItems.Count);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(list.CheckedItems.Count);
                    }
                    num2.Text = list.CheckedItems[inx1].ToString();
                    num3.Text = list.CheckedItems[inx2].ToString();
                    return;
                }
            }
            //XXO
            else if (locked1 && locked2 && !locked3 && 0 < list.CheckedItems.Count)
            {
                //チェック1
                if(list.CheckedItems.Count == 1)
                {
                    num3.Text = list.CheckedItems[0].ToString();
                    return;
                }
                else //チェック2以上
                {
                    inx1 = r.Next(list.CheckedItems.Count);
                    num3.Text = list.CheckedItems[inx1].ToString();
                    return;
                }
            }
            //XOX
            else if (locked1 && !locked2 && locked3 && 0 < list.CheckedItems.Count)
            {
                //チェック1
                if (list.CheckedItems.Count == 1)
                {
                    num2.Text = list.CheckedItems[0].ToString();
                    return;
                }
                else //チェック2以上
                {
                    inx1 = r.Next(list.CheckedItems.Count);
                    num2.Text = list.CheckedItems[inx1].ToString();
                    return;
                }
            }
            //OXO
            else if (!locked1 && locked2 && !locked3 && 0 < list.CheckedItems.Count)
            {
                //チェック1
                if (list.CheckedItems.Count == 1)
                {
                    num_list.Add(list.CheckedItems[0].ToString());
                    no_checked = no_check_list();
                    num_list.Add(no_checked[r.Next(no_checked.Count)]);

                    inx1 = r.Next(2);
                    inx2 = r.Next(2);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(2);
                    }
                    num1.Text = num_list[inx1].ToString();
                    num3.Text = num_list[inx2].ToString();
                    return;
                }
                else if (list.CheckedItems.Count == 2) //チェック2
                {
                    num_list.Add(list.CheckedItems[0].ToString());
                    num_list.Add(list.CheckedItems[1].ToString());
                    inx1 = r.Next(2);
                    inx2 = r.Next(2);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(2);
                    }
                    num1.Text = num_list[inx1].ToString();
                    num3.Text = num_list[inx2].ToString();
                    return;
                }
                else //チェック3以上
                {
                    inx1 = r.Next(list.CheckedItems.Count);
                    inx2 = r.Next(list.CheckedItems.Count);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(list.CheckedItems.Count);
                    }
                    num1.Text = list.CheckedItems[inx1].ToString();
                    num3.Text = list.CheckedItems[inx2].ToString();
                    return;
                }
            }
            //OXX
            else if(!locked1 && locked2 && locked3 && 0 < list.CheckedItems.Count)
            {
                //チェック1
                if (list.CheckedItems.Count == 1)
                {
                    num1.Text = list.CheckedItems[0].ToString();
                    return;
                }
                else //チェック2以上
                {
                    inx1 = r.Next(list.CheckedItems.Count);
                    num1.Text = list.CheckedItems[inx1].ToString();
                    return;
                }
            }
            //OOX
            else if (!locked1 && !locked2 && locked3 && 0 < list.CheckedItems.Count)
            {
                //チェック1
                if (list.CheckedItems.Count == 1)
                {
                    num_list.Add(list.CheckedItems[0].ToString());
                    no_checked = no_check_list();
                    num_list.Add(no_checked[r.Next(no_checked.Count)]);

                    inx1 = r.Next(2);
                    inx2 = r.Next(2);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(2);
                    }
                    num1.Text = num_list[inx1].ToString();
                    num2.Text = num_list[inx2].ToString();
                    return;
                }
                else if (list.CheckedItems.Count == 2) //チェック2
                {
                    num_list.Add(list.CheckedItems[0].ToString());
                    num_list.Add(list.CheckedItems[1].ToString());
                    inx1 = r.Next(2);
                    inx2 = r.Next(2);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(2);
                    }
                    num1.Text = num_list[inx1].ToString();
                    num2.Text = num_list[inx2].ToString();
                    return;
                }
                else //チェック3以上
                {
                    inx1 = r.Next(list.CheckedItems.Count);
                    inx2 = r.Next(list.CheckedItems.Count);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(list.CheckedItems.Count);
                    }
                    num1.Text = list.CheckedItems[inx1].ToString();
                    num2.Text = list.CheckedItems[inx2].ToString();
                    return;
                }
            }

            if (list.CheckedItems.Count == 0) //全部チェックされていないとき
            {
                inx1 = r.Next(list.Items.Count);
                inx2 = r.Next(list.Items.Count);
                while (inx1 == inx2){
                    inx2 = r.Next(list.Items.Count);
                }
                inx3 = r.Next(list.Items.Count);
                while (inx1 == inx3||inx2 == inx3)
                {
                    inx3 = r.Next(list.Items.Count);
                }

                for(int i = 0; i < list.Items.Count; i++)
                {
                    list.SetItemChecked(i, true);
                }
                for(int i = 0; i < list.CheckedItems.Count; i++)
                {
                    num_list.Add(list.CheckedItems[i].ToString());
                }
                for (int i = 0; i < list.Items.Count; i++)
                {
                    list.SetItemChecked(i, false);
                }

            }else if (list.CheckedItems.Count == list.Items.Count) //全部チェックされているとき
            {
                inx1 = r.Next(list.CheckedItems.Count);
                inx2 = r.Next(list.CheckedItems.Count);
                while (inx1 == inx2)
                {
                    inx2 = r.Next(list.CheckedItems.Count);
                }
                inx3 = r.Next(list.CheckedItems.Count);
                while (inx1 == inx3 || inx2 == inx3)
                {
                    inx3 = r.Next(list.CheckedItems.Count);
                }

            }else if (3 <= list.CheckedItems.Count) //チェックが3以上のとき
            {
                inx1 = r.Next(list.CheckedItems.Count);
                inx2 = r.Next(list.CheckedItems.Count);
                while (inx1 == inx2)
                {
                    inx2 = r.Next(list.CheckedItems.Count);
                }
                inx3 = r.Next(list.CheckedItems.Count);
                while (inx1 == inx3 || inx2 == inx3)
                {
                    inx3 = r.Next(list.CheckedItems.Count);
                }
            }else if (1<=list.CheckedItems.Count&& list.CheckedItems.Count< 3) //チェックが1以上3未満のとき
            {
                if(list.CheckedItems.Count == 1)
                {
                    int before_checked = list.CheckedIndices[0];
                    num_list.Add(list.CheckedItems[0].ToString());

                    for (int i = 0; i < list.Items.Count; i++)
                    {
                        list.SetItemChecked(i, true);
                    }
                    for (int i = 0; i < list.CheckedItems.Count; i++)
                    {
                        no_checked.Add(list.CheckedItems[i].ToString());
                    }
                    for (int i = 0; i < list.Items.Count; i++)
                    {
                        list.SetItemChecked(i, false);
                    }
                    no_checked.Remove(num_list[0].ToString());
                    list.SetItemChecked(before_checked, true);

                    inx1 = r.Next(no_checked.Count);
                    while (inx1 == (int)list.CheckedItems[0])
                    {
                        inx1 = r.Next(no_checked.Count);
                    }
                    inx2 = r.Next(no_checked.Count);
                    while (inx1==inx2||inx2 == (int)list.CheckedItems[0])
                    {
                        inx2 = r.Next(no_checked.Count);
                    }
                    num_list.Add(no_checked[inx1].ToString());
                    num_list.Add(no_checked[inx2].ToString());

                    inx1 = r.Next(num_list.Count);
                    inx2 = r.Next(num_list.Count);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(num_list.Count);
                    }
                    inx3 = r.Next(num_list.Count);
                    while (inx1 == inx3 || inx2 == inx3)
                    {
                        inx3 = r.Next(num_list.Count);
                    }
                }else
                {
                    int before_checked1 = list.CheckedIndices[0];
                    int before_checked2 = list.CheckedIndices[1];
                    num_list.Add(list.CheckedItems[0].ToString());
                    num_list.Add(list.CheckedItems[1].ToString());

                    for (int i = 0; i < list.Items.Count; i++)
                    {
                        list.SetItemChecked(i, true);
                    }
                    for (int i = 0; i < list.CheckedItems.Count; i++)
                    {
                        no_checked.Add(list.CheckedItems[i].ToString());
                    }
                    for (int i = 0; i < list.Items.Count; i++)
                    {
                        list.SetItemChecked(i, false);
                    }
                    no_checked.Remove(num_list[0].ToString());
                    list.SetItemChecked(before_checked1, true);
                    no_checked.Remove(num_list[1].ToString());
                    list.SetItemChecked(before_checked2, true);

                    inx1 = r.Next(no_checked.Count);
                    while (inx1 == (int)list.CheckedItems[0]||inx1 == (int)list.CheckedItems[1])
                    {
                        inx1 = r.Next(no_checked.Count);
                    }
                    num_list.Add(no_checked[inx1].ToString());

                    inx1 = r.Next(num_list.Count);
                    inx2 = r.Next(num_list.Count);
                    while (inx1 == inx2)
                    {
                        inx2 = r.Next(num_list.Count);
                    }
                    inx3 = r.Next(num_list.Count);
                    while (inx1 == inx3 || inx2 == inx3)
                    {
                        inx3 = r.Next(num_list.Count);
                    }
                }
            }
            else
            {
                inx1 = 0;
                inx2 = 0;
                inx3 = 0;
            }

            if (list.CheckedItems.Count == 0)
            {
                if (!locked1) { num1.Text = num_list[inx1].ToString(); }
                if (!locked2) { num2.Text = num_list[inx2].ToString(); }
                if (!locked3) { num3.Text = num_list[inx3].ToString(); }
            }else if (list.CheckedItems.Count == 1 || list.CheckedItems.Count == 2)
            {
                num1.Text = num_list[inx1].ToString();
                num2.Text = num_list[inx2].ToString();
                num3.Text = num_list[inx3].ToString();
            }
            else if(list.CheckedItems.Count == list.Items.Count)
            {
                if (!locked1) { num1.Text = list.CheckedItems[inx1].ToString(); }
                if (!locked2) { num2.Text = list.CheckedItems[inx2].ToString(); }
                if (!locked3) { num3.Text = list.CheckedItems[inx3].ToString(); }
            }else if(3 <= list.CheckedItems.Count)
            {
                num1.Text = list.CheckedItems[inx1].ToString();
                num2.Text = list.CheckedItems[inx2].ToString();
                num3.Text = list.CheckedItems[inx3].ToString();
            }

            num1.Visible = true; num2.Visible = true; num3.Visible = true;
        }



        //ロック（数字が入ってないとき）
        private void Box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if ((0 <= e.X && e.X <= box.Height - bold) && (0 <= e.Y && e.Y <= box.Height - bold)) //1
            {
                if (locked1)
                {
                    num1.Visible = false;
                    lock1.Visible = false;
                    locked1 = false;
                }
                else
                {
                    if (list.SelectedIndex != -1)
                    {
                        num1.Text = list.SelectedItem.ToString();
                        num1.Visible = true;
                        lock1.Visible = true;
                        locked1 = true;
                        list.Items.Remove(list.SelectedItem);
                    }
                }
            }
            else if ((box.Height + interval <= e.X && e.X <= box.Height * 2 + interval) && (0 <= e.Y && e.Y <= box.Height - bold)) //2
            {
                if (locked2)
                {
                    lock2.Visible = false;
                    locked2 = false;
                }
                else
                {
                    if (list.SelectedIndex != -1)
                    {
                        num2.Text = list.SelectedItem.ToString();
                        num2.Visible = true;
                        lock2.Visible = true;
                        locked2 = true;
                        list.Items.Remove(list.SelectedItem);
                    }
                }
            }
            else if (((box.Height + interval) * 2 <= e.X && e.X <= box.Height * 3 + interval * 2) && (0 <= e.Y && e.Y <= box.Height - bold)) //3
            {
                if (locked3)
                {
                    lock3.Visible = false;
                    locked3 = false;
                }
                else
                {
                    if (list.SelectedIndex != -1)
                    {
                        num3.Text = list.SelectedItem.ToString();
                        num3.Visible = true;
                        lock3.Visible = true;
                        locked3 = true;
                        list.Items.Remove(list.SelectedItem);
                    }
                }
            }
        }
        //ロック（数字が入ってるとき）
        private void num1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (locked1)
            {
                if (list.SelectedIndex != -1)
                {
                    num1.Text = list.SelectedItem.ToString();
                    list.Items.Remove(list.SelectedItem);
                    LoadValue();
                    return;
                }
                lock1.Visible = false;
                locked1 = false;
                LoadValue();
            }
            else
            {
                if (list.SelectedIndex != -1)
                {
                    num1.Text = list.SelectedItem.ToString();
                    list.Items.Remove(list.SelectedItem);
                }
                else
                {
                    locked1 = true;
                    LoadValue();
                }
                lock1.Visible = true;
                locked1 = true;
            }
        }
        private void num2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (locked2)
            {
                if (list.SelectedIndex != -1)
                {
                    num2.Text = list.SelectedItem.ToString();
                    list.Items.Remove(list.SelectedItem);
                    LoadValue();
                    return;
                }
                lock2.Visible = false;
                locked2 = false;
                LoadValue();
            }
            else
            {
                if (list.SelectedIndex != -1)
                {
                    num2.Text = list.SelectedItem.ToString();
                    list.Items.Remove(list.SelectedItem);
                }
                else
                {
                    locked2 = true;
                    LoadValue();
                }
                lock2.Visible = true;
                locked2 = true;
            }
        }
        private void num3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (locked3)
            {
                if (list.SelectedIndex != -1)
                {
                    num3.Text = list.SelectedItem.ToString();
                    list.Items.Remove(list.SelectedItem);
                    LoadValue();
                    return;
                }
                lock3.Visible = false;
                locked3 = false;
                LoadValue();
            }
            else
            {
                if (list.SelectedIndex != -1)
                {
                    num3.Text = list.SelectedItem.ToString();
                    list.Items.Remove(list.SelectedItem);
                }
                else
                {
                    locked3 = true;
                    LoadValue();
                }
                lock3.Visible = true;
                locked3 = true;
            }
        }

        public List<string> no_check_list()
        {
            List<string> no_checked = new List<string>();

            int before_checked = list.CheckedIndices[0];

            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SetItemChecked(i, true);
            }
            for (int i = 0; i < list.CheckedItems.Count; i++)
            {
                no_checked.Add(list.CheckedItems[i].ToString());
            }
            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SetItemChecked(i, false);
            }
            no_checked.RemoveAt(before_checked);
            list.SetItemChecked(before_checked, true);
            return no_checked;
        }

        private void select_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < list.Items.Count; i++)
            {
                list.SetItemChecked(i, true);
            }
        }

        private void lift_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SetItemChecked(i, false);
            }
        }

        private void setting_button_Click(object sender, EventArgs e)
        {
            setting setting = new setting();
            setting.ShowDialog();
        }

        private void Memo_Click(object sender, EventArgs e)
        {
            Memo.Show();
        }

        private void memo_button_Click(object sender, EventArgs e)
        {
            if(num1.Text.Length!=0 && num2.Text.Length != 0 && num3.Text.Length != 0)
            {
                string num1_m;
                string num2_m;
                string num3_m;

                if (num1.Text.Length == 1){num1_m = "0"+num1.Text;}
                else{num1_m = num1.Text;}

                if (num2.Text.Length == 1) { num2_m = "0" + num2.Text; }
                else { num2_m = num2.Text; }

                if (num3.Text.Length == 1) { num3_m = "0" + num3.Text; }
                else { num3_m = num3.Text; }

                Memo.memo_list.Items.Add(num1_m + "-" + num2_m + "-" + num3_m);
            }
        }
    }
}
