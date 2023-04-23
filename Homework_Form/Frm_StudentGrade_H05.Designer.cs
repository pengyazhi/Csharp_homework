namespace Homework_Form
{
    partial class Frm_StudentGrade_H05
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
            this.txtEngScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.txtChiScore = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.labEngScore = new System.Windows.Forms.Label();
            this.labMathScore = new System.Windows.Forms.Label();
            this.labChiScore = new System.Windows.Forms.Label();
            this.labStudentName = new System.Windows.Forms.Label();
            this.btnSaveStudentData = new System.Windows.Forms.Button();
            this.btnRadomSaveData = new System.Windows.Forms.Button();
            this.btnSubjectCount = new System.Windows.Forms.Button();
            this.btnResetGrade = new System.Windows.Forms.Button();
            this.btnRadom20 = new System.Windows.Forms.Button();
            this.rTxtBoxStudentGrade = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colChiScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMathScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEngScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAveScroe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHighestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLowestScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEngScore
            // 
            this.txtEngScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngScore.Location = new System.Drawing.Point(145, 232);
            this.txtEngScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtEngScore.MaxLength = 3;
            this.txtEngScore.Name = "txtEngScore";
            this.txtEngScore.Size = new System.Drawing.Size(115, 45);
            this.txtEngScore.TabIndex = 15;
            this.txtEngScore.Text = "0";
            this.txtEngScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(145, 155);
            this.txtMathScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtMathScore.MaxLength = 3;
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(115, 45);
            this.txtMathScore.TabIndex = 14;
            this.txtMathScore.Text = "0";
            this.txtMathScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChiScore
            // 
            this.txtChiScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChiScore.Location = new System.Drawing.Point(145, 86);
            this.txtChiScore.Margin = new System.Windows.Forms.Padding(4);
            this.txtChiScore.MaxLength = 3;
            this.txtChiScore.Name = "txtChiScore";
            this.txtChiScore.Size = new System.Drawing.Size(115, 45);
            this.txtChiScore.TabIndex = 13;
            this.txtChiScore.Text = "0";
            this.txtChiScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStudentName.Location = new System.Drawing.Point(145, 22);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtStudentName.MaxLength = 10;
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(115, 45);
            this.txtStudentName.TabIndex = 12;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEngScore
            // 
            this.labEngScore.AutoSize = true;
            this.labEngScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngScore.Location = new System.Drawing.Point(38, 235);
            this.labEngScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEngScore.Name = "labEngScore";
            this.labEngScore.Size = new System.Drawing.Size(99, 35);
            this.labEngScore.TabIndex = 11;
            this.labEngScore.Text = "英文：";
            // 
            // labMathScore
            // 
            this.labMathScore.AutoSize = true;
            this.labMathScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMathScore.Location = new System.Drawing.Point(38, 165);
            this.labMathScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMathScore.Name = "labMathScore";
            this.labMathScore.Size = new System.Drawing.Size(99, 35);
            this.labMathScore.TabIndex = 10;
            this.labMathScore.Text = "數學：";
            // 
            // labChiScore
            // 
            this.labChiScore.AutoSize = true;
            this.labChiScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChiScore.Location = new System.Drawing.Point(38, 96);
            this.labChiScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChiScore.Name = "labChiScore";
            this.labChiScore.Size = new System.Drawing.Size(99, 35);
            this.labChiScore.TabIndex = 9;
            this.labChiScore.Text = "國文：";
            // 
            // labStudentName
            // 
            this.labStudentName.AutoSize = true;
            this.labStudentName.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStudentName.Location = new System.Drawing.Point(38, 32);
            this.labStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labStudentName.Name = "labStudentName";
            this.labStudentName.Size = new System.Drawing.Size(99, 35);
            this.labStudentName.TabIndex = 8;
            this.labStudentName.Text = "姓名：";
            // 
            // btnSaveStudentData
            // 
            this.btnSaveStudentData.Location = new System.Drawing.Point(44, 292);
            this.btnSaveStudentData.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveStudentData.Name = "btnSaveStudentData";
            this.btnSaveStudentData.Size = new System.Drawing.Size(237, 50);
            this.btnSaveStudentData.TabIndex = 16;
            this.btnSaveStudentData.Text = "加入學生資料";
            this.btnSaveStudentData.UseVisualStyleBackColor = true;
            this.btnSaveStudentData.Click += new System.EventHandler(this.btnSaveStudentData_Click);
            // 
            // btnRadomSaveData
            // 
            this.btnRadomSaveData.Location = new System.Drawing.Point(44, 347);
            this.btnRadomSaveData.Margin = new System.Windows.Forms.Padding(4);
            this.btnRadomSaveData.Name = "btnRadomSaveData";
            this.btnRadomSaveData.Size = new System.Drawing.Size(237, 50);
            this.btnRadomSaveData.TabIndex = 17;
            this.btnRadomSaveData.Text = "隨機儲存資料";
            this.btnRadomSaveData.UseVisualStyleBackColor = true;
            // 
            // btnSubjectCount
            // 
            this.btnSubjectCount.Location = new System.Drawing.Point(44, 405);
            this.btnSubjectCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubjectCount.Name = "btnSubjectCount";
            this.btnSubjectCount.Size = new System.Drawing.Size(237, 50);
            this.btnSubjectCount.TabIndex = 18;
            this.btnSubjectCount.Text = "各科統計";
            this.btnSubjectCount.UseVisualStyleBackColor = true;
            // 
            // btnResetGrade
            // 
            this.btnResetGrade.Location = new System.Drawing.Point(44, 518);
            this.btnResetGrade.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetGrade.Name = "btnResetGrade";
            this.btnResetGrade.Size = new System.Drawing.Size(237, 50);
            this.btnResetGrade.TabIndex = 19;
            this.btnResetGrade.Text = "重設所有資料";
            this.btnResetGrade.UseVisualStyleBackColor = true;
            // 
            // btnRadom20
            // 
            this.btnRadom20.Location = new System.Drawing.Point(44, 576);
            this.btnRadom20.Margin = new System.Windows.Forms.Padding(4);
            this.btnRadom20.Name = "btnRadom20";
            this.btnRadom20.Size = new System.Drawing.Size(237, 50);
            this.btnRadom20.TabIndex = 20;
            this.btnRadom20.Text = "隨機加入20筆";
            this.btnRadom20.UseVisualStyleBackColor = true;
            // 
            // rTxtBoxStudentGrade
            // 
            this.rTxtBoxStudentGrade.BackColor = System.Drawing.SystemColors.Menu;
            this.rTxtBoxStudentGrade.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTxtBoxStudentGrade.Location = new System.Drawing.Point(312, 22);
            this.rTxtBoxStudentGrade.Margin = new System.Windows.Forms.Padding(4);
            this.rTxtBoxStudentGrade.Name = "rTxtBoxStudentGrade";
            this.rTxtBoxStudentGrade.ReadOnly = true;
            this.rTxtBoxStudentGrade.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtBoxStudentGrade.Size = new System.Drawing.Size(630, 473);
            this.rTxtBoxStudentGrade.TabIndex = 21;
            this.rTxtBoxStudentGrade.Text = "姓名　　 國文　　英文　　數學　　總分　　平均　　最高　　最低\n";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox2.Font = new System.Drawing.Font("標楷體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox2.Location = new System.Drawing.Point(312, 518);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(630, 120);
            this.richTextBox2.TabIndex = 22;
            this.richTextBox2.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentName,
            this.colChiScore,
            this.colMathScore,
            this.colEngScore,
            this.colTotalScore,
            this.colAveScroe,
            this.colHighestScore,
            this.colLowestScore});
            this.dataGridView1.Location = new System.Drawing.Point(331, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(619, 171);
            this.dataGridView1.TabIndex = 23;
            // 
            // colStudentName
            // 
            this.colStudentName.HeaderText = "姓名";
            this.colStudentName.MinimumWidth = 8;
            this.colStudentName.Name = "colStudentName";
            this.colStudentName.ReadOnly = true;
            // 
            // colChiScore
            // 
            this.colChiScore.HeaderText = "國文";
            this.colChiScore.MinimumWidth = 8;
            this.colChiScore.Name = "colChiScore";
            this.colChiScore.ReadOnly = true;
            this.colChiScore.Width = 80;
            // 
            // colMathScore
            // 
            this.colMathScore.HeaderText = "數學";
            this.colMathScore.MinimumWidth = 8;
            this.colMathScore.Name = "colMathScore";
            this.colMathScore.ReadOnly = true;
            this.colMathScore.Width = 70;
            // 
            // colEngScore
            // 
            this.colEngScore.HeaderText = "英文";
            this.colEngScore.MinimumWidth = 8;
            this.colEngScore.Name = "colEngScore";
            this.colEngScore.ReadOnly = true;
            this.colEngScore.Width = 70;
            // 
            // colTotalScore
            // 
            this.colTotalScore.HeaderText = "總分";
            this.colTotalScore.MinimumWidth = 8;
            this.colTotalScore.Name = "colTotalScore";
            this.colTotalScore.ReadOnly = true;
            this.colTotalScore.Width = 70;
            // 
            // colAveScroe
            // 
            this.colAveScroe.HeaderText = "平均";
            this.colAveScroe.MinimumWidth = 8;
            this.colAveScroe.Name = "colAveScroe";
            this.colAveScroe.ReadOnly = true;
            this.colAveScroe.Width = 90;
            // 
            // colHighestScore
            // 
            this.colHighestScore.HeaderText = "最高";
            this.colHighestScore.MinimumWidth = 8;
            this.colHighestScore.Name = "colHighestScore";
            this.colHighestScore.ReadOnly = true;
            this.colHighestScore.Width = 70;
            // 
            // colLowestScore
            // 
            this.colLowestScore.HeaderText = "最低";
            this.colLowestScore.MinimumWidth = 8;
            this.colLowestScore.Name = "colLowestScore";
            this.colLowestScore.ReadOnly = true;
            this.colLowestScore.Width = 70;
            // 
            // Frm_StudentGrade_H05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 658);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.rTxtBoxStudentGrade);
            this.Controls.Add(this.btnRadom20);
            this.Controls.Add(this.btnResetGrade);
            this.Controls.Add(this.btnSubjectCount);
            this.Controls.Add(this.btnRadomSaveData);
            this.Controls.Add(this.btnSaveStudentData);
            this.Controls.Add(this.txtEngScore);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.txtChiScore);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.labEngScore);
            this.Controls.Add(this.labMathScore);
            this.Controls.Add(this.labChiScore);
            this.Controls.Add(this.labStudentName);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_StudentGrade_H05";
            this.Text = "Student Grade Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEngScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.TextBox txtChiScore;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label labEngScore;
        private System.Windows.Forms.Label labMathScore;
        private System.Windows.Forms.Label labChiScore;
        private System.Windows.Forms.Label labStudentName;
        private System.Windows.Forms.Button btnSaveStudentData;
        private System.Windows.Forms.Button btnRadomSaveData;
        private System.Windows.Forms.Button btnSubjectCount;
        private System.Windows.Forms.Button btnResetGrade;
        private System.Windows.Forms.Button btnRadom20;
        private System.Windows.Forms.RichTextBox rTxtBoxStudentGrade;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChiScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMathScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEngScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAveScroe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHighestScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLowestScore;
    }
}