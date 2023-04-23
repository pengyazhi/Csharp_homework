using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Homework_Form
{
    public partial class Frm_StudentStruct_H04 : Form
    {
        public Frm_StudentStruct_H04()
        {
            InitializeComponent();
        }
        StudentScore studentScore = new StudentScore();
        //DataTable dataTable = new DataTable("MyDataTable");
        private void btnSave_Click(object sender, EventArgs e)
        {
            
            studentScore.Name = txtStudentName.Text;
            studentScore.Chi = int.Parse(txtChiScore.Text);
            studentScore.Math = int.Parse(txtMathScore.Text);
            studentScore.Eng = int.Parse(txtEngScore.Text);
        }

        private void btnShowSaved_Click(object sender, EventArgs e)
        {
            labNameScore.Text = $"姓名：{studentScore.Name}\n國文成績：{studentScore.Chi}\n數學成績：{studentScore.Math}\n英文成績：{studentScore.Eng}";
        }
        

        private void btnShowMaxMin_Click(object sender, EventArgs e)
        {
            string highest= studentScore.Max(studentScore.Chi, studentScore.Math, studentScore.Eng);
            string lowest = studentScore.Min(studentScore.Chi, studentScore.Math, studentScore.Eng);
            labMaxMinScore.Text = $"最高科目成績為：{highest}分\n最低科目成績為：{lowest}分";
            //string Max = "國文";
            //string Min = "國文";
            //int HighestScore = studentScore.Chi;
            //int LowestScore = studentScore.Chi;
            //if (studentScore.Math > HighestScore)
            //{
            //    HighestScore = studentScore.Math;
            //    Max = "數學";

            //}
            //if (studentScore.Eng > HighestScore)
            //{
            //    HighestScore = studentScore.Eng ;
            //    Max = "英文";
            //}
            //if (studentScore.Math < LowestScore)
            //{
            //    LowestScore = studentScore.Math ;
            //    Min = "數學";
            //}
            //if (studentScore.Eng < LowestScore)
            //{
            //    LowestScore = studentScore.Eng ;
            //    Min = "英文";
            //}


        }
    }
    
}
