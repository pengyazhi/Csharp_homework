using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
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
            timeNow.Start();
        }
        DateTime Time;
        string formattedTime;
        int Count;
        private void timeNow_Tick(object sender, EventArgs e)
        {
            labShowTime.Text = DateTime.Now.ToString("hh:mm:ss");

            if (labShowTime.Text == formattedTime)
            {
                timer_ItsTime.Start();
            }
        }

        private void Frm_Alarm_Load(object sender, EventArgs e)
        {
            timeNow_Tick(sender, e);
        }

        
        bool IsInsertNumRight(string alarm)
        {
            //return Regex.IsMatch(alarm,@"^[0-1]{1}[0-9]{1}[時]{1}[0-5]{1}[0-9]{1}[分]{1}[0-5]{1}[0-9]{1}[秒]{1}$");
            return Regex.IsMatch(alarm, @"^((1[0-2]|0[0-9])時|0[0-9]時)([0-5][0-9])分([0-5][0-9])秒$");
        }
        //string TurnTimeNow(string TimeNow) 
        //{
        //    string originalText = TimeNow; // 將 labShowTime.Text 的值存入另一個變數 originalText
        //    DateTime parsedDateTime = DateTime.ParseExact(originalText, "hh:mm:ss", CultureInfo.InvariantCulture); // 解析文字為 DateTime 物件
        //    string formattedTime = parsedDateTime.ToString("hh時mm分ss秒"); // 將 DateTime 物件轉換為指定格式的字串
        //    return formattedTime;

        //}
        
        private void checkBoxSetTime_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxSetTime.Checked == true && IsInsertNumRight(maskedTxtBoxSetTime.Text)) 
            {
                MessageBox.Show($"成功設置了{maskedTxtBoxSetTime.Text}的鬧鐘");
                //labCheckAlarmSet.Text = $"{maskedTxtBoxSetTime.Text}的鬧鐘";
                //string Now = TurnTimeNow(labShowTime.Text);
                Time = DateTime.ParseExact(maskedTxtBoxSetTime.Text, "hh時mm分ss秒", null);
                formattedTime = Time.ToString("hh:mm:ss");
                
            }
           
            else if(checkBoxSetTime.Checked == true && !IsInsertNumRight(maskedTxtBoxSetTime.Text))
            {
                MessageBox.Show("請輸入12小時制的時間");
                checkBoxSetTime.Checked = false;
            }
            
        }
        bool isTeal = true;
        private void timer_ItsTime_Tick(object sender, EventArgs e)
        { 
            labCheckAlarmSet.Text = "It's Time !!";
            labCheckAlarmSet.Font = new Font(labCheckAlarmSet.Font, labCheckAlarmSet.Font.Style | FontStyle.Bold);
            if (isTeal)
            {
                labCheckAlarmSet.ForeColor = Color.Teal;
                labCheckAlarmSet.BackColor = Color.Pink;
            }
            else
            {
                labCheckAlarmSet.ForeColor = Color.Pink;
                labCheckAlarmSet.BackColor = Color.Teal;
            }
            isTeal = !isTeal;
            Count++;
            if(Count > 10)
            {
                timer_ItsTime.Stop();
                labCheckAlarmSet.ForeColor = Color.Black;
                labCheckAlarmSet.BackColor = SystemColors.Control;
                checkBoxSetTime.Checked = false;
                labCheckAlarmSet.Font = new Font(labCheckAlarmSet.Font, labCheckAlarmSet.Font.Style | FontStyle.Regular);
                labCheckAlarmSet.Text = "Alarm Time";
                Count = 0;
            }
        }
    }
}
