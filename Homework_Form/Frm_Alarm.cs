using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            labShowTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void Frm_Alarm_Load(object sender, EventArgs e)
        {
            timeNow_Tick(sender, e);
        }

        
        bool IsInsertNumRight(string alarm)
        {
            return Regex.IsMatch(alarm,@"^[0-2]{1}[0-3]{1}[時]{1}[0-5]{1}[0-9]{1}[分]{1}[0-5]{1}[0-9]{1}[秒]{1}$");
        }
        string TurnTimeNow(string TimeNow) 
        {
            string originalText = TimeNow; // 將 labShowTime.Text 的值存入另一個變數 originalText
            DateTime parsedDateTime = DateTime.ParseExact(originalText, "hh:mm:ss", CultureInfo.InvariantCulture); // 解析文字為 DateTime 物件
            string formattedTime = parsedDateTime.ToString("hh時mm分ss秒"); // 將 DateTime 物件轉換為指定格式的字串
            return formattedTime;
            
        }
        private void checkBoxSetTime_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSetTime.Checked == true && IsInsertNumRight(maskedTxtBoxSetTime.Text)) 
            {
                MessageBox.Show($"成功設置了{maskedTxtBoxSetTime.Text}的鬧鐘");
                labCheckAlarmSet.Text = $"{maskedTxtBoxSetTime.Text}的鬧鐘";
                string Now = TurnTimeNow(labShowTime.Text);

                if (Now==maskedTxtBoxSetTime.Text  )
                {
                    timer_ItsTime.Start();
                    timer_ItsTime_Tick(sender, e);
                    //timer_ItsTime.Stop();
                }
            }
            //else if(checkBoxSetTime.Checked == true && maskedTxtBoxSetTime.Text == maskedTxtBoxSetTime.Mask)
            //{
            //    MessageBox.Show("請輸入要設定的值");
            //    checkBoxSetTime.Checked = false;
            //}
            else if(checkBoxSetTime.Checked == true && !IsInsertNumRight(maskedTxtBoxSetTime.Text))
            {
                MessageBox.Show("請輸入24小時制的時間\n例如  08時00分02秒");
                checkBoxSetTime.Checked = false;
            }
            //origin = maskedTxtBoxSetTime.Mask;
            //if (checkBoxSetTime.Checked == true && maskedTxtBoxSetTime.Text != origin)
            //{
            //    MessageBox.Show($"設置了{maskedTxtBoxSetTime.Text}的鬧鐘");
            //    checkBoxSetTime.Checked = false;
            //    labCheckAlarmSet.Text = $"設置了{maskedTxtBoxSetTime.Text}的鬧鐘";
            //}
            //if (checkBoxSetTime.Checked == true && maskedTxtBoxSetTime.Text == origin)
            //{
            //    MessageBox.Show("請輸入要設定的值");
            //    checkBoxSetTime.Checked = false;
            //}
        }
        bool isTeal = true;
        private void timer_ItsTime_Tick(object sender, EventArgs e)
        { 
            labCheckAlarmSet.Text = "時間到了";
            if (isTeal)
            {
                labCheckAlarmSet.ForeColor = Color.Teal;
            }
            else
            {
                labCheckAlarmSet.ForeColor = Color.Pink;
            }
            isTeal = !isTeal;
        }
    }
}
