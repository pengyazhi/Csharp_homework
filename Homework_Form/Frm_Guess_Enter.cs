using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_Guess_Enter : Form
    {
        private readonly Frm_Guess_Test frm1;
        public Frm_Guess_Enter(Frm_Guess_Test frm)
        {
            InitializeComponent();
            frm1 = frm;
        }
        int L = 100;
        int S = 0;
        
        public void btnEnter_Click(object sender, EventArgs e)
        {
            
            if (int.TryParse(txtEnter.Text, out int num))
            {
                if(num >= S && num <= 100)
                {
                    if (num < Frm_Guess_Test.ans)
                    {
                        S = num;
                        frm1.labShow.Text = $"Too Small!!!\nBetween {S} and {L}";
                    }
                    else if (num > Frm_Guess_Test.ans)
                    {
                        L = num;
                        frm1.labShow.Text = $"Too Large!!!\nBetween {S} and {L}";
                    }
                    else
                    {
                        MessageBox.Show($"Congradulations!!! You got {Frm_Guess_Test.ans}");
                    }
                }
                else
                {
                    MessageBox.Show($"請輸入{S} ~ {L}的值","錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("請輸入1~100的數字");
            }
        }
    }
}
