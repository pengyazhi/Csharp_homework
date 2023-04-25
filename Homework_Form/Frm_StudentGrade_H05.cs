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
            new StudentScore(txtStudentName.Text,Convert.ToDouble( txtChiScore.Text), Convert.ToDouble(txtMathScore.Text), Convert.ToDouble(txtEngScore.Text));
            DataGridViewRow dr_new = new DataGridViewRow();
            dr_new.CreateCells(dataStudentScorList);
            dr_new.Cells[0].Value = studentScore.Name;
            dr_new.Cells[1].Value = studentScore.Chi;
            dr_new.Cells[2].Value = studentScore.Math;
            dr_new.Cells[3].Value = studentScore.Eng;
            dr_new.Cells[4].Value = studentScore.AddUpScore(studentScore.Chi, studentScore.Math, studentScore.Eng);
            dr_new.Cells[5].Value = studentScore.AveScore(studentScore.Chi, studentScore.Math, studentScore.Eng); ;
            dr_new.Cells[6].Value = studentScore.higestSub(studentScore.Chi, studentScore.Math, studentScore.Eng);
            dr_new.Cells[7].Value = studentScore.lowestSub(studentScore.Chi, studentScore.Math, studentScore.Eng);
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

            //int randomChi = random.Next(1, 101);
            //int randomMath = random.Next(1, 101);
            //int randomEng = random.Next(1, 101);
            StudentScore studentScore =
           new StudentScore(txtStudentName.Text, random.Next(1, 101), random.Next(1, 101), random.Next(1, 101));
            dr_new.Cells[1].Value = studentScore.Chi;
            dr_new.Cells[2].Value = studentScore.Math;
            dr_new.Cells[3].Value = studentScore.Eng;
            dr_new.Cells[4].Value = studentScore.AddUpScore(studentScore.Chi, studentScore.Math, studentScore.Eng);
            dr_new.Cells[5].Value = studentScore.AveScore(studentScore.Chi, studentScore.Math, studentScore.Eng);
            dr_new.Cells[6].Value = studentScore.higestSub(studentScore.Chi, studentScore.Math, studentScore.Eng);
            dr_new.Cells[7].Value = studentScore.lowestSub(studentScore.Chi, studentScore.Math, studentScore.Eng);
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

        private void btnSubjectCount_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataStudentScorList.Rows[1]; // 获取第二行
            int sum = 0;
            foreach (DataGridViewCell cell in row.Cells)
            {
                
                    sum += Convert.ToInt32(row.Cells[1].Value);
                
            }
            richTextBox2.Text = $"國文    {sum}";
        }
        //public string 
    }
}
