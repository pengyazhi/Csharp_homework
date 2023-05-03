using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_XOGame_H09 : Form
    {
        public Button[] oxBtn;
        public Frm_XOGame_H09()
        {
            InitializeComponent();
            oxBtn = new Button[] { btn0 , btn1, btn2 , btn3 , btn4 , btn5 , btn6 , btn7, btn8 };
        }
        
        public bool player = true; //player1:true player2:false
        public void btnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            if (player)
            {
                btn.Text = "O";
                btn.Enabled = false;
            }
            else
            {
                btn.Text = "X";
                btn.Enabled = false;
            }
            checkWin();
            player = !player;
        }
        
        public void checkWin()
        {
            
            if (checkLine(0, 1, 2) || checkLine(3, 4, 5) || checkLine(6, 7, 8) ||
            checkLine(0, 3, 6) || checkLine(1, 4, 7) || checkLine(2, 5, 8) ||
            checkLine(0, 4, 8) || checkLine(2, 4, 6))
            {
                MessageBox.Show((player ? "O" : "X") + "贏了!");
                Reset();
            }
            else if (oxBtn.All(button => button.Text != "")) 
            {
                MessageBox.Show( "平手!按下確定重新開始", "平局");
                Reset();
            }
        }
        public bool checkLine(int a, int b, int c)
        {
                return oxBtn[a].Text != "" && oxBtn[a].Text == oxBtn[b].Text && oxBtn[b].Text == oxBtn[c].Text;
        }
        void Reset()
        {
            foreach (Button btn in oxBtn)
            {
                btn.Text = "";
                btn.Enabled = true;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            Reset();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            btnClick(sender, e); 
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            btnClick(sender, e);
        }

        
    }
}
