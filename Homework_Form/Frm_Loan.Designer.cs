namespace Homework_Form
{
    partial class Frm_Loan
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
            this.labLoan = new System.Windows.Forms.Label();
            this.labYear = new System.Windows.Forms.Label();
            this.labInterestRate = new System.Windows.Forms.Label();
            this.labDdownPayment = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDdownPayment = new System.Windows.Forms.TextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labLoan.Location = new System.Drawing.Point(203, 73);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(96, 26);
            this.labLoan.TabIndex = 0;
            this.labLoan.Text = "貸款金額";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labYear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labYear.Location = new System.Drawing.Point(203, 124);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(89, 26);
            this.labYear.TabIndex = 1;
            this.labYear.Text = "期限(年)";
            // 
            // labInterestRate
            // 
            this.labInterestRate.AutoSize = true;
            this.labInterestRate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInterestRate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labInterestRate.Location = new System.Drawing.Point(203, 174);
            this.labInterestRate.Name = "labInterestRate";
            this.labInterestRate.Size = new System.Drawing.Size(87, 26);
            this.labInterestRate.TabIndex = 2;
            this.labInterestRate.Text = "利率(%)";
            // 
            // labDdownPayment
            // 
            this.labDdownPayment.AutoSize = true;
            this.labDdownPayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDdownPayment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labDdownPayment.Location = new System.Drawing.Point(203, 227);
            this.labDdownPayment.Name = "labDdownPayment";
            this.labDdownPayment.Size = new System.Drawing.Size(75, 26);
            this.labDdownPayment.TabIndex = 3;
            this.labDdownPayment.Text = "頭期款";
            // 
            // txtLoan
            // 
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.Location = new System.Drawing.Point(332, 64);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(122, 35);
            this.txtLoan.TabIndex = 4;
            this.txtLoan.Text = "20000";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYear.Location = new System.Drawing.Point(332, 121);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(122, 35);
            this.txtYear.TabIndex = 5;
            this.txtYear.Text = "2";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInterestRate.Location = new System.Drawing.Point(332, 171);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(122, 35);
            this.txtInterestRate.TabIndex = 6;
            this.txtInterestRate.Text = "10";
            // 
            // txtDdownPayment
            // 
            this.txtDdownPayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDdownPayment.Location = new System.Drawing.Point(332, 224);
            this.txtDdownPayment.Name = "txtDdownPayment";
            this.txtDdownPayment.Size = new System.Drawing.Size(122, 35);
            this.txtDdownPayment.TabIndex = 7;
            this.txtDdownPayment.Text = "0";
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPMT.Location = new System.Drawing.Point(248, 295);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(143, 43);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "月付款(PMT)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTotal.Location = new System.Drawing.Point(248, 354);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(143, 43);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnReport.Location = new System.Drawing.Point(248, 412);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(143, 43);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "總覽";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 538);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDdownPayment);
            this.Controls.Add(this.txtInterestRate);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labDdownPayment);
            this.Controls.Add(this.labInterestRate);
            this.Controls.Add(this.labYear);
            this.Controls.Add(this.labLoan);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Frm_Loan";
            this.Text = "Frm_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.Label labInterestRate;
        private System.Windows.Forms.Label labDdownPayment;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDdownPayment;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
        public System.Windows.Forms.TextBox txtLoan;
    }
}