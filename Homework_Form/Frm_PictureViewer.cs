
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_PictureViewer : Form
    {
        public Frm_PictureViewer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_ShowPicture frm = new Frm_ShowPicture();
            switch (((Control)sender).Name.ToString())
            { 
                case "Pic01":
                {
                    frm.BackgroundImage = Pic01.Image;
                    break;
                }
                case "Pic02":
                    {
                        frm.BackgroundImage = Pic02.Image;
                        break;
                    }
                case "Pic03":
                    {
                        frm.BackgroundImage = Pic03.Image;
                        break;
                    }
                case "Pic04":
                    {
                        frm.BackgroundImage = Pic04.Image;
                        break;
                    }
                case "Pic05":
                    {
                        frm.BackgroundImage = Pic05.Image;
                        break;
                    }
                case "Pic06":
                    {
                        frm.BackgroundImage = Pic06.Image;
                        break;
                    }
                case "Pic07":
                    {
                        frm.BackgroundImage = Pic07.Image;
                        break;
                    }
                case "Pic08":
                    {
                        frm.BackgroundImage = Pic08.Image;
                        break;
                    }
                case "Pic09":
                    {
                        frm.BackgroundImage = Pic09.Image;
                        break;
                    }
                case "Pic10":
                    {
                        frm.BackgroundImage = Pic10.Image;
                        break;
                    }
            }
            frm.BackgroundImageLayout = ImageLayout.Zoom;
            frm.Show();
        }

        
    }
}
