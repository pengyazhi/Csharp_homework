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
    public partial class Frm_Guess_Test : Form
    {
        public Frm_Guess_Test()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            int ans = num.Next(0,101);
            Frm_Guess_Enter frm = new Frm_Guess_Enter();
            frm.Show();
            int S = 0;
            int L = 100;
            if (int.TryParse(frm.txtEnter.Text,out int x))
            {
                if (x < ans)
                {
                    labShow.Text = $"Too Small!!!\nBetween {x} and {L}";
                    S = x;
                }else if ( x > ans)
                {
                    labShow.Text = $"Too Large!!!\nBetween {S} and {x}";
                    L = x;
                }
                else
                {
                    MessageBox.Show($"Congradulations!!! You got {ans}");
                }
            }
        }
    }
}
