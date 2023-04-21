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
    public partial class Frm_Loan_Report_H02 : Form
    {
        
        public Frm_Loan_Report_H02()
        {
            InitializeComponent();
            
            labLoanRep.Text = Frm_Loan_H02.Loan.ToString();
            labYearRep.Text = Frm_Loan_H02.LoanYear.ToString();
            labRateRep.Text = Frm_Loan_H02.LoanYearRate.ToString();
            labPMTRep.Text = Convert.ToInt32(Frm_Loan_H02.PrincipalPlusInterest).ToString();
            labTotalRep.Text = Frm_Loan_H02.Total.ToString();
        }
    }
}
