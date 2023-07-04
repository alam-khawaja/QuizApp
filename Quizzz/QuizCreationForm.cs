using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quizzz
{
    public partial class QuizCreationForm : Form
    {
        private string connectionString = "Data Source=DESKTOP-0BNMRNL\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        private List<QuestionControl> questionControls;

        public QuizCreationForm()
        {
            InitializeComponent();
            questionControls = new List<QuestionControl>();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            string subject = txtSubject.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Quiz (Subject, CreatedAt) VALUES (@Subject, @CreatedAt); SELECT SCOPE_IDENTITY();", connection);
                command.Parameters.AddWithValue("@Subject", subject);
                command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                int quizId = Convert.ToInt32(command.ExecuteScalar());

                foreach (QuestionControl questionControl in questionControls)
                {
                    string questionText = questionControl.QuestionText;

                    command = new SqlCommand("INSERT INTO Question (QuizId, QuestionText) VALUES (@QuizId, @QuestionText); SELECT SCOPE_IDENTITY();", connection);
                    command.Parameters.AddWithValue("@QuizId", quizId);
                    command.Parameters.AddWithValue("@QuestionText", questionText);

                    int questionId = Convert.ToInt32(command.ExecuteScalar());

                    
                }

                connection.Close();
            }

            MessageBox.Show("Quiz created successfully!");
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            QuestionControl questionControl = new QuestionControl();
            this.Controls.Add(questionControl);

            int yPos = questionControls.Count * questionControl.Height + 60;
            questionControl.Location = new Point(10, yPos);

            questionControls.Add(questionControl);
        }
    }
}
