using SurveyApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyApp.Forms {
    /// <summary>
    /// This form is the questionnaire that gathers the preferred programming language of the participant
    /// </summary>
    public partial class QuestionForm : Form {
        public QuestionForm() {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e) {
            /// Get the values from the form
            string name = TxbName.Text;
            string favLang = TxbFavLang.Text;

            /// Check that the values are set
            if (string.IsNullOrWhiteSpace(name)) {
                MessageBox.Show("Name must be filled in", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else if (string.IsNullOrWhiteSpace(favLang)) {
                MessageBox.Show("Favourite programming language must be filled in", "Field required", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else {

                /// Disable the buttons and create the SurveyAnswer object
                BtnSubmit.Text = "Submitting...";
                BtnSubmit.Enabled = false;

                var answer = new SurveyAnswer {
                    Name = name,
                    FavouriteProgrammingLanguage = favLang
                };

                Task.Factory.StartNew(() => {
                    /// Save the SurveyAnswer to the database
                    try {
                        using (var db = new SurveyContext()) {
                            db.SurveyAnswers.Add(answer);
                            db.SaveChanges();
                        }
                    } catch (Exception ex) {
                        /// Tell the user if there was an error
                        MessageBox.Show("There was an error storing your answer, please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        Console.Error.WriteLine("Save task failed: " + ex.ToString());

                        throw ex;
                    }
                })

                    .ContinueWith(success => {
                        /// On successful insertion into the database, clear the input text and thank the user
                        Invoke((Action)(() => {
                            TxbName.Clear();
                            TxbFavLang.Clear();
                        }));

                        MessageBox.Show("Thank you for filling in the survey", "Answer submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }, TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.ExecuteSynchronously)

                    .ContinueWith(final => {
                        /// Reset the button text
                        BtnSubmit.Invoke((Action)(() => {
                            BtnSubmit.Text = "Submit";
                            BtnSubmit.Enabled = true;
                        }));
                    }, TaskContinuationOptions.ExecuteSynchronously);
            }
        }

        private void BtnAnswers_Click(object sender, EventArgs e) {
            /// Create and show the answers form and hide this one
            var answersForm = new AnswersForm();
            this.Hide();
            var result = answersForm.ShowDialog();

            /// Show this form again if the other form returned, and close if the other form was closed
            if (result == DialogResult.OK) {
                this.Show();
            } else {
                this.Close();
            }
        }
    }
}
