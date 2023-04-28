namespace Homework_Form
{
    partial class Frm_06_StudentGradesList
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
            this.rTxtShowAll = new System.Windows.Forms.RichTextBox();
            this.rTxtScoreList = new System.Windows.Forms.RichTextBox();
            this.btnRadomSave20 = new System.Windows.Forms.Button();
            this.btnRefreshScoreList = new System.Windows.Forms.Button();
            this.btnAddUpScore = new System.Windows.Forms.Button();
            this.btnRadomSave = new System.Windows.Forms.Button();
            this.btnAddStudentValue = new System.Windows.Forms.Button();
            this.txtEngScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.txtChiScore = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rTxtShowAll
            // 
            this.rTxtShowAll.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtShowAll.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtShowAll.Location = new System.Drawing.Point(235, 438);
            this.rTxtShowAll.Name = "rTxtShowAll";
            this.rTxtShowAll.ReadOnly = true;
            this.rTxtShowAll.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtShowAll.Size = new System.Drawing.Size(565, 111);
            this.rTxtShowAll.TabIndex = 31;
            this.rTxtShowAll.Text = "";
            // 
            // rTxtScoreList
            // 
            this.rTxtScoreList.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtScoreList.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtScoreList.Location = new System.Drawing.Point(235, 43);
            this.rTxtScoreList.Name = "rTxtScoreList";
            this.rTxtScoreList.ReadOnly = true;
            this.rTxtScoreList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtScoreList.Size = new System.Drawing.Size(565, 373);
            this.rTxtScoreList.TabIndex = 30;
            this.rTxtScoreList.Text = "姓名         國文     數學     英文     總分     平均     最高     最低\n";
            // 
            // btnRadomSave20
            // 
            this.btnRadomSave20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRadomSave20.Location = new System.Drawing.Point(18, 516);
            this.btnRadomSave20.Name = "btnRadomSave20";
            this.btnRadomSave20.Size = new System.Drawing.Size(178, 33);
            this.btnRadomSave20.TabIndex = 29;
            this.btnRadomSave20.Text = "隨機加入20筆資料";
            this.btnRadomSave20.UseVisualStyleBackColor = true;
            // 
            // btnRefreshScoreList
            // 
            this.btnRefreshScoreList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefreshScoreList.Location = new System.Drawing.Point(18, 468);
            this.btnRefreshScoreList.Name = "btnRefreshScoreList";
            this.btnRefreshScoreList.Size = new System.Drawing.Size(178, 33);
            this.btnRefreshScoreList.TabIndex = 28;
            this.btnRefreshScoreList.Text = "重設所有資料";
            this.btnRefreshScoreList.UseVisualStyleBackColor = true;
            // 
            // btnAddUpScore
            // 
            this.btnAddUpScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddUpScore.Enabled = false;
            this.btnAddUpScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddUpScore.Location = new System.Drawing.Point(18, 379);
            this.btnAddUpScore.Name = "btnAddUpScore";
            this.btnAddUpScore.Size = new System.Drawing.Size(178, 33);
            this.btnAddUpScore.TabIndex = 27;
            this.btnAddUpScore.Text = "各科統計";
            this.btnAddUpScore.UseVisualStyleBackColor = true;
            // 
            // btnRadomSave
            // 
            this.btnRadomSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRadomSave.Location = new System.Drawing.Point(18, 328);
            this.btnRadomSave.Name = "btnRadomSave";
            this.btnRadomSave.Size = new System.Drawing.Size(178, 33);
            this.btnRadomSave.TabIndex = 26;
            this.btnRadomSave.Text = "隨機儲存資料";
            this.btnRadomSave.UseVisualStyleBackColor = true;
            // 
            // btnAddStudentValue
            // 
            this.btnAddStudentValue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudentValue.Location = new System.Drawing.Point(18, 278);
            this.btnAddStudentValue.Name = "btnAddStudentValue";
            this.btnAddStudentValue.Size = new System.Drawing.Size(178, 33);
            this.btnAddStudentValue.TabIndex = 25;
            this.btnAddStudentValue.Text = "加入學生資料";
            this.btnAddStudentValue.UseVisualStyleBackColor = true;
            // 
            // txtEngScore
            // 
            this.txtEngScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngScore.Location = new System.Drawing.Point(87, 212);
            this.txtEngScore.MaxLength = 3;
            this.txtEngScore.Name = "txtEngScore";
            this.txtEngScore.Size = new System.Drawing.Size(109, 30);
            this.txtEngScore.TabIndex = 24;
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(87, 153);
            this.txtMathScore.MaxLength = 3;
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(109, 30);
            this.txtMathScore.TabIndex = 23;
            // 
            // txtChiScore
            // 
            this.txtChiScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChiScore.Location = new System.Drawing.Point(87, 96);
            this.txtChiScore.MaxLength = 3;
            this.txtChiScore.Name = "txtChiScore";
            this.txtChiScore.Size = new System.Drawing.Size(109, 30);
            this.txtChiScore.TabIndex = 22;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStudentName.Location = new System.Drawing.Point(87, 43);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(109, 30);
            this.txtStudentName.TabIndex = 21;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(14, 215);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(67, 24);
            this.labEng.TabIndex = 20;
            this.labEng.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(14, 159);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 19;
            this.labMath.Text = "數學：";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(14, 102);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(67, 24);
            this.labChi.TabIndex = 18;
            this.labChi.Text = "國文：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(14, 49);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 17;
            this.labName.Text = "姓名：";
            // 
            // Frm_06_StudentGradesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 607);
            this.Controls.Add(this.rTxtShowAll);
            this.Controls.Add(this.rTxtScoreList);
            this.Controls.Add(this.btnRadomSave20);
            this.Controls.Add(this.btnRefreshScoreList);
            this.Controls.Add(this.btnAddUpScore);
            this.Controls.Add(this.btnRadomSave);
            this.Controls.Add(this.btnAddStudentValue);
            this.Controls.Add(this.txtEngScore);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.txtChiScore);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Name = "Frm_06_StudentGradesList";
            this.Text = "Frm_06_StudentGradesList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtShowAll;
        private System.Windows.Forms.RichTextBox rTxtScoreList;
        private System.Windows.Forms.Button btnRadomSave20;
        private System.Windows.Forms.Button btnRefreshScoreList;
        private System.Windows.Forms.Button btnAddUpScore;
        private System.Windows.Forms.Button btnRadomSave;
        private System.Windows.Forms.Button btnAddStudentValue;
        private System.Windows.Forms.TextBox txtEngScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.TextBox txtChiScore;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labName;
    }
}