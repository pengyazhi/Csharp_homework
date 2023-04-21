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
    public partial class Frm_Greeting : Form
    {
        public Frm_Greeting()
        {
            InitializeComponent();
        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            string message = GetGreetingMessage();
            MessageBox.Show(message.Replace("{greeting}", "Hi"));
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            string message = GetGreetingMessage();
            MessageBox.Show(message.Replace("{greeting}", "Hello"));
        }
        private string GetGreetingMessage()
        {
            string name = txtName.Text;
            string englishName = txtEnglishName.Text;
            string sex = txtSex.Text;
            string starSign = txtStarSign.Text;
            return $"{{greeting}}, 我是{name},\n英文名字是{englishName},\n性別是{sex},\n星座是{starSign},\n很高興認識你!";
        }
    }
}
