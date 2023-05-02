namespace Homework_Form
{
    partial class Frm_Guess_Test
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
            this.labShow = new System.Windows.Forms.Label();
            this.btnGuess = new System.Windows.Forms.Button();
            this.brnShowAns = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labShow.Location = new System.Drawing.Point(31, 91);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(473, 39);
            this.labShow.TabIndex = 0;
            this.labShow.Text = "Please Select A Number Between 1 to 100!";
            // 
            // btnGuess
            // 
            this.btnGuess.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuess.Location = new System.Drawing.Point(110, 190);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 58);
            this.btnGuess.TabIndex = 1;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // brnShowAns
            // 
            this.brnShowAns.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnShowAns.Location = new System.Drawing.Point(242, 190);
            this.brnShowAns.Name = "brnShowAns";
            this.brnShowAns.Size = new System.Drawing.Size(169, 58);
            this.brnShowAns.TabIndex = 2;
            this.brnShowAns.Text = "Show Answer";
            this.brnShowAns.UseVisualStyleBackColor = true;
            // 
            // Frm_Guess_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 393);
            this.Controls.Add(this.brnShowAns);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.labShow);
            this.Name = "Frm_Guess_Test";
            this.Text = "Frm_Guess_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Button brnShowAns;
    }
}