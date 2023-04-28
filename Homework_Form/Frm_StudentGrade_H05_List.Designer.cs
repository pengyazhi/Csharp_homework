namespace Homework_Form
{
    partial class Frm_StudentGrade_H05_List
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
            this.labName = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtChiScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.txtEngScore = new System.Windows.Forms.TextBox();
            this.btnAddStudentValue = new System.Windows.Forms.Button();
            this.btnRadomSave = new System.Windows.Forms.Button();
            this.btnAddUpScore = new System.Windows.Forms.Button();
            this.btnRefreshScoreList = new System.Windows.Forms.Button();
            this.btnRadomSave20 = new System.Windows.Forms.Button();
            this.rTxtScoreList = new System.Windows.Forms.RichTextBox();
            this.rTxtShowAll = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(26, 28);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(67, 24);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名：";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(26, 81);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(67, 24);
            this.labChi.TabIndex = 1;
            this.labChi.Text = "國文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(26, 138);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(67, 24);
            this.labMath.TabIndex = 2;
            this.labMath.Text = "數學：";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(26, 194);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(67, 24);
            this.labEng.TabIndex = 3;
            this.labEng.Text = "英文：";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStudentName.Location = new System.Drawing.Point(99, 22);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(109, 30);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtChiScore
            // 
            this.txtChiScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChiScore.Location = new System.Drawing.Point(99, 75);
            this.txtChiScore.MaxLength = 3;
            this.txtChiScore.Name = "txtChiScore";
            this.txtChiScore.Size = new System.Drawing.Size(109, 30);
            this.txtChiScore.TabIndex = 5;
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(99, 132);
            this.txtMathScore.MaxLength = 3;
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(109, 30);
            this.txtMathScore.TabIndex = 6;
            // 
            // txtEngScore
            // 
            this.txtEngScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngScore.Location = new System.Drawing.Point(99, 191);
            this.txtEngScore.MaxLength = 3;
            this.txtEngScore.Name = "txtEngScore";
            this.txtEngScore.Size = new System.Drawing.Size(109, 30);
            this.txtEngScore.TabIndex = 7;
            // 
            // btnAddStudentValue
            // 
            this.btnAddStudentValue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudentValue.Location = new System.Drawing.Point(30, 257);
            this.btnAddStudentValue.Name = "btnAddStudentValue";
            this.btnAddStudentValue.Size = new System.Drawing.Size(178, 33);
            this.btnAddStudentValue.TabIndex = 8;
            this.btnAddStudentValue.Text = "加入學生資料";
            this.btnAddStudentValue.UseVisualStyleBackColor = true;
            this.btnAddStudentValue.Click += new System.EventHandler(this.btnAddStudentValue_Click);
            // 
            // btnRadomSave
            // 
            this.btnRadomSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRadomSave.Location = new System.Drawing.Point(30, 307);
            this.btnRadomSave.Name = "btnRadomSave";
            this.btnRadomSave.Size = new System.Drawing.Size(178, 33);
            this.btnRadomSave.TabIndex = 9;
            this.btnRadomSave.Text = "隨機儲存資料";
            this.btnRadomSave.UseVisualStyleBackColor = true;
            this.btnRadomSave.Click += new System.EventHandler(this.btnRadomSave_Click);
            // 
            // btnAddUpScore
            // 
            this.btnAddUpScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddUpScore.Enabled = false;
            this.btnAddUpScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddUpScore.Location = new System.Drawing.Point(30, 358);
            this.btnAddUpScore.Name = "btnAddUpScore";
            this.btnAddUpScore.Size = new System.Drawing.Size(178, 33);
            this.btnAddUpScore.TabIndex = 10;
            this.btnAddUpScore.Text = "各科統計";
            this.btnAddUpScore.UseVisualStyleBackColor = true;
            this.btnAddUpScore.Click += new System.EventHandler(this.btnAddUpScore_Click);
            // 
            // btnRefreshScoreList
            // 
            this.btnRefreshScoreList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefreshScoreList.Location = new System.Drawing.Point(30, 447);
            this.btnRefreshScoreList.Name = "btnRefreshScoreList";
            this.btnRefreshScoreList.Size = new System.Drawing.Size(178, 33);
            this.btnRefreshScoreList.TabIndex = 11;
            this.btnRefreshScoreList.Text = "重設所有資料";
            this.btnRefreshScoreList.UseVisualStyleBackColor = true;
            this.btnRefreshScoreList.Click += new System.EventHandler(this.btnRefreshScoreList_Click);
            // 
            // btnRadomSave20
            // 
            this.btnRadomSave20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRadomSave20.Location = new System.Drawing.Point(30, 495);
            this.btnRadomSave20.Name = "btnRadomSave20";
            this.btnRadomSave20.Size = new System.Drawing.Size(178, 33);
            this.btnRadomSave20.TabIndex = 12;
            this.btnRadomSave20.Text = "隨機加入20筆資料";
            this.btnRadomSave20.UseVisualStyleBackColor = true;
            this.btnRadomSave20.Click += new System.EventHandler(this.btnRadomSave20_Click);
            // 
            // rTxtScoreList
            // 
            this.rTxtScoreList.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtScoreList.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtScoreList.Location = new System.Drawing.Point(247, 22);
            this.rTxtScoreList.Name = "rTxtScoreList";
            this.rTxtScoreList.ReadOnly = true;
            this.rTxtScoreList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtScoreList.Size = new System.Drawing.Size(565, 373);
            this.rTxtScoreList.TabIndex = 15;
            this.rTxtScoreList.Text = "姓名         國文     數學     英文     總分     平均     最高     最低\n";
            // 
            // rTxtShowAll
            // 
            this.rTxtShowAll.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtShowAll.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtShowAll.Location = new System.Drawing.Point(247, 417);
            this.rTxtShowAll.Name = "rTxtShowAll";
            this.rTxtShowAll.ReadOnly = true;
            this.rTxtShowAll.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtShowAll.Size = new System.Drawing.Size(565, 111);
            this.rTxtShowAll.TabIndex = 16;
            this.rTxtShowAll.Text = "";
            // 
            // Frm_StudentGrade_H05_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 565);
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
            this.Name = "Frm_StudentGrade_H05_List";
            this.Text = "Frm_StudentGrade_H05_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtChiScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.TextBox txtEngScore;
        private System.Windows.Forms.Button btnAddStudentValue;
        private System.Windows.Forms.Button btnRadomSave;
        private System.Windows.Forms.Button btnAddUpScore;
        private System.Windows.Forms.Button btnRefreshScoreList;
        private System.Windows.Forms.Button btnRadomSave20;
        private System.Windows.Forms.RichTextBox rTxtScoreList;
        private System.Windows.Forms.RichTextBox rTxtShowAll;
    }
}