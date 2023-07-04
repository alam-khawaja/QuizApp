namespace Quizzz
{
    partial class QuizCreationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnAddQuestion = new Button();
            btnCreateQuiz = new Button();
            txtSubject = new TextBox();
            textBox1 = new TextBox();
            Question = new Label();
            Answer = new Label();
            SuspendLayout();
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Location = new Point(386, 49);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(120, 30);
            btnAddQuestion.TabIndex = 1;
            btnAddQuestion.Text = "Add Question";
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.Location = new Point(208, 142);
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.Size = new Size(120, 30);
            btnCreateQuiz.TabIndex = 2;
            btnCreateQuiz.Text = "Create Quiz";
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(112, 30);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(242, 27);
            txtSubject.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 27);
            textBox1.TabIndex = 3;
            // 
            // Question
            // 
            Question.AutoSize = true;
            Question.Location = new Point(38, 35);
            Question.Name = "Question";
            Question.Size = new Size(50, 20);
            Question.TabIndex = 4;
            Question.Text = "Question";
            Question.Click += label1_Click;
            // 
            // Answer
            // 
            Answer.AutoSize = true;
            Answer.Location = new Point(38, 76);
            Answer.Name = "Answer";
            Answer.Size = new Size(50, 20);
            Answer.TabIndex = 5;
            Answer.Text = "Answer";
            // 
            // QuizCreationForm
            // 
            ClientSize = new Size(561, 202);
            Controls.Add(Answer);
            Controls.Add(Question);
            Controls.Add(textBox1);
            Controls.Add(txtSubject);
            Controls.Add(btnAddQuestion);
            Controls.Add(btnCreateQuiz);
            Name = "QuizCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz Creation Form";
            Load += QuizCreationForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        private void QuizCreationForm_Load_1(object sender, EventArgs e)
        {
            // Display a message box when the form is loaded
            MessageBox.Show("Quiz Creation Form loaded successfully!");

            // Additional logic or initialization code can be added here
            // ...
        }



        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.TextBox txtSubject;
        private TextBox textBox1;
        private Label Question;
        private Label Answer;

        // Other control declarations

        // ...
        // ...
    }
}
