using System;
using System.Windows.Forms;

namespace Quizzz
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnTakeQuiz_Click(object sender, EventArgs e)
        {
            // Handle button click event for "Take Quiz" button
            TakeQuizForm takeQuizForm = new TakeQuizForm();
            takeQuizForm.ShowDialog();
        }

        private void btnCreateQuiz_Click(object sender, EventArgs e)
        {
            // Handle button click event for "Create Quiz" button
            QuizCreationForm quizCreationForm = new QuizCreationForm();
            quizCreationForm.ShowDialog();
        }

        private void btnViewScores_Click(object sender, EventArgs e)
        {
            // Handle button click event for "View Scores" button
            ViewScoresForm viewScoresForm = new ViewScoresForm();
            viewScoresForm.ShowDialog();
        }



        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Perform any initialization or setup tasks when the DashboardForm is loaded

            // Example: Set the title of the DashboardForm
            this.Text = "Quiz App Dashboard";
        }

    }
}
