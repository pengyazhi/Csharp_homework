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
        public void ShowScoreTop()
        {
            rTxtScoreList.Text = $"{string.Format("{0,-6:n}{1,7:n}{2,7:n}{3,7:n}{4,7:n}{5,7:n}{6,7:n}{7,7:n}", "姓名", "國文", "數學", "英文", "總分", "平均", "最高", "最低")}\n";
            foreach (StudentScore s in ssl)
            {
                rTxtScoreList.Text+= string.Format("{0,-8:n}{1,9:n0}{2,9:n0}{3,9:n0}{4,9:n0}{5,9:n2}{6,7:n0}{7,7:n0}", s.Name, s.Chi, s.Math, s.Eng,s.TotalScore,s.AverageScore,s.HigestSub,s.LowestSub) + "\n";
                
            }
        }
        private void btnAddStudentValue_Click(object sender, EventArgs e)
        {
            ss.Name = txtStudentName.Text;
            ss.Chi = Convert.ToDouble(txtChiScore.Text);
            ss.Math = Convert.ToDouble(txtMathScore.Text);
            ss.Eng = Convert.ToDouble(txtEngScore.Text);
            ss.TotalScore = ss.AddUpScore();
            ss.AverageScore = ss.AveScore();
            ss.LowestSub = ss.lowestSub(ss.Chi, ss.Math, ss.Eng);
            ss.HigestSub = ss.higestSub(ss.Chi, ss.Math, ss.Eng);
            ssl.Add(ss);
            ShowScoreTop();
            btnAddUpScore.Enabled = true;
            txtStudentName.Text = "";
            txtChiScore.Text = "";
            txtMathScore.Text = "";
            txtEngScore.Text = "";
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
            ss.TotalScore = ss.AddUpScore();
            ss.AverageScore = ss.AveScore();
            ss.LowestSub = ss.lowestSub(ss.Chi, ss.Math, ss.Eng);
            ss.HigestSub = ss.higestSub(ss.Chi, ss.Math, ss.Eng);
            ssl.Add(ss);
            ShowScoreTop();
            btnAddUpScore.Enabled = true;
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
           
            double ChiTotalScore = 0;
            double MathTotalScore = 0;
            double EngTotalScore = 0;
            

            foreach (StudentScore item in ssl)
            {
                ChiTotalScore += item.Chi;
                MathTotalScore += item.Math;
                EngTotalScore += item.Eng;
            }
            // 使用中文成績進行升序排序，選擇最低分和最高分
            ssl.Sort((x, y) => x.Chi.CompareTo(y.Chi));
            double ChiMinScore = ssl[0].Chi;
            double ChiMaxScore = ssl[ssl.Count - 1].Chi;

            // 使用數學成績進行升序排序，選擇最低分和最高分
            ssl.Sort((x, y) => x.Math.CompareTo(y.Math));
            double MathMinScore = ssl[0].Math;
            double MathMaxScore = ssl[ssl.Count - 1].Math;

            // 使用英文成績進行升序排序，選擇最低分和最高分
            ssl.Sort((x, y) => x.Eng.CompareTo(y.Eng));
            double EngMinScore = ssl[0].Eng;
            double EngMaxScore = ssl[ssl.Count - 1].Eng;

            //ssl.Sort();
            //double CL = ssl[0].Chi;
            //double ML = ssl[0].Math;
            //double EL = ssl[0].Eng;
            //ssl.Reverse();
            //double CH = ssl[0].Chi;
            //double MH = ssl[0].Math;
            //double EH = ssl[0].Eng;
            rTxtShowAll.Text +=
                   string.Format("{0,-7}{1,8}{2,9}{3,9}", "總分", ChiTotalScore, MathTotalScore, EngTotalScore) + "\n"
                   + string.Format("{0,-7}{1,8:n1}{2,9:n1}{3,9:n1}", "平均", ChiTotalScore / ssl.Count, MathTotalScore/ ssl.Count, EngTotalScore/ ssl.Count) + "\n"
                   + string.Format("{0,-6}{1,8:n1}{2,9:n1}{3,9:n1}", "最高分", ChiMaxScore, MathMaxScore, EngMaxScore) + "\n"
                   +string.Format("{0,-6}{1,8:n1}{2,9:n1}{3,9:n1}", "最低分", ChiMinScore, MathMinScore, EngMinScore) ;
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
        }
    }
}
