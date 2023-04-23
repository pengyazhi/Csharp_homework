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

            studentScore.Name = txtStudentName.Text;
            studentScore.Chi = int.Parse(txtChiScore.Text);
            studentScore.Math = int.Parse(txtMathScore.Text);
            studentScore.Eng = int.Parse(txtEngScore.Text);
            int TotalGrade = studentScore.AddGrade(studentScore.Chi, studentScore.Math, studentScore.Eng);
            int AveGrade = studentScore.AveGrade(studentScore.Chi, studentScore.Math, studentScore.Eng);
            string Higest = studentScore.Max(studentScore.Chi, studentScore.Math, studentScore.Eng);
            string Lowest = studentScore.Min(studentScore.Chi, studentScore.Math, studentScore.Eng);
            //string sz =  dataGridView1.Name;

            DataGridViewRow dr_new = new DataGridViewRow();
            dr_new.CreateCells(dataGridView1);
            dr_new.Cells[0].Value = studentScore.Name;
            dr_new.Cells[1].Value = studentScore.Chi;
            dr_new.Cells[2].Value = studentScore.Math;
            dr_new.Cells[3].Value = studentScore.Eng;
            dr_new.Cells[4].Value = TotalGrade;
            dr_new.Cells[5].Value = AveGrade;
            dr_new.Cells[6].Value = Higest;
            dr_new.Cells[7].Value = Lowest;
            dataGridView1.Rows.Add(dr_new);
        }

        
    }
}
