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
    public partial class setting : Form
    {
        Main main = new Main();

        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.topmost)
            {
                Top.Checked = true;
            }
            else
            {
                Top.Checked = false;
            }

            if (Properties.Settings.Default.topmost_memo)
            {
                Top_memo.Checked = true;
            }
            else
            {
                Top_memo.Checked = false;
            }

            if (Properties.Settings.Default.value)
            {
                value_save.Checked = true;
                value_reset.Checked = false;
                reset_num.Enabled = false;
            }
            else
            {
                value_save.Checked = false;
                value_reset.Checked = true;
                reset_num.Enabled = true;
                reset_num.Value = Properties.Settings.Default.reset_num;
            }
        }

        private void value_save_CheckedChanged(object sender, EventArgs e)
        {
            reset_num.Enabled = false;
        }

        private void value_reset_CheckedChanged(object sender, EventArgs e)
        {
            reset_num.Enabled = true;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            if (Top.Checked)
            {
                Properties.Settings.Default.topmost = true;
            }
            else
            {
                Properties.Settings.Default.topmost = false;
            }

            if (Top_memo.Checked)
            {
                Properties.Settings.Default.topmost_memo = true;
            }
            else
            {
                Properties.Settings.Default.topmost_memo = false;
            }

            if (value_save.Checked)
            {
                Properties.Settings.Default.value = true;
            }
            else
            {
                Properties.Settings.Default.value = false;
                Properties.Settings.Default.reset_num = (int)reset_num.Value;
            }
            Properties.Settings.Default.Save();
        }

    }
}
