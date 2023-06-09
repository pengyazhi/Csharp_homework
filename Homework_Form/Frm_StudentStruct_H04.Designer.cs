﻿namespace Homework_Form
{
    partial class Frm_StudentStruct_H04
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
            this.labStudentName = new System.Windows.Forms.Label();
            this.labChiScore = new System.Windows.Forms.Label();
            this.labMathScore = new System.Windows.Forms.Label();
            this.labEngScore = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtChiScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.txtEngScore = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowSaved = new System.Windows.Forms.Button();
            this.gBoxScore = new System.Windows.Forms.GroupBox();
            this.labMaxMinScore = new System.Windows.Forms.Label();
            this.labNameScore = new System.Windows.Forms.Label();
            this.btnShowMaxMin = new System.Windows.Forms.Button();
            this.gBoxScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // labStudentName
            // 
            this.labStudentName.AutoSize = true;
            this.labStudentName.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStudentName.Location = new System.Drawing.Point(98, 81);
            this.labStudentName.Name = "labStudentName";
            this.labStudentName.Size = new System.Drawing.Size(99, 35);
            this.labStudentName.TabIndex = 0;
            this.labStudentName.Text = "姓名：";
            // 
            // labChiScore
            // 
            this.labChiScore.AutoSize = true;
            this.labChiScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChiScore.Location = new System.Drawing.Point(98, 152);
            this.labChiScore.Name = "labChiScore";
            this.labChiScore.Size = new System.Drawing.Size(99, 35);
            this.labChiScore.TabIndex = 1;
            this.labChiScore.Text = "國文：";
            // 
            // labMathScore
            // 
            this.labMathScore.AutoSize = true;
            this.labMathScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMathScore.Location = new System.Drawing.Point(98, 222);
            this.labMathScore.Name = "labMathScore";
            this.labMathScore.Size = new System.Drawing.Size(99, 35);
            this.labMathScore.TabIndex = 2;
            this.labMathScore.Text = "數學：";
            // 
            // labEngScore
            // 
            this.labEngScore.AutoSize = true;
            this.labEngScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngScore.Location = new System.Drawing.Point(98, 296);
            this.labEngScore.Name = "labEngScore";
            this.labEngScore.Size = new System.Drawing.Size(99, 35);
            this.labEngScore.TabIndex = 3;
            this.labEngScore.Text = "英文：";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStudentName.Location = new System.Drawing.Point(202, 75);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(162, 45);
            this.txtStudentName.TabIndex = 4;
            this.txtStudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChiScore
            // 
            this.txtChiScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChiScore.Location = new System.Drawing.Point(202, 146);
            this.txtChiScore.MaxLength = 3;
            this.txtChiScore.Name = "txtChiScore";
            this.txtChiScore.Size = new System.Drawing.Size(162, 45);
            this.txtChiScore.TabIndex = 5;
            this.txtChiScore.Text = "0";
            this.txtChiScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChiScore.Enter += new System.EventHandler(this.txtChiScore_Enter);
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(202, 216);
            this.txtMathScore.MaxLength = 3;
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(162, 45);
            this.txtMathScore.TabIndex = 6;
            this.txtMathScore.Text = "0";
            this.txtMathScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMathScore.Enter += new System.EventHandler(this.txtMathScore_Enter);
            // 
            // txtEngScore
            // 
            this.txtEngScore.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngScore.Location = new System.Drawing.Point(202, 290);
            this.txtEngScore.MaxLength = 3;
            this.txtEngScore.Name = "txtEngScore";
            this.txtEngScore.Size = new System.Drawing.Size(162, 45);
            this.txtEngScore.TabIndex = 7;
            this.txtEngScore.Text = "0";
            this.txtEngScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEngScore.Enter += new System.EventHandler(this.txtEngScore_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(52, 386);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 70);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowSaved
            // 
            this.btnShowSaved.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSaved.Location = new System.Drawing.Point(226, 386);
            this.btnShowSaved.Name = "btnShowSaved";
            this.btnShowSaved.Size = new System.Drawing.Size(190, 70);
            this.btnShowSaved.TabIndex = 9;
            this.btnShowSaved.Text = "顯示儲存內容";
            this.btnShowSaved.UseVisualStyleBackColor = true;
            this.btnShowSaved.Click += new System.EventHandler(this.btnShowSaved_Click);
            // 
            // gBoxScore
            // 
            this.gBoxScore.Controls.Add(this.labMaxMinScore);
            this.gBoxScore.Controls.Add(this.labNameScore);
            this.gBoxScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gBoxScore.Location = new System.Drawing.Point(447, 70);
            this.gBoxScore.Name = "gBoxScore";
            this.gBoxScore.Size = new System.Drawing.Size(417, 435);
            this.gBoxScore.TabIndex = 10;
            this.gBoxScore.TabStop = false;
            this.gBoxScore.Text = "成績";
            // 
            // labMaxMinScore
            // 
            this.labMaxMinScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMaxMinScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMaxMinScore.Location = new System.Drawing.Point(6, 310);
            this.labMaxMinScore.Name = "labMaxMinScore";
            this.labMaxMinScore.Size = new System.Drawing.Size(406, 113);
            this.labMaxMinScore.TabIndex = 1;
            // 
            // labNameScore
            // 
            this.labNameScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labNameScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameScore.Location = new System.Drawing.Point(6, 28);
            this.labNameScore.Name = "labNameScore";
            this.labNameScore.Size = new System.Drawing.Size(406, 272);
            this.labNameScore.TabIndex = 0;
            // 
            // btnShowMaxMin
            // 
            this.btnShowMaxMin.Font = new System.Drawing.Font("微軟正黑體", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowMaxMin.Location = new System.Drawing.Point(590, 512);
            this.btnShowMaxMin.Name = "btnShowMaxMin";
            this.btnShowMaxMin.Size = new System.Drawing.Size(274, 54);
            this.btnShowMaxMin.TabIndex = 11;
            this.btnShowMaxMin.Text = "顯示最高分/最低分科目";
            this.btnShowMaxMin.UseVisualStyleBackColor = true;
            this.btnShowMaxMin.Click += new System.EventHandler(this.btnShowMaxMin_Click);
            // 
            // Frm_StudentStruct_H04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 596);
            this.Controls.Add(this.btnShowMaxMin);
            this.Controls.Add(this.gBoxScore);
            this.Controls.Add(this.btnShowSaved);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEngScore);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.txtChiScore);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.labEngScore);
            this.Controls.Add(this.labMathScore);
            this.Controls.Add(this.labChiScore);
            this.Controls.Add(this.labStudentName);
            this.Name = "Frm_StudentStruct_H04";
            this.Text = "Student Sturct Form";
            this.gBoxScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStudentName;
        private System.Windows.Forms.Label labChiScore;
        private System.Windows.Forms.Label labMathScore;
        private System.Windows.Forms.Label labEngScore;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtChiScore;
        private System.Windows.Forms.TextBox txtMathScore;
        private System.Windows.Forms.TextBox txtEngScore;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowSaved;
        private System.Windows.Forms.GroupBox gBoxScore;
        private System.Windows.Forms.Button btnShowMaxMin;
        private System.Windows.Forms.Label labMaxMinScore;
        private System.Windows.Forms.Label labNameScore;
    }
}