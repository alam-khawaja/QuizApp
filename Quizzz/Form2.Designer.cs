namespace Quizzz
{
    partial class DashboardForm
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
            btnTakeQuiz = new Button();
            btnCreateQuiz = new Button();
            btnViewScores = new Button();
            SuspendLayout();
            // 
            // btnTakeQuiz
            // 
            btnTakeQuiz.Location = new Point(67, 77);
            btnTakeQuiz.Margin = new Padding(4, 5, 4, 5);
            btnTakeQuiz.Name = "btnTakeQuiz";
            btnTakeQuiz.Size = new Size(200, 77);
            btnTakeQuiz.TabIndex = 2;
            btnTakeQuiz.Text = "Take Quiz";
            btnTakeQuiz.UseVisualStyleBackColor = true;
            btnTakeQuiz.Click += btnTakeQuiz_Click;
            // 
            // btnCreateQuiz
            // 
            btnCreateQuiz.Location = new Point(67, 185);
            btnCreateQuiz.Margin = new Padding(4, 5, 4, 5);
            btnCreateQuiz.Name = "btnCreateQuiz";
            btnCreateQuiz.Size = new Size(200, 77);
            btnCreateQuiz.TabIndex = 1;
            btnCreateQuiz.Text = "Create Quiz";
            btnCreateQuiz.UseVisualStyleBackColor = true;
            btnCreateQuiz.Click += btnCreateQuiz_Click;
            // 
            // btnViewScores
            // 
            btnViewScores.Location = new Point(67, 292);
            btnViewScores.Margin = new Padding(4, 5, 4, 5);
            btnViewScores.Name = "btnViewScores";
            btnViewScores.Size = new Size(200, 77);
            btnViewScores.TabIndex = 0;
            btnViewScores.Text = "View Scores";
            btnViewScores.UseVisualStyleBackColor = true;
            btnViewScores.Click += btnViewScores_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 462);
            Controls.Add(btnViewScores);
            Controls.Add(btnCreateQuiz);
            Controls.Add(btnTakeQuiz);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += DashboardForm_Load;
            ResumeLayout(false);
        }


        private System.Windows.Forms.Button btnTakeQuiz;
        private System.Windows.Forms.Button btnCreateQuiz;
        private System.Windows.Forms.Button btnViewScores;
    }
}
