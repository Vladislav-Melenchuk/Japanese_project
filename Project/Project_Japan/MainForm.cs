using System;
using System.Windows.Forms;

namespace Project
{
    public partial class MainForm : Form
    {

        public static int completedPuzzles;
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            var levelsForm = new LevelsForm();
            levelsForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadProgress();
            btnStart.Click += btnStart_Click;
            this.Controls.Add(btnStart);

            btnExit.Click += btnExit_Click;
            this.Controls.Add(btnExit);
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void statsbutton_Click(object sender, EventArgs e)
        {
            
            var StatsForm = new ProfileFrom();
            StatsForm.Show();
            this.Hide();
        }

        public static void LoadProgress()
        {
            string path = "progress.txt";
            if (File.Exists(path))
            {
                int.TryParse(File.ReadAllText(path), out completedPuzzles);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
