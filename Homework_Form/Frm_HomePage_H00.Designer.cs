namespace Homework_Form
{
    partial class Frm_HomePage_H00
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HomePage_H00));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.btnOpneHelloForm = new System.Windows.Forms.Button();
            this.btnStudentStrucrForm = new System.Windows.Forms.Button();
            this.btnStudentGradeList = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnStudentGrade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.splitContainer1.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1388, 969);
            this.splitContainer1.SplitterDistance = 176;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer2.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel1.BackgroundImage")));
            this.splitContainer2.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer2.Panel1.Controls.Add(this.btnCalculator);
            this.splitContainer2.Panel1.Controls.Add(this.btnOpneHelloForm);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentStrucrForm);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentGradeList);
            this.splitContainer2.Panel1.Controls.Add(this.btnPOS);
            this.splitContainer2.Panel1.Controls.Add(this.btnLoan);
            this.splitContainer2.Panel1.Controls.Add(this.btnStudentGrade);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.splitContainer2.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer2.Panel2.BackgroundImage")));
            this.splitContainer2.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.splitContainer2.Panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.splitContainer2.Panel2.Padding = new System.Windows.Forms.Padding(4);
            this.splitContainer2.Size = new System.Drawing.Size(1388, 787);
            this.splitContainer2.SplitterDistance = 345;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnCalculator
            // 
            this.btnCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculator.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalculator.BackColor = System.Drawing.Color.IndianRed;
            this.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculator.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Salmon;
            this.btnCalculator.Location = new System.Drawing.Point(29, 415);
            this.btnCalculator.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(280, 45);
            this.btnCalculator.TabIndex = 6;
            this.btnCalculator.Text = "Calculator";
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // btnOpneHelloForm
            // 
            this.btnOpneHelloForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpneHelloForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOpneHelloForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnOpneHelloForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpneHelloForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpneHelloForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpneHelloForm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpneHelloForm.ForeColor = System.Drawing.Color.Salmon;
            this.btnOpneHelloForm.Location = new System.Drawing.Point(32, 15);
            this.btnOpneHelloForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnOpneHelloForm.Name = "btnOpneHelloForm";
            this.btnOpneHelloForm.Size = new System.Drawing.Size(280, 45);
            this.btnOpneHelloForm.TabIndex = 0;
            this.btnOpneHelloForm.Text = "Opne Hello Form";
            this.btnOpneHelloForm.UseVisualStyleBackColor = false;
            this.btnOpneHelloForm.Click += new System.EventHandler(this.btnOpneHelloForm_Click);
            // 
            // btnStudentStrucrForm
            // 
            this.btnStudentStrucrForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentStrucrForm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentStrucrForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudentStrucrForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentStrucrForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStudentStrucrForm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentStrucrForm.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentStrucrForm.ForeColor = System.Drawing.Color.Salmon;
            this.btnStudentStrucrForm.Location = new System.Drawing.Point(32, 206);
            this.btnStudentStrucrForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentStrucrForm.Name = "btnStudentStrucrForm";
            this.btnStudentStrucrForm.Size = new System.Drawing.Size(280, 45);
            this.btnStudentStrucrForm.TabIndex = 3;
            this.btnStudentStrucrForm.Text = "Student Strucr Form";
            this.btnStudentStrucrForm.UseVisualStyleBackColor = false;
            this.btnStudentStrucrForm.Click += new System.EventHandler(this.btnStudentStrucrForm_Click);
            // 
            // btnStudentGradeList
            // 
            this.btnStudentGradeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentGradeList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentGradeList.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudentGradeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentGradeList.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStudentGradeList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentGradeList.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentGradeList.ForeColor = System.Drawing.Color.Salmon;
            this.btnStudentGradeList.Location = new System.Drawing.Point(29, 345);
            this.btnStudentGradeList.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentGradeList.Name = "btnStudentGradeList";
            this.btnStudentGradeList.Size = new System.Drawing.Size(280, 45);
            this.btnStudentGradeList.TabIndex = 5;
            this.btnStudentGradeList.Text = "StudentGrade List";
            this.btnStudentGradeList.UseVisualStyleBackColor = false;
            this.btnStudentGradeList.Click += new System.EventHandler(this.btnStudentGradeList_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPOS.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnPOS.BackColor = System.Drawing.Color.IndianRed;
            this.btnPOS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPOS.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPOS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPOS.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOS.ForeColor = System.Drawing.Color.Salmon;
            this.btnPOS.Location = new System.Drawing.Point(32, 139);
            this.btnPOS.Margin = new System.Windows.Forms.Padding(4);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(280, 45);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "POS";
            this.btnPOS.UseVisualStyleBackColor = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoan.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoan.BackColor = System.Drawing.Color.IndianRed;
            this.btnLoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoan.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.ForeColor = System.Drawing.Color.Salmon;
            this.btnLoan.Location = new System.Drawing.Point(32, 77);
            this.btnLoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(280, 45);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = false;
            this.btnLoan.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnStudentGrade
            // 
            this.btnStudentGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStudentGrade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStudentGrade.BackColor = System.Drawing.Color.IndianRed;
            this.btnStudentGrade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentGrade.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStudentGrade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStudentGrade.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentGrade.ForeColor = System.Drawing.Color.Salmon;
            this.btnStudentGrade.Location = new System.Drawing.Point(32, 276);
            this.btnStudentGrade.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentGrade.Name = "btnStudentGrade";
            this.btnStudentGrade.Size = new System.Drawing.Size(280, 45);
            this.btnStudentGrade.TabIndex = 4;
            this.btnStudentGrade.Text = "StudentGrade";
            this.btnStudentGrade.UseVisualStyleBackColor = false;
            this.btnStudentGrade.Click += new System.EventHandler(this.btnStudentGrade_Click);
            // 
            // Frm_HomePage_H00
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1388, 969);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_HomePage_H00";
            this.Text = "Homework_C#_21";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnOpneHelloForm;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Button btnStudentStrucrForm;
        private System.Windows.Forms.Button btnStudentGrade;
        private System.Windows.Forms.Button btnStudentGradeList;
        private System.Windows.Forms.Button btnCalculator;
    }
}

