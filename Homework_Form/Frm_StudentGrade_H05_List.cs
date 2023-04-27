using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_StudentGrade_H05_List : Form
    {
        public Frm_StudentGrade_H05_List()
        {
            InitializeComponent();
        }
        List<StudentScore> ssl = new List<StudentScore>();
        StudentScore ss = new StudentScore();
        public void ShowScore()
        {
            rTxtScoreList.Text = $"{string.Format("{0,-6:n}{1,7:n}{2,7:n}{3,7:n}{4,7:n}{5,7:n}{6,7:n}{7,7:n}", "姓名", "國文", "數學", "英文", "總分", "平均", "最高", "最低")}\n";
            foreach (StudentScore s in ssl)
            {
                rTxtScoreList.Text+= string.Format("{0,-8:n}{1,9:n0}{2,9:n0}{3,9:n0}", s.Name, s.Chi, s.Math, s.Eng) + "\n";
                //txtScoreList.Text += string.Format("{0,-12}{1,14:n}{2,14:n}{3,14:n}{4,14:n}{5,14:n}{6,14:n}{7,14:n}",s.Name,s.Chi, s.Math, s.Eng, s.TotalScore, s.AverageScore, s.HigestSub, s.LowestSub) + "\n"; 
            }
        }
        private void btnAddStudentValue_Click(object sender, EventArgs e)
        {
            ss.Name = txtStudentName.Text;
            ss.Chi = Convert.ToDouble(txtChiScore.Text);
            ss.Math = Convert.ToDouble(txtMathScore.Text);
            ss.Eng = Convert.ToDouble(txtEngScore.Text);
            ssl.Add(ss);
            ShowScore();
        }
        Random ranScore = new Random();
        int num = 0;
        private void btnRadomSave_Click(object sender, EventArgs e)
        {
            num++;
            ss.Name = num.ToString();
            ss.Chi = ranScore.Next(0, 101);
            ss.Math = ranScore.Next(0, 101);
            ss.Eng = ranScore.Next(0, 101);
            ssl.Add(ss);
            ShowScore();
        }

        private void btnRadomSave20_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                btnRadomSave_Click(sender, e);
            }
        }

        private void btnAddUpScore_Click(object sender, EventArgs e)
        {

        }
    }
}
