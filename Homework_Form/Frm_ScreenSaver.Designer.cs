namespace Homework_Form
{
    partial class Frm_ScreenSaver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ScreenSaver));
            this.pboxCat = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCat)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxCat
            // 
            this.pboxCat.ErrorImage = null;
            this.pboxCat.Image = ((System.Drawing.Image)(resources.GetObject("pboxCat.Image")));
            this.pboxCat.InitialImage = null;
            this.pboxCat.Location = new System.Drawing.Point(0, 0);
            this.pboxCat.Name = "pboxCat";
            this.pboxCat.Size = new System.Drawing.Size(302, 272);
            this.pboxCat.TabIndex = 0;
            this.pboxCat.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1237, 667);
            this.Controls.Add(this.pboxCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ScreenSaver";
            this.Text = "Frm_ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_ScreenSaver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pboxCat;
        private System.Windows.Forms.Timer timer1;
    }
}