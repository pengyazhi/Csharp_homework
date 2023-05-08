using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_Alarm : Form
    {
        public Frm_Alarm()
        {
            InitializeComponent();
        }

        private void timeNow_Tick(object sender, EventArgs e)
        {
            timeNow.Start();
            labShowTime.Text = DateTime.Now.ToString("hh: mm:ss");
        }

        private void Frm_Alarm_Load(object sender, EventArgs e)
        {
            timeNow_Tick(sender, e);
        }

        string origin;
        private void checkBoxSetTime_CheckedChanged(object sender, EventArgs e)
        {
            origin = maskedTxtBoxSetTime.Mask;
            if (checkBoxSetTime.Checked == true && maskedTxtBoxSetTime.Text != origin)
            {
                MessageBox.Show($"設置了{maskedTxtBoxSetTime.Text}的鬧鐘");
                checkBoxSetTime.Checked = false;
            }
            if (checkBoxSetTime.Checked == true && maskedTxtBoxSetTime.Text == origin)
            {
                MessageBox.Show("請輸入要設定的值");
                checkBoxSetTime.Checked = false;
            }
        }
    }
}
