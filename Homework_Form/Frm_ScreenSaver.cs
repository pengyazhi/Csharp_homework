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
    public partial class Frm_ScreenSaver : Form
    {
        public Frm_ScreenSaver()
        {
            InitializeComponent(); 
        }

        private void Frm_ScreenSaver_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            
        }
        private int moveX = 5;
        private int moveY = 5;
        private Point lastMousePosition;

        private void frm_MouseMove()
        {
            lastMousePosition = Cursor.Position;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            frm_MouseMove();
            int x = pboxCat.Location.X + moveX;
            int y = pboxCat.Location.Y + moveY;
            if( x < 0 || x + pboxCat.Width > Screen.PrimaryScreen.Bounds.Width-10)
            {
                moveX *= -1;
            }
            if (y < 0 || y + pboxCat.Height > Screen.PrimaryScreen.Bounds.Height-10)
            {
                moveY *= -1;
            }
            pboxCat.Location = new Point(x, y);
            if (Cursor.Position != lastMousePosition)
            {
                Close();
            }
        }
        
    }
}
