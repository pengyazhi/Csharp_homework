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
        public static int ans = 0;
        public void btnGuess_Click(object sender, EventArgs e)
        {
            Random num = new Random();
            ans = num.Next(0,101);
            Frm_Guess_Enter frm = new Frm_Guess_Enter(this);
            frm.ShowDialog();
        }

        private void brnShowAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Answer : {ans}");
        }
    }
}
