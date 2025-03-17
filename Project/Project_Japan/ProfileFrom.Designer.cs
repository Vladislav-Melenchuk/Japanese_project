namespace Project
{
    partial class ProfileFrom
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

        private void InitializeComponent()
        {
            lblStats = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblStats
            // 
            this.lblStats = new Label
            {
                Text = $"Розв'язаних кросвордів: {0}", 
                Font = new Font("Arial", 16, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.Black,
                Location = new Point(50, 80)
            };
            this.Controls.Add(lblStats);
            // 
            // btnBack
            // 
            btnBack = new Button
            {
                Text = "Назад",
                Font = new Font("Arial", 12),
                Size = new Size(100, 40),
                Location = new Point(150, 200),
                BackColor = Color.Gray,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            this.Controls.Add(btnBack);
            // 
            // ProfileFrom
            // 
            BackColor = Color.FromArgb(240, 230, 210);
            ClientSize = new Size(384, 261);
            Controls.Add(lblStats);
            Controls.Add(btnBack);
            Name = "ProfileFrom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += ProfileFrom_Load_2;
            ResumeLayout(false);
        }
        private Button btnBack;
    }
}
