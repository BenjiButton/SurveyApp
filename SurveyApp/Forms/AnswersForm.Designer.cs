namespace SurveyApp.Forms {
    partial class AnswersForm {
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
            this.BtnAnswers = new System.Windows.Forms.Button();
            this.DgvAnswers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnswers)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAnswers
            // 
            this.BtnAnswers.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnAnswers.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnswers.Location = new System.Drawing.Point(346, 409);
            this.BtnAnswers.Name = "BtnAnswers";
            this.BtnAnswers.Size = new System.Drawing.Size(184, 29);
            this.BtnAnswers.TabIndex = 6;
            this.BtnAnswers.Text = "View Questions";
            this.BtnAnswers.UseVisualStyleBackColor = true;
            // 
            // DgvAnswers
            // 
            this.DgvAnswers.AllowUserToAddRows = false;
            this.DgvAnswers.AllowUserToDeleteRows = false;
            this.DgvAnswers.AllowUserToOrderColumns = true;
            this.DgvAnswers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAnswers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAnswers.Location = new System.Drawing.Point(12, 12);
            this.DgvAnswers.Name = "DgvAnswers";
            this.DgvAnswers.ReadOnly = true;
            this.DgvAnswers.Size = new System.Drawing.Size(849, 391);
            this.DgvAnswers.TabIndex = 7;
            // 
            // AnswersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.DgvAnswers);
            this.Controls.Add(this.BtnAnswers);
            this.Name = "AnswersForm";
            this.Text = "Programming Language Survey Answers";
            this.VisibleChanged += new System.EventHandler(this.AnswersForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnswers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAnswers;
        private System.Windows.Forms.DataGridView DgvAnswers;
    }
}