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
    public partial class frm_HW_CSharp : Form
    {
        public frm_HW_CSharp()
        {
            InitializeComponent();
        }

        //創建一個類別 childFormType並預設其初始值為Frm_Greeting
        private Type childFormType = null;
        private Form childForm = null;
        //創建一個方法使開啟的form都會顯示在Panel2中
        private void CreateChildForm()
        {
            if (childForm != null)
            {
                childForm.Close();
            }
            childForm = (Form)Activator.CreateInstance(childFormType);
            childForm.TopLevel = false;
            splitContainer2.Panel2.Controls.Add(childForm);
            childForm.Show();
        }
        private void btnOpneHelloForm_Click(object sender, EventArgs e)
        {
            childFormType = typeof(Frm_Greeting);
            CreateChildForm();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            childFormType = typeof(Frm_Loan);
            CreateChildForm();
        }
    }
}
