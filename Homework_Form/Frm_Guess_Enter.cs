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
    public partial class Frm_Guess_Enter : Form
    {
        public Frm_Guess_Enter()
        {
            InitializeComponent();
        }

        public void btnEnter_Click(object sender, EventArgs e)
        {
          if(int.TryParse(txtEnter.Text,out int num))
            {
                
            }
            else
            {
                MessageBox.Show("請輸入1~100的數字");
            } 
        }
    }
}
