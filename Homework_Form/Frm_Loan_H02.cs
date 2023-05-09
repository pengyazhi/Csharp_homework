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
    public partial class Frm_Loan_H02 : Form
    {

        public Frm_Loan_H02()
        {
            InitializeComponent();
        }
        public static decimal Loan; //貸款金額
        public static int LoanYear;
        public static int LoanYearRate;
        public static int NumOfMonth; //還款月數
        public static double MonthlyInterestRate;//月利率
        public static decimal DownPayment;//頭期款
        public static double MonthRate;//(1＋月利率)**月數 
        public static double EachMonRate;//每月應付本息金額之平均攤還率
        public static decimal PrincipalPlusInterest;//本金+利息
        public static int Total;//總還款額
        private void btnPMT_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLoan.Text,out int Loan) && int.TryParse(txtYear.Text,out int Year) && int.TryParse(txtInterestRate.Text,out int InterestRate)
                && int.TryParse(txtDownPayment.Text,out int DownPayment))
            {
                if(Loan > 0 && Year > 0 && InterestRate > 0 && DownPayment >= 0)
                {
                    Caculate();
                    MessageBox.Show($"每月應付本息為{Convert.ToInt32(PrincipalPlusInterest)}元。");
                }
                else
                {
                    MessageBox.Show("請輸入大於0的數值");
                }
                
            }
            else
            {
                MessageBox.Show("請輸入正整數");
            }

        }
        private void btnTotal_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLoan.Text, out int Loan) && int.TryParse(txtYear.Text, out int Year) && int.TryParse(txtInterestRate.Text, out int InterestRate)
                && int.TryParse(txtDownPayment.Text, out int DownPayment))
            {
                if (Loan > 0 && Year > 0 && InterestRate > 0 && DownPayment >= 0)
                {
                    Caculate();
                    MessageBox.Show($"總付額為{Total}元。");
                }
                else
                {
                    MessageBox.Show("請輸入大於0的數值");
                }
            }
            else
            {
                MessageBox.Show("請輸入正整數");
            }


        }
        public void Caculate()
        {
            Loan = Convert.ToInt32(txtLoan.Text); //貸款金額
            LoanYear = Convert.ToInt32(txtYear.Text);//貸款年數
            NumOfMonth = Convert.ToInt32(txtYear.Text) * 12; //還款月數 = 還款年*12
            LoanYearRate = Convert.ToInt32(txtInterestRate.Text);
            MonthlyInterestRate = Convert.ToDouble(txtInterestRate.Text) / 1200; //月利率=年利率/12
            DownPayment = Convert.ToInt32(txtDownPayment.Text); //頭期款
            //每月應付本息金額之平均攤還率:{[(1＋月利率)^月數]×月利率}÷{[(1＋月利率)^月數]－1}
            MonthRate = Math.Pow(1 + MonthlyInterestRate, NumOfMonth);//(1＋月利率)**月數 
            EachMonRate = MonthRate * MonthlyInterestRate / (MonthRate - 1); //每月應付本息金額之平均攤還率
           //平均每月應攤付本息金額＝貸款本金×每月應付本息金額之平均攤還率＝每月應還本金金額＋每 月應付利息金額
            PrincipalPlusInterest = Convert.ToInt32((Loan - DownPayment)) * Convert.ToDecimal(EachMonRate);
            Total = Convert.ToInt32(PrincipalPlusInterest) * NumOfMonth;


        }
        //public Dictionary<string, decimal> Caculate()
        //{
        //    Dictionary<string, decimal> RETURN_dic = new Dictionary<string, decimal>();
        //    RETURN_dic.Add("Loan", Convert.ToInt32(txtLoan.Text));
        //    RETURN_dic.Add("LoanYear", Convert.ToInt32(txtYear.Text));
        //    RETURN_dic.Add("NumOfMonth", Convert.ToInt32(txtYear.Text) * 12);
        //    RETURN_dic.Add("LoanYearRate", Convert.ToInt32(txtInterestRate.Text));
        //    RETURN_dic.Add("MonthlyInterestRate", Convert.ToDecimal(txtInterestRate.Text) / 1200);
        //    RETURN_dic.Add("DownPayment", Convert.ToInt32(txtDdownPayment.Text));
        //    RETURN_dic.Add("MonthRate", Math.Pow(1 + MonthlyInterestRate, NumOfMonth));
        //    RETURN_dic.Add("EachMonRate", MonthRate * MonthlyInterestRate / (MonthRate - 1));
        //    RETURN_dic.Add("PrincipalPlusInterest", Convert.ToInt32((Loan - DownPayment)) * Convert.ToDecima(EachMonRate));
        //    RETURN_dic.Add("Total", Convert.ToInt32(PrincipalPlusInterest) * NumOfMonth);



        //    return RETURN_dic;
        //}
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (Utility.IsNumber(txtLoan.Text) && Utility.IsNumber(txtYear.Text) && Utility.IsNumber(txtInterestRate.Text)
                && Utility.IsNumber(txtDownPayment.Text))
            {
                if (Convert.ToInt32(txtLoan.Text) > 0 && Convert.ToInt32(txtYear.Text) > 0 && Convert.ToInt32(txtInterestRate.Text) > 0 && Convert.ToInt32(txtDownPayment.Text) >= 0)
                {
                    Caculate();
                    Frm_Loan_Report_H02 frm = new Frm_Loan_Report_H02();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("請輸入大於0的數值");
                }
            }
            else
            {
                MessageBox.Show("請輸入正整數");
            }
        }

        
    }
}
