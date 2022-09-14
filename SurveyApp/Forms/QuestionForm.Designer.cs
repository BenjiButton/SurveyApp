namespace SurveyApp.Forms {
    partial class QuestionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.LblFavLang = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxbFavLang = new System.Windows.Forms.TextBox();
            this.TxbName = new System.Windows.Forms.TextBox();
            this.BtnAnswers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.BtnSubmit);
            this.groupBox1.Controls.Add(this.LblFavLang);
            this.groupBox1.Controls.Add(this.LblName);
            this.groupBox1.Controls.Add(this.TxbFavLang);
            this.groupBox1.Controls.Add(this.TxbName);
            this.groupBox1.Location = new System.Drawing.Point(336, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please complete both fields and click Submit";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.Location = new System.Drawing.Point(10, 200);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(184, 29);
            this.BtnSubmit.TabIndex = 4;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // LblFavLang
            // 
            this.LblFavLang.AutoSize = true;
            this.LblFavLang.Location = new System.Drawing.Point(7, 119);
            this.LblFavLang.Name = "LblFavLang";
            this.LblFavLang.Size = new System.Drawing.Size(166, 13);
            this.LblFavLang.TabIndex = 3;
            this.LblFavLang.Text = "Favourite Programming Language";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(7, 62);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(54, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Full Name";
            // 
            // TxbFavLang
            // 
            this.TxbFavLang.Location = new System.Drawing.Point(10, 135);
            this.TxbFavLang.Name = "TxbFavLang";
            this.TxbFavLang.Size = new System.Drawing.Size(184, 20);
            this.TxbFavLang.TabIndex = 1;
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(10, 78);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(184, 20);
            this.TxbName.TabIndex = 0;
            // 
            // BtnAnswers
            // 
            this.BtnAnswers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnswers.Location = new System.Drawing.Point(346, 409);
            this.BtnAnswers.Name = "BtnAnswers";
            this.BtnAnswers.Size = new System.Drawing.Size(184, 29);
            this.BtnAnswers.TabIndex = 5;
            this.BtnAnswers.Text = "View Answers";
            this.BtnAnswers.UseVisualStyleBackColor = true;
            this.BtnAnswers.Click += new System.EventHandler(this.BtnAnswers_Click);
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.BtnAnswers);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuestionForm";
            this.Text = "Programming Language Survey Questions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.Label LblFavLang;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxbFavLang;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.Button BtnAnswers;
    }
}