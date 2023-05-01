namespace Homework_Form
{
    partial class Frm_StudentGradesList_06
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
            this.btnSearchChiScore = new System.Windows.Forms.Button();
            this.btnRefreshScoreList = new System.Windows.Forms.Button();
            this.btnRemoveAtValue = new System.Windows.Forms.Button();
            this.btnInsertValue = new System.Windows.Forms.Button();
            this.btnAddStudentValue = new System.Windows.Forms.Button();
            this.txtEngScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.txtChiScore = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLowerScore = new System.Windows.Forms.TextBox();
            this.txtHigerScore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUpScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rTxtShowAll
            // 
            this.rTxtShowAll.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtShowAll.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtShowAll.Location = new System.Drawing.Point(323, 455);
            this.rTxtShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtShowAll.Name = "rTxtShowAll";
            this.rTxtShowAll.ReadOnly = true;
            this.rTxtShowAll.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtShowAll.Size = new System.Drawing.Size(768, 149);
            this.rTxtShowAll.TabIndex = 31;
            this.rTxtShowAll.Text = "";
            // 
            // rTxtScoreList
            // 
            this.rTxtScoreList.BackColor = System.Drawing.SystemColors.Control;
            this.rTxtScoreList.Font = new System.Drawing.Font("標楷體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtScoreList.Location = new System.Drawing.Point(323, 33);
            this.rTxtScoreList.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtScoreList.Name = "rTxtScoreList";
            this.rTxtScoreList.ReadOnly = true;
            this.rTxtScoreList.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtScoreList.Size = new System.Drawing.Size(768, 404);
            this.rTxtScoreList.TabIndex = 30;
            this.rTxtScoreList.Text = "姓名         國文     數學     英文     總分     平均     最高     最低\n";
            // 
            // btnSearchChiScore
            // 
            this.btnSearchChiScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearchChiScore.Location = new System.Drawing.Point(67, 635);
            this.btnSearchChiScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchChiScore.Name = "btnSearchChiScore";
            this.btnSearchChiScore.Size = new System.Drawing.Size(160, 38);
            this.btnSearchChiScore.TabIndex = 29;
            this.btnSearchChiScore.Text = "SEARCH";
            this.btnSearchChiScore.UseVisualStyleBackColor = true;
            this.btnSearchChiScore.Click += new System.EventHandler(this.btnSearchChiScore_Click);
            // 
            // btnRefreshScoreList
            // 
            this.btnRefreshScoreList.Enabled = false;
            this.btnRefreshScoreList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefreshScoreList.Location = new System.Drawing.Point(29, 445);
            this.btnRefreshScoreList.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshScoreList.Name = "btnRefreshScoreList";
            this.btnRefreshScoreList.Size = new System.Drawing.Size(267, 50);
            this.btnRefreshScoreList.TabIndex = 28;
            this.btnRefreshScoreList.Text = "清除所有資料";
            this.btnRefreshScoreList.UseVisualStyleBackColor = true;
            this.btnRefreshScoreList.Click += new System.EventHandler(this.btnRefreshScoreList_Click);
            // 
            // btnRemoveAtValue
            // 
            this.btnRemoveAtValue.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveAtValue.Enabled = false;
            this.btnRemoveAtValue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAtValue.Location = new System.Drawing.Point(29, 387);
            this.btnRemoveAtValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveAtValue.Name = "btnRemoveAtValue";
            this.btnRemoveAtValue.Size = new System.Drawing.Size(267, 50);
            this.btnRemoveAtValue.TabIndex = 27;
            this.btnRemoveAtValue.Text = "移除資料";
            this.btnRemoveAtValue.UseVisualStyleBackColor = true;
            this.btnRemoveAtValue.Click += new System.EventHandler(this.btnRemoveAtValue_Click);
            // 
            // btnInsertValue
            // 
            this.btnInsertValue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertValue.Location = new System.Drawing.Point(29, 329);
            this.btnInsertValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertValue.Name = "btnInsertValue";
            this.btnInsertValue.Size = new System.Drawing.Size(267, 50);
            this.btnInsertValue.TabIndex = 26;
            this.btnInsertValue.Text = "插入學生資料";
            this.btnInsertValue.UseVisualStyleBackColor = true;
            this.btnInsertValue.Click += new System.EventHandler(this.btnInsertValue_Click);
            // 
            // btnAddStudentValue
            // 
            this.btnAddStudentValue.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddStudentValue.Location = new System.Drawing.Point(29, 271);
            this.btnAddStudentValue.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddStudentValue.Name = "btnAddStudentValue";
            this.btnAddStudentValue.Size = new System.Drawing.Size(267, 50);
            this.btnAddStudentValue.TabIndex = 25;
            this.btnAddStudentValue.Text = "加入學生資料";
            this.btnAddStudentValue.UseVisualStyleBackColor = true;
            this.btnAddStudentValue.Click += new System.EventHandler(this.btnAddStudentValue_Click);
            // 
            // txtEngScore
            // 
            this.txtEngScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngScore.Location = new System.Drawing.Point(132, 221);
            this.txtEngScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtEngScore.MaxLength = 3;
            this.txtEngScore.Name = "txtEngScore";
            this.txtEngScore.Size = new System.Drawing.Size(162, 42);
            this.txtEngScore.TabIndex = 24;
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(132, 159);
            this.txtMathScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtMathScore.MaxLength = 3;
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(162, 42);
            this.txtMathScore.TabIndex = 23;
            // 
            // txtChiScore
            // 
            this.txtChiScore.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChiScore.Location = new System.Drawing.Point(132, 97);
            this.txtChiScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiScore.MaxLength = 3;
            this.txtChiScore.Name = "txtChiScore";
            this.txtChiScore.Size = new System.Drawing.Size(162, 42);
            this.txtChiScore.TabIndex = 22;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStudentName.Location = new System.Drawing.Point(132, 33);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(162, 42);
            this.txtStudentName.TabIndex = 21;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEng.Location = new System.Drawing.Point(23, 221);
            this.labEng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(102, 36);
            this.labEng.TabIndex = 20;
            this.labEng.Text = "英文：";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(23, 159);
            this.labMath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(102, 36);
            this.labMath.TabIndex = 19;
            this.labMath.Text = "數學：";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChi.Location = new System.Drawing.Point(23, 103);
            this.labChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(102, 36);
            this.labChi.TabIndex = 18;
            this.labChi.Text = "國文：";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(23, 43);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(102, 36);
            this.labName.TabIndex = 17;
            this.labName.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(47, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 30);
            this.label1.TabIndex = 32;
            this.label1.Text = "搜尋國文成績範圍:";
            // 
            // txtLowerScore
            // 
            this.txtLowerScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLowerScore.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtLowerScore.Location = new System.Drawing.Point(61, 568);
            this.txtLowerScore.MaxLength = 3;
            this.txtLowerScore.Name = "txtLowerScore";
            this.txtLowerScore.Size = new System.Drawing.Size(70, 45);
            this.txtLowerScore.TabIndex = 33;
            this.txtLowerScore.Text = "低分";
            this.txtLowerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLowerScore.Enter += new System.EventHandler(this.txtLowerScore_Enter);
            this.txtLowerScore.Leave += new System.EventHandler(this.txtLowerScore_Leave);
            // 
            // txtHigerScore
            // 
            this.txtHigerScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtHigerScore.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtHigerScore.Location = new System.Drawing.Point(173, 569);
            this.txtHigerScore.Name = "txtHigerScore";
            this.txtHigerScore.Size = new System.Drawing.Size(70, 45);
            this.txtHigerScore.TabIndex = 34;
            this.txtHigerScore.Text = "高分";
            this.txtHigerScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHigerScore.Enter += new System.EventHandler(this.txtHigerScore_Enter);
            this.txtHigerScore.Leave += new System.EventHandler(this.txtHigerScore_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(137, 580);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 35;
            this.label2.Text = "~";
            // 
            // btnAddUpScore
            // 
            this.btnAddUpScore.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddUpScore.Enabled = false;
            this.btnAddUpScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAddUpScore.Location = new System.Drawing.Point(824, 612);
            this.btnAddUpScore.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUpScore.Name = "btnAddUpScore";
            this.btnAddUpScore.Size = new System.Drawing.Size(267, 50);
            this.btnAddUpScore.TabIndex = 36;
            this.btnAddUpScore.Text = "各科統計";
            this.btnAddUpScore.UseVisualStyleBackColor = true;
            this.btnAddUpScore.Click += new System.EventHandler(this.btnAddUpScore_Click);
            // 
            // Frm_StudentGradesList_06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 712);
            this.Controls.Add(this.btnAddUpScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHigerScore);
            this.Controls.Add(this.txtLowerScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtShowAll);
            this.Controls.Add(this.rTxtScoreList);
            this.Controls.Add(this.btnSearchChiScore);
            this.Controls.Add(this.btnRefreshScoreList);
            this.Controls.Add(this.btnRemoveAtValue);
            this.Controls.Add(this.btnInsertValue);
            this.Controls.Add(this.btnAddStudentValue);
            this.Controls.Add(this.txtEngScore);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.txtChiScore);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_StudentGradesList_06";
            this.Text = "Frm_06_StudentGradesList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rTxtShowAll;
        private System.Windows.Forms.RichTextBox rTxtScoreList;
        private System.Windows.Forms.Button btnSearchChiScore;
        private System.Windows.Forms.Button btnRefreshScoreList;
        private System.Windows.Forms.Button btnRemoveAtValue;
        private System.Windows.Forms.Button btnInsertValue;
        private System.Windows.Forms.Button btnAddStudentValue;
        private System.Windows.Forms.TextBox txtEngScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.TextBox txtChiScore;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLowerScore;
        private System.Windows.Forms.TextBox txtHigerScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddUpScore;
    }
}