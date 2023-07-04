using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quizzz
{
    public partial class QuestionControl : UserControl
    {
        private TextBox txtQuestion;
        private TextBox txtAnswer;

        public string QuestionText => txtQuestion.Text;
        public string AnswerText => txtAnswer.Text;

        private void InitializeComponent()
        {
            txtQuestion = new TextBox();
            txtAnswer = new TextBox();

            this.SuspendLayout();
            this.Size = new Size(400, 100);

            // Question TextBox
            txtQuestion.Size = new Size(300, 20);
            txtQuestion.Location = new Point(10, 10);
            this.Controls.Add(txtQuestion);

            // Answer TextBox
            txtAnswer.Size = new Size(300, 20);
            txtAnswer.Location = new Point(10, 40);
            this.Controls.Add(txtAnswer);

            this.ResumeLayout(false);
        }
    }
}
