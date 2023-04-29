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
    public partial class Frm_Claculate_H07 : Form
    {
        public Frm_Claculate_H07()
        {
            InitializeComponent();
        }
        double Num;
        void ShowAnswerInt()
        {
            
            txtAnswer.Text = Num.ToString();
        }
        void ShowAnswerDouble()
        {
            txtAnswer.Text = string.Format("{0:n4}", Num).ToString();

        }
        
        bool IsNum()
        {
            int num ;
            if (int.TryParse(txtNum1.Text, out num) & int.TryParse(txtNum2.Text, out num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (IsNum())
            {
                Num = Convert.ToDouble(txtNum1.Text) + Convert.ToDouble(txtNum2.Text);
                ShowAnswerInt();
            }
            else
            {
                MessageBox.Show("請輸入有效的數值");
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (IsNum())
            {
                Num = Convert.ToDouble(txtNum1.Text) - Convert.ToDouble(txtNum2.Text);
                ShowAnswerInt();
            }
            else
            {
                MessageBox.Show("請輸入有效的數值");
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (IsNum())
            {
                Num = Convert.ToDouble(txtNum1.Text) * Convert.ToDouble(txtNum2.Text);
                ShowAnswerInt();
            }
            else
            {
                MessageBox.Show("請輸入有效的數值");
            }
        }

        private void btnDivided_Click(object sender, EventArgs e)
        {
            if (IsNum())
            {
                Num = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtNum2.Text);
                ShowAnswerDouble();
            }
            else
            {
                MessageBox.Show("請輸入有效的數值");
            }
        }
    }
}
