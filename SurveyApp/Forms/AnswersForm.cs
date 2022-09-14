using SurveyApp.Extensions;
using SurveyApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurveyApp.Forms {
    /// <summary>
    /// This form provides a sortable list of questionnaire responses
    /// </summary>
    public partial class AnswersForm : Form {
        public AnswersForm() {
            InitializeComponent();
        }

        private void AnswersForm_VisibleChanged(object sender, EventArgs e) {
            /// Update the data in the DataGridView with the form is shown
            /// And use a sortable binding list (enables clicking the column name to sort)
            if (Visible) {
                Task.Factory.StartNew(() => {
                    using (var db = new SurveyContext()) {
                        db.SurveyAnswers.Load();
                        if (DgvAnswers.Visible) {
                            Invoke((Action)(() => {
                                DgvAnswers.DataSource = new SortableBindingList<SurveyAnswer>(db.SurveyAnswers.Local.ToList());
                            }));
                        }
                    }
                });
            }
        }
    }
}
