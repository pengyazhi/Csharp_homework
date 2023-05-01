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
    public partial class Frm_StudentGradesList_06 : Form
    {
        public Frm_StudentGradesList_06()
        {
            InitializeComponent();
          
        }
        
    private void txtLowerScore_Enter(object sender, EventArgs e)
        {
            txtLowerScore.Text = "";
            txtLowerScore.ForeColor = Color.Black;
        }
        
    private void txtHigerScore_Enter(object sender, EventArgs e)
        {
            txtHigerScore.Text = "";
            txtHigerScore.ForeColor = Color.Black;
        }

        private void txtLowerScore_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLowerScore.Text)){
                txtLowerScore.Text = "低分";
                txtLowerScore.ForeColor = Color.Gray;
            }
            
        }

        private void txtHigerScore_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHigerScore.Text))
            {
                txtHigerScore.Text = "高分";
                txtHigerScore.ForeColor = Color.Gray;
            }
                
        }

        StudentScore ss = new StudentScore();
        List<StudentScore> ssl = new List<StudentScore>();
        
        void ShowValeToList(List<StudentScore> list)
        {
            rTxtScoreList.Text = $"{string.Format("{0,-6:n}{1,7:n}{2,7:n}{3,7:n}{4,7:n}{5,7:n}{6,7:n}{7,7:n}", "姓名", "國文", "數學", "英文", "總分", "平均", "最高", "最低")}\n";
            foreach (StudentScore s in list)
            {
                rTxtScoreList.Text += string.Format("{0,-8:n}{1,9:n0}{2,9:n0}{3,9:n0}{4,9:n0}{5,9:n2}{6,7:n0}{7,7:n0}", s.Name, s.Chi, s.Math, s.Eng, s.TotalScore, s.AverageScore, s.HigestSub, s.LowestSub) + "\n";

            }
        }
        private void btnAddStudentValue_Click(object sender, EventArgs e)
        {
            if(ss.AddValueToList(txtStudentName.Text, txtChiScore.Text, txtMathScore.Text, txtEngScore.Text))
            {
                ssl.Add(ss);
                ShowValeToList(ssl);
                btnRemoveAtValue.Enabled = true;
                btnAddUpScore.Enabled = true;
                btnRefreshScoreList.Enabled = true;
            }
            
        }

        private void btnInsertValue_Click(object sender, EventArgs e)
        {
            if (ss.AddValueToList(txtStudentName.Text, txtChiScore.Text, txtMathScore.Text, txtEngScore.Text))
            {
                ssl.Insert(0,ss);
                ShowValeToList(ssl);
                btnRemoveAtValue.Enabled = true;
                btnAddUpScore.Enabled = true;
                btnRefreshScoreList.Enabled = true;
            }
        }

        private void btnRemoveAtValue_Click(object sender, EventArgs e)
        {
            if(ssl.Count == 0)
            {
                MessageBox.Show("沒有資料啦");
                btnRemoveAtValue.Enabled = false;
                btnRefreshScoreList.Enabled = false;
                btnAddUpScore.Enabled=false;
            }
            else
            {
                ssl.RemoveAt(0);
                ShowValeToList(ssl);
            }
        }

        private void btnRefreshScoreList_Click(object sender, EventArgs e)
        {
            ssl.Clear();
            rTxtShowAll.Clear();
            ShowValeToList(ssl);
            
            btnRefreshScoreList.Enabled = false;
            btnRemoveAtValue.Enabled = false;
            btnAddUpScore.Enabled = false;
            btnAddStudentValue.Enabled = true;
            btnInsertValue.Enabled = true;

        }

        private void btnAddUpScore_Click(object sender, EventArgs e)
        {
            ss.ShowSubCompare(ssl);
            rTxtShowAll.Text +=
                   string.Format("{0,-7}{1,8}{2,9}{3,9}", "總分", ss.ChiTotalScore, ss.MathTotalScore, ss.EngTotalScore) + "\n"
                   + string.Format("{0,-7}{1,8:n1}{2,9:n1}{3,9:n1}", "平均", ss.ChiTotalScore / ssl.Count, ss.MathTotalScore / ssl.Count, ss.EngTotalScore / ssl.Count) + "\n"
                   + string.Format("{0,-6}{1,8:n0}{2,9:n0}{3,9:n0}", "最高分", ss.ChiMaxScore, ss.MathMaxScore, ss.EngMaxScore) + "\n"
                   + string.Format("{0,-6}{1,8:n0}{2,9:n0}{3,9:n0}", "最低分", ss.ChiMinScore, ss.MathMinScore, ss.EngMinScore);
            ss.ChiTotalScore = 0;
            ss.MathTotalScore = 0;
            ss.EngTotalScore = 0;
            btnAddStudentValue.Enabled = false;
            btnInsertValue.Enabled = false;
            btnRemoveAtValue.Enabled=false;
            btnSearchChiScore.Enabled =false;
            btnAddUpScore.Enabled =false;
        }

        private void btnSearchChiScore_Click(object sender, EventArgs e)
        {
            List<StudentScore> range = new List<StudentScore>();
            if (Utility.IsNumber(txtLowerScore.Text) && Utility.IsNumber(txtHigerScore.Text))
            {
                foreach(StudentScore item in ssl)
                {
                    if (Convert.ToInt32(txtLowerScore.Text) <= item.Chi && item.Chi <= Convert.ToInt32(txtHigerScore.Text))
                    {
                        range.Add(item);
                        
                    }
                }
                ShowValeToList(range);
                if(range.Count == 0)
                {
                    MessageBox.Show("範圍內沒有符合的成績");
                }
            }
            else
            {
                MessageBox.Show("請輸入正整數");
            }


        }
    }
}
