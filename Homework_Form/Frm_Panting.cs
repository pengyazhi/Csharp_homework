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
    public partial class Frm_Panting : Form
    {
        ColorDialog choiceColor = new ColorDialog();
        Graphics line;
        int oldX;
        int oldY;
        public Frm_Panting()
        {
            InitializeComponent();
            line = CreateGraphics();
        }
       
        private void btnShowColor_Click(object sender, EventArgs e)
        {
            choiceColor.ShowDialog();
            panelShowColor.BackColor = choiceColor.Color ;
        }

        private void trackBarPePixel_Scroll(object sender, EventArgs e)
        {
            labPixel.Text = trackBarPePixel.Value.ToString();
        }
        bool isDrawing  = false;
        private void Frm_Panting_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            oldX = e.X;
            oldY = e.Y;
            //pen.Width = trackBarPePixel.Value;

            //Graphics graphics = new Graphics();
            //DrawLinePointF(graphics);
        }

        private void Frm_Panting_MouseMove(object sender, MouseEventArgs e)
        {
            if(isDrawing)
            {
                Pen pen = new Pen(Color.Black, trackBarPePixel.Value);
                pen.Color = choiceColor.Color;
                line.DrawLine(pen, oldX, oldY, e.X , e.Y );
                oldX = e.X;
                oldY = e.Y;
            }
            
        }

        private void Frm_Panting_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
        }
        //void DrawLinePointF(PaintEventArgs e)
        //{
        //    e.Graphics.DrawLine(pen, Cursor.Position, Cursor.Position);
        //}
    }
}
