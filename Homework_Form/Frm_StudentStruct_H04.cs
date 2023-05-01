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
            if(!string.IsNullOrEmpty(txtStudentName.Text) && Utility.IsNumber(txtChiScore.Text) && Utility.IsNumber(txtMathScore.Text) && Utility.IsNumber(txtEngScore.Text))
            {
                studentScore.Name = txtStudentName.Text;
                studentScore.Chi = int.Parse(txtChiScore.Text);
                studentScore.Math = int.Parse(txtMathScore.Text);
                studentScore.Eng = int.Parse(txtEngScore.Text);
            }
            else if (string.IsNullOrEmpty(txtStudentName.Text))
            {
                MessageBox.Show("請輸入姓名");
            }
            else
            {
                MessageBox.Show("請輸入正整數");
            }
            
        }

        private void btnShowSaved_Click(object sender, EventArgs e)
        {
            labNameScore.Text = $"姓名：{studentScore.Name}\n國文成績：{studentScore.Chi}\n數學成績：{studentScore.Math}\n英文成績：{studentScore.Eng}";
        }

        private void btnShowMaxMin_Click(object sender, EventArgs e)
        {
            string highest = studentScore.higestSub(studentScore.Chi, studentScore.Math, studentScore.Eng);
            string lowest = studentScore.lowestSub(studentScore.Chi, studentScore.Math, studentScore.Eng);
            labMaxMinScore.Text = $"最高科目成績為：{highest}分\n最低科目成績為：{lowest}分";
        }

        private void txtChiScore_Enter(object sender, EventArgs e)
        {
            txtChiScore.Text = "";
        }

        private void txtMathScore_Enter(object sender, EventArgs e)
        {
            txtMathScore.Text = "";
        }

        private void txtEngScore_Enter(object sender, EventArgs e)
        {
            txtEngScore.Text = "";
        }
    }
    
}
