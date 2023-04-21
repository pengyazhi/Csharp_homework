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
    public partial class Frm_Loan_Report : Form
    {
        public Frm_Loan_Report()
        {
            InitializeComponent();
            labLoanRep.Text = Frm_Loan.Loan.ToString();
            labYearRep.Text = Frm_Loan.LoanYear.ToString();
            labRateRep.Text = Frm_Loan.LoanYearRate.ToString();
            labPMTRep.Text = Convert.ToInt32(Frm_Loan.PrincipalPlusInterest).ToString();
            labTotalRep.Text = Frm_Loan.Total.ToString();
        }
    }
}
