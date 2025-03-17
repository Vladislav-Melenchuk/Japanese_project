using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ProfileFrom : Form
    {
        private int completedPuzzles;
        private Label lblStats;
        public ProfileFrom()
        {
            InitializeComponent();
            LoadProgress();

            btnBack.Click += (s, e) =>
            {
                MainForm mainMenu = new MainForm();
                mainMenu.Show();
                this.Close();
            };
        }

        private void ProfileFrom_Load(object sender, EventArgs e)
        {

        }



        private void LoadProgress()
        {
            string path = "progress.txt";

            if (File.Exists(path))
            {

                int.TryParse(File.ReadAllText(path), out completedPuzzles);
            }

            lblStats.Text = $"Розв'язаних кросвордів: {completedPuzzles}";
        }

   
    


        private void ProfileFrom_Load_1(object sender, EventArgs e)
        {

        }

        private void ProfileFrom_Load_2(object sender, EventArgs e)
        {

        }
    }
}
