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
    public partial class Frm_HomePage_H00 : Form
    {
        public Frm_HomePage_H00()
        {
            InitializeComponent();
        }

        private Form childForm = null;
        //創建一個方法使開啟的form都會顯示在Panel2中
        private void CreateChildForm(Type p_Form)
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = (Form)Activator.CreateInstance(p_Form);
            childForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(childForm);
            childForm.Show();
        }
        private void btnOpneHelloForm_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_Greeting_H01);
            CreateChildForm(childFormType);
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_Loan_H02);
            CreateChildForm(childFormType);
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_POS_H03);
            CreateChildForm(childFormType);

        }

        private void btnStudentStrucrForm_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_StudentStruct_H04);
            CreateChildForm(childFormType);

        }

        private void btnStudentGrade_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_StudentGrade_H05_List);
            CreateChildForm(childFormType);

        }

        private void btnStudentGradeList_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_StudentGradesList_06);
            CreateChildForm(childFormType);


        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_Calculator_H07);
            CreateChildForm(childFormType);

        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_ForDoWhileMethod_H08);
            CreateChildForm(childFormType);
        }

        private void btnOXGame_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_XOGame_H09);
            CreateChildForm(childFormType);
        }

        private void btnScreenSaver_Click(object sender, EventArgs e)
        {
            Frm_ScreenSaver frm = new Frm_ScreenSaver();
            frm.Show();
        }

        private void btnPictureViewer_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_PictureViewer);
            CreateChildForm(childFormType);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_Guess_Test);
            CreateChildForm(childFormType);
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_Alarm);
            CreateChildForm(childFormType);
        }

        

        private void btnNotePad_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_Notepad);
            CreateChildForm(childFormType);
        }

        private void btnPanting_Click(object sender, EventArgs e)
        {
            Type childFormType = typeof(Frm_Panting);
            CreateChildForm(childFormType);
        }
    }
    
}
