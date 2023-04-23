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
		private void CreateChildForm(System.Type p_Form)
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
	}
}
