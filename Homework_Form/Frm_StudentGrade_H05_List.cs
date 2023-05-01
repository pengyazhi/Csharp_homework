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
        int num = 0;
        public void ShowScoreTop()
        {
            rTxtScoreList.Text = $"{string.Format("{0,-6:n}{1,7:n}{2,7:n}{3,7:n}{4,7:n}{5,7:n}{6,7:n}{7,7:n}", "姓名", "國文", "數學", "英文", "總分", "平均", "最高", "最低")}\n";
            foreach (StudentScore s in ssl)
            {
                rTxtScoreList.Text += string.Format("{0,-8:n}{1,9:n0}{2,9:n0}{3,9:n0}{4,9:n0}{5,9:n2}{6,7:n0}{7,7:n0}", s.Name, s.Chi, s.Math, s.Eng,s.TotalScore,s.AverageScore,s.HigestSub,s.LowestSub) + "\n";
                
            }
        }
        public void btnAddStudentValue_Click(object sender, EventArgs e)
        {
            
            if (ss.AddValueToList(txtStudentName.Text, txtChiScore.Text, txtMathScore.Text, txtEngScore.Text))
            {
                num++;
                ssl.Add(ss);
                ShowScoreTop();
                btnAddUpScore.Enabled = true;
                txtStudentName.Text = "";
                txtChiScore.Text = "";
                txtMathScore.Text = "";
                txtEngScore.Text = "";
            }
            else
            {
                if (!Utility.IsNumber(txtChiScore.Text))
                {
                    txtChiScore.Text = "";
                    txtChiScore.Focus();
                }
                if (!Utility.IsNumber(txtMathScore.Text))
                {
                    txtMathScore.Text = "";
                    txtMathScore.Focus();
                }
                if (!Utility.IsNumber(txtEngScore.Text))
                {
                    txtEngScore.Text = "";
                    txtEngScore.Focus();
                }
            }


            //if (Utility.IsNumber(txtChiScore.Text) && Utility.IsNumber(txtMathScore.Text) && Utility.IsNumber(txtEngScore.Text))
            //{
            //    ss.Name = txtStudentName.Text;
            //    ss.Chi = Convert.ToDouble(txtChiScore.Text);
            //    ss.Math = Convert.ToDouble(txtMathScore.Text);
            //    ss.Eng = Convert.ToDouble(txtEngScore.Text);
            //    ss.TotalScore = ss.AddUpScore();
            //    ss.AverageScore = ss.AveScore();
            //    ss.LowestSub = ss.lowestSub(ss.Chi, ss.Math, ss.Eng);
            //    ss.HigestSub = ss.higestSub(ss.Chi, ss.Math, ss.Eng);
            //    ssl.Add(ss);
            //    ShowScoreTop();
            //    btnAddUpScore.Enabled = true;
            //    txtStudentName.Text = "";
            //    txtChiScore.Text = "";
            //    txtMathScore.Text = "";
            //    txtEngScore.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("請輸入正整數");
            //    if (!Utility.IsNumber(txtChiScore.Text))
            //    {
            //        txtChiScore.Text = "";
            //        txtChiScore.Focus();
            //    }
            //    if (!Utility.IsNumber(txtMathScore.Text))
            //    {
            //        txtMathScore.Text = "";
            //        txtMathScore.Focus();
            //    }
            //    if (!Utility.IsNumber(txtEngScore.Text))
            //    {
            //        txtEngScore.Text = "";
            //        txtEngScore.Focus();
            //    }
            //}

        }
        Random ranScore = new Random();
        
        private void btnRadomSave_Click(object sender, EventArgs e)
        {
            num++;
            if (ss.AddValueToList(num.ToString(), ranScore.Next(0, 101).ToString(), ranScore.Next(0, 101).ToString(), ranScore.Next(0, 101).ToString()))
            {
                
                ssl.Add(ss);
                ShowScoreTop();
                btnAddUpScore.Enabled = true;
            }
            
            //ss.Name = num.ToString();
            //ss.Chi = ranScore.Next(0, 101);
            //ss.Math = ranScore.Next(0, 101);
            //ss.Eng = ranScore.Next(0, 101);
            //ss.TotalScore = ss.AddUpScore();
            //ss.AverageScore = ss.AveScore();
            //ss.LowestSub = ss.lowestSub(ss.Chi, ss.Math, ss.Eng);
            //ss.HigestSub = ss.higestSub(ss.Chi, ss.Math, ss.Eng);
            
        }

        private void btnRadomSave20_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {
                btnRadomSave_Click(sender, e);
            }
        }
        
        private void btnAddUpScore_Click(object sender, EventArgs e)//各科統計
        {

            ss.ShowSubCompare(ssl);
            rTxtShowAll.Text +=
                   string.Format("{0,-7}{1,8}{2,9}{3,9}", "總分", ss.ChiTotalScore, ss.MathTotalScore, ss.EngTotalScore) + "\n"
                   + string.Format("{0,-7}{1,8:n1}{2,9:n1}{3,9:n1}", "平均", ss.ChiTotalScore / ssl.Count, ss.MathTotalScore / ssl.Count, ss.EngTotalScore / ssl.Count) + "\n"
                   + string.Format("{0,-6}{1,8:n0}{2,9:n0}{3,9:n0}", "最高分", ss.ChiMaxScore, ss.MathMaxScore, ss.EngMaxScore) + "\n"
                   +string.Format("{0,-6}{1,8:n0}{2,9:n0}{3,9:n0}", "最低分", ss.ChiMinScore, ss.MathMinScore, ss.EngMinScore) ;
            ss.ChiTotalScore = 0;
            ss.MathTotalScore = 0;
            ss.EngTotalScore = 0;
            btnAddStudentValue.Enabled = false;
            btnRadomSave.Enabled = false;
            btnAddUpScore.Enabled = false;
            btnRadomSave20.Enabled = false;
        }
        

        private void btnRefreshScoreList_Click(object sender, EventArgs e)
        {
            ssl.Clear();
            ShowScoreTop();
            
            rTxtShowAll.Text = "";
            btnAddUpScore.Enabled = false;
            btnAddStudentValue.Enabled = true;
            btnRadomSave.Enabled = true;
            btnRadomSave20.Enabled = true;
            num = 0;
        }
    }
}
