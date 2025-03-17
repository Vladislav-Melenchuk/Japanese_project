using System;
using System.Linq;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace Project
{
    public partial class LevelsForm : Form
    {
        public LevelsForm()
        {
            InitializeComponent();
            this.Load += LevelsForm_Load;
            btnFilter.Click += BtnFilter_Click;
            lbLevels.SelectedIndexChanged += LbLevels_SelectedIndexChanged;
            btnPlay.Click += BtnPlay_Click;
        }

        private void LevelsForm_Load(object sender, EventArgs e)
        {
            comboDifficulty.Items.AddRange(new[] { "Easy", "Medium", "Hard" });
            comboDifficulty.SelectedIndex = 0;
            FilterLevels(comboDifficulty.SelectedItem.ToString());
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            FilterLevels(comboDifficulty.SelectedItem.ToString());
        }

        private void LbLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPlay.Enabled = lbLevels.SelectedIndex >= 0;
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            var selectedLevelName = lbLevels.SelectedItem?.ToString();
            if (selectedLevelName == null)
            {
                MessageBox.Show("Будь ласка, оберіть рівень перед початком гри.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var level = LevelRepository.GetLevel(selectedLevelName);
                if (level != null)
                {
                    var gameForm = new GameForm(level);
                    gameForm.Show();
                    this.Hide();
                }
            }
        }

        private void FilterLevels(string difficulty)
        {
            lbLevels.Items.Clear();
            var filteredLevels = LevelRepository.Levels
                .Where(level => level.Difficulty.ToString() == difficulty)
                .Select(level => level.Name)
                .ToArray();
            lbLevels.Items.AddRange(filteredLevels);
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LevelsForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
