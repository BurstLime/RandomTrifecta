using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Trifecta
{
    public partial class memo : Form
    {
        public memo()
        {
            InitializeComponent();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if(memo_list.SelectedItems.Count == 1)
            {
                memo_list.Items.RemoveAt(memo_list.SelectedIndex);
            }else if(memo_list.SelectedItems.Count > 1)
            {
                for(int i = 0; i < memo_list.SelectedItems.Count; i++)
                {
                    memo_list.Items.Remove(memo_list.SelectedItems[i]);
                }
            }
            memo_list.SelectedIndex = -1;
        }

        private void memo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("本当にリセットしますか？","確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                memo_list.Items.Clear();
            }
        }
    }
}
