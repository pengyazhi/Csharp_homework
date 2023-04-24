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
        StudentScore studentScore = new StudentScore();
        
        private void btnSaveStudentData_Click(object sender, EventArgs e)
        {
            
            DataGridViewRow dr_new = new DataGridViewRow();
            dr_new.CreateCells(dataStudentScorList);
            dr_new.Cells[0].Value = txtStudentName.Text;
            dr_new.Cells[1].Value = txtChiScore.Text;
            dr_new.Cells[2].Value = txtMathScore.Text;
            dr_new.Cells[3].Value = txtEngScore.Text;
            int add_up = studentScore.AddUpGrade(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));
            dr_new.Cells[4].Value = add_up;
            int ave_grade = studentScore.AveGrade(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));
            dr_new.Cells[5].Value = ave_grade;
            string higest_g = studentScore.higestSub(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));
            string lowest_g = studentScore.lowestSub(int.Parse(txtChiScore.Text), int.Parse(txtMathScore.Text), int.Parse(txtEngScore.Text));
            dr_new.Cells[6].Value = higest_g;
            dr_new.Cells[7].Value = lowest_g;
            
            dataStudentScorList.Rows.Add(dr_new);
        }

        int num = 1;
        Random random = new Random();
        public void CreatRadomStudentScore()//生成一組資料
        {
            DataGridViewRow dr_new = new DataGridViewRow();
            dr_new.CreateCells(dataStudentScorList);
            dr_new.Cells[0].Value = num;
            dataStudentScorList.Rows.Add(dr_new);
            num++;

            int randomChi = random.Next(1, 101);
            int randomMath = random.Next(1, 101);
            int randomEng = random.Next(1, 101);

            dr_new.Cells[1].Value = randomChi;
            dr_new.Cells[2].Value = randomMath;
            dr_new.Cells[3].Value = randomEng;
            dr_new.Cells[4].Value = studentScore.AddUpGrade(randomChi, randomMath, randomEng);
            dr_new.Cells[5].Value = studentScore.AveGrade(randomChi, randomMath, randomEng);
            dr_new.Cells[6].Value = studentScore.higestSub(randomChi, randomMath, randomEng);
            dr_new.Cells[7].Value = studentScore.lowestSub(randomChi, randomMath, randomEng);
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
    }
}
