namespace Homework_Form
{
    partial class Frm_Alarm
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
            this.timeNow = new System.Windows.Forms.Timer(this.components);
            this.labShowTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSetTime = new System.Windows.Forms.CheckBox();
            this.maskedTxtBoxSetTime = new System.Windows.Forms.MaskedTextBox();
            this.labSetTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeNow
            // 
            this.timeNow.Interval = 1000;
            this.timeNow.Tick += new System.EventHandler(this.timeNow_Tick);
            // 
            // labShowTime
            // 
            this.labShowTime.AutoSize = true;
            this.labShowTime.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShowTime.Location = new System.Drawing.Point(69, 49);
            this.labShowTime.Name = "labShowTime";
            this.labShowTime.Size = new System.Drawing.Size(88, 32);
            this.labShowTime.TabIndex = 0;
            this.labShowTime.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxSetTime);
            this.groupBox1.Controls.Add(this.maskedTxtBoxSetTime);
            this.groupBox1.Controls.Add(this.labSetTime);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(162, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 233);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Time";
            // 
            // checkBoxSetTime
            // 
            this.checkBoxSetTime.AutoSize = true;
            this.checkBoxSetTime.Location = new System.Drawing.Point(142, 157);
            this.checkBoxSetTime.Name = "checkBoxSetTime";
            this.checkBoxSetTime.Size = new System.Drawing.Size(111, 27);
            this.checkBoxSetTime.TabIndex = 2;
            this.checkBoxSetTime.Text = "Set Alarm";
            this.checkBoxSetTime.UseVisualStyleBackColor = true;
            this.checkBoxSetTime.CheckedChanged += new System.EventHandler(this.checkBoxSetTime_CheckedChanged);
            // 
            // maskedTxtBoxSetTime
            // 
            this.maskedTxtBoxSetTime.BeepOnError = true;
            this.maskedTxtBoxSetTime.Location = new System.Drawing.Point(187, 101);
            this.maskedTxtBoxSetTime.Mask = "90時90分90秒";
            this.maskedTxtBoxSetTime.Name = "maskedTxtBoxSetTime";
            this.maskedTxtBoxSetTime.Size = new System.Drawing.Size(142, 32);
            this.maskedTxtBoxSetTime.TabIndex = 1;
            this.maskedTxtBoxSetTime.ValidatingType = typeof(System.DateTime);
            // 
            // labSetTime
            // 
            this.labSetTime.AutoSize = true;
            this.labSetTime.Location = new System.Drawing.Point(55, 106);
            this.labSetTime.Name = "labSetTime";
            this.labSetTime.Size = new System.Drawing.Size(115, 23);
            this.labSetTime.TabIndex = 0;
            this.labSetTime.Text = "Alarm Time:";
            // 
            // Frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labShowTime);
            this.Name = "Frm_Alarm";
            this.Text = "Frm_Alarm";
            this.Load += new System.EventHandler(this.Frm_Alarm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timeNow;
        private System.Windows.Forms.Label labShowTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxSetTime;
        private System.Windows.Forms.Label labSetTime;
        private System.Windows.Forms.CheckBox checkBoxSetTime;
    }
}