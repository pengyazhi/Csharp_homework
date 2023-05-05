namespace Homework_Form
{
    partial class Frm_Panting
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
            this.btnShowColor = new System.Windows.Forms.Button();
            this.panelShowColor = new System.Windows.Forms.Panel();
            this.trackBarPePixel = new System.Windows.Forms.TrackBar();
            this.labPixel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPePixel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowColor
            // 
            this.btnShowColor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnShowColor.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowColor.Location = new System.Drawing.Point(736, 23);
            this.btnShowColor.Name = "btnShowColor";
            this.btnShowColor.Size = new System.Drawing.Size(82, 35);
            this.btnShowColor.TabIndex = 0;
            this.btnShowColor.Text = "顏色";
            this.btnShowColor.UseVisualStyleBackColor = true;
            this.btnShowColor.Click += new System.EventHandler(this.btnShowColor_Click);
            // 
            // panelShowColor
            // 
            this.panelShowColor.BackColor = System.Drawing.Color.Black;
            this.panelShowColor.Cursor = System.Windows.Forms.Cursors.No;
            this.panelShowColor.Location = new System.Drawing.Point(736, 67);
            this.panelShowColor.Name = "panelShowColor";
            this.panelShowColor.Size = new System.Drawing.Size(82, 44);
            this.panelShowColor.TabIndex = 1;
            // 
            // trackBarPePixel
            // 
            this.trackBarPePixel.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBarPePixel.LargeChange = 1;
            this.trackBarPePixel.Location = new System.Drawing.Point(756, 139);
            this.trackBarPePixel.Maximum = 100;
            this.trackBarPePixel.Name = "trackBarPePixel";
            this.trackBarPePixel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarPePixel.Size = new System.Drawing.Size(45, 234);
            this.trackBarPePixel.TabIndex = 2;
            this.trackBarPePixel.TickFrequency = 5;
            this.trackBarPePixel.Scroll += new System.EventHandler(this.trackBarPePixel_Scroll);
            // 
            // labPixel
            // 
            this.labPixel.AutoSize = true;
            this.labPixel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPixel.Location = new System.Drawing.Point(767, 376);
            this.labPixel.Name = "labPixel";
            this.labPixel.Size = new System.Drawing.Size(20, 21);
            this.labPixel.TabIndex = 3;
            this.labPixel.Text = "1";
            // 
            // Frm_Panting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 548);
            this.Controls.Add(this.labPixel);
            this.Controls.Add(this.trackBarPePixel);
            this.Controls.Add(this.panelShowColor);
            this.Controls.Add(this.btnShowColor);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Frm_Panting";
            this.Text = "Frm_Panting";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_Panting_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_Panting_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Frm_Panting_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPePixel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnShowColor;
        private System.Windows.Forms.Panel panelShowColor;
        private System.Windows.Forms.TrackBar trackBarPePixel;
        private System.Windows.Forms.Label labPixel;
    }
}