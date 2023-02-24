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
            lock1.Location = new Point(box.Location.X + 14, lock1.Location.Y);
            lock2.Location = new Point(box.Location.X + box.Height + interval + 14, lock1.Location.Y);
            lock3.Location = new Point(box.Location.X + (box.Height + interval) * 2 + 14, lock1.Location.Y);

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
            for(int i = 1; i < value.Value+1; i++)
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
        }

        private void generate_Click(object sender, EventArgs e)
        {
            int inx1;
            int inx2;
            int inx3;
            System.Random r = new System.Random();
            List<string> num_list = new List<string>();
            num_list.Clear();

            //ロックシステム
            int locked_num = 0;
            if (locked1) { locked_num++; }
            if (locked2) { locked_num++; }
            if (locked3) { locked_num++; }
            if (locked_num == 3) { return; }


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
                List<string> no_checked = new List<string>();
                if(list.CheckedItems.Count == 1)
                {
                    //ロック
                    if(locked_num == 2)
                    {
                        if (!locked1) { num1.Text = list.CheckedItems[0].ToString();}
                        else if (!locked2) { num2.Text = list.CheckedItems[0].ToString(); }
                        else if (!locked3) { num3.Text = list.CheckedItems[0].ToString(); }
                        return;
                    }
                    else if(locked_num == 1) //1
                    {
                        if (locked1) 
                        {
                            int before_checked_l1 = list.CheckedIndices[0]; //ここ
                            num_list.Add(num1.Text.ToString()); //ここ
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
                            no_checked.Remove(num_list[1].ToString()); //ここ
                            list.SetItemChecked(before_checked_l1, true);

                            inx2 = r.Next(no_checked.Count);
                            while (inx2 == (int)list.CheckedItems[0])
                            {
                                inx2 = r.Next(no_checked.Count);
                            }
                            num_list.Add(no_checked[inx2].ToString());
                            inx1 = 0;
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
                        else if (locked2) 
                        {
                            int before_checked_l2 = list.CheckedIndices[0]; //ここ
                            num_list.Add(num2.Text.ToString()); //ここ
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
                            no_checked.Remove(num_list[1].ToString()); //ここ
                            list.SetItemChecked(before_checked_l2, true);

                            inx2 = r.Next(no_checked.Count);
                            while (inx2 == (int)list.CheckedItems[0])
                            {
                                inx2 = r.Next(no_checked.Count);
                            }
                            num_list.Add(no_checked[inx2].ToString());
                            inx2 = 0;
                            inx1 = r.Next(num_list.Count);
                            while (inx1 == inx2)
                            {
                                inx1 = r.Next(num_list.Count);
                            }
                            inx3 = r.Next(num_list.Count);
                            while (inx1 == inx3 || inx2 == inx3)
                            {
                                inx3 = r.Next(num_list.Count);
                            }
                        }
                        else if (locked3) 
                        {
                            int before_checked_l3 = list.CheckedIndices[0]; //ここ
                            num_list.Add(num3.Text.ToString()); //ここ
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
                            no_checked.Remove(num_list[1].ToString()); //ここ
                            list.SetItemChecked(before_checked_l3, true);

                            inx2 = r.Next(no_checked.Count);
                            while (inx2 == (int)list.CheckedItems[0])
                            {
                                inx2 = r.Next(no_checked.Count);
                            }
                            num_list.Add(no_checked[inx2].ToString());
                            inx3 = 0;
                            inx1 = r.Next(num_list.Count);
                            while (inx3 == inx1)
                            {
                                inx1 = r.Next(num_list.Count);
                            }
                            inx2 = r.Next(num_list.Count);
                            while (inx2 == inx3 || inx2 == inx1)
                            {
                                inx2 = r.Next(num_list.Count);
                            }
                        }
                        else
                        {
                            inx1 = 0;
                            inx2 = 0;
                            inx3 = 0;
                        }

                        num1.Text = num_list[inx1].ToString();
                        num2.Text = num_list[inx2].ToString();
                        num3.Text = num_list[inx3].ToString();
                        return;
                    }

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
            else if(list.CheckedItems.Count == list.Items.Count || 3 <= list.CheckedItems.Count)
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
    }
}
