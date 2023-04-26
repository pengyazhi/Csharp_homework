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
    public partial class Frm_StudentGrade_H05 : Form
    {
        public Frm_StudentGrade_H05()
        {
            InitializeComponent();
        }
        
        
        private void btnSaveStudentData_Click(object sender, EventArgs e)
        {
            StudentScore studentScore = 
            new StudentScore(/*txtStudentName.Text,Convert.ToDouble( txtChiScore.Text), Convert.ToDouble(txtMathScore.Text), Convert.ToDouble(txtEngScore.Text)*/);
            DataGridViewRow dr_new = new DataGridViewRow();
            dr_new.CreateCells(dataStudentScorList);
            dr_new.Cells[0].Value = txtStudentName.Text;
            dr_new.Cells[1].Value = Convert.ToDouble(txtChiScore.Text);
            dr_new.Cells[2].Value = Convert.ToDouble(txtMathScore.Text);
            dr_new.Cells[3].Value = Convert.ToDouble(txtEngScore.Text);
            dr_new.Cells[4].Value = studentScore.AddUpScore(Convert.ToDouble(txtChiScore.Text), Convert.ToDouble(txtMathScore.Text), Convert.ToDouble(txtEngScore.Text));
            dr_new.Cells[5].Value = studentScore.AveScore(Convert.ToDouble(txtChiScore.Text), Convert.ToDouble(txtMathScore.Text), Convert.ToDouble(txtEngScore.Text)); ;
            dr_new.Cells[6].Value = studentScore.higestSub(Convert.ToDouble( txtChiScore.Text), Convert.ToDouble(txtMathScore.Text), Convert.ToDouble(txtEngScore.Text));
            dr_new.Cells[7].Value = studentScore.lowestSub(Convert.ToDouble( txtChiScore.Text), Convert.ToDouble(txtMathScore.Text), Convert.ToDouble(txtEngScore.Text));
            //int add_up = studentScore.AddUpGrade(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));
            //int ave_grade = studentScore.AveGrade(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));
            //string higest_g = studentScore.higestSub(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));
            //string lowest_g = studentScore.lowestSub(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));

            dataStudentScorList.Rows.Add(dr_new);
        }

        int num = 1;
        Random random = new Random();
        public void CreatRadomStudentScore()//生成一組資料
        {
            
            DataGridViewRow dr_new = new DataGridViewRow();
            dr_new.CreateCells(dataStudentScorList);
            dr_new.Cells[0].Value = num;
            
            num++;

            int randomChi = random.Next(1, 101);
            int randomMath = random.Next(1, 101);
            int randomEng = random.Next(1, 101);
            StudentScore studentScore = new StudentScore();
            //new StudentScore(txtStudentName.Text, random.Next(1, 101), random.Next(1, 101), random.Next(1, 101));
            dr_new.Cells[1].Value = randomChi;
            dr_new.Cells[2].Value = randomMath;
            dr_new.Cells[3].Value = randomEng;
            dr_new.Cells[4].Value = studentScore.AddUpScore(randomChi, randomMath, randomEng);
            dr_new.Cells[5].Value = studentScore.AveScore(randomChi, randomMath, randomEng);
            dr_new.Cells[6].Value = studentScore.higestSub(randomChi, randomMath, randomEng);
            dr_new.Cells[7].Value = studentScore.lowestSub(randomChi, randomMath, randomEng);
            dataStudentScorList.Rows.Add(dr_new);
        }

        private void btnRadomSaveData_Click(object sender, EventArgs e)
        {
            CreatRadomStudentScore();
        }

        private void btnRadom20_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < 20;i++) 
            {
                CreatRadomStudentScore();
            }
        }
        double SubjectAdd(int subIndex)
        {
            double Total = 0;
            foreach (DataGridViewRow row in dataStudentScorList.Rows)
            {
                Total += Convert.ToInt32(row.Cells[subIndex].Value);
            }
            return Total;
        }
        private void btnSubjectCount_Click(object sender, EventArgs e)
        {
            
            int subIndexChi = 1;
            int subIndexMathi = 2;
            int subIndexEng = 3;
            double totalChi = SubjectAdd(subIndexChi);
            double totalMath = SubjectAdd(subIndexMathi);
            double totalEng = SubjectAdd(subIndexEng);
            richTextBox2.Text += $"總分{totalChi},{totalMath},{totalEng}";

        }
        //public string 
    }
}
