using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class GameForm : Form
    {
        private Level selectedLevel;
        private int gridSize;
        private Button[,] crosswordGrid;
        private Panel gamePanel;
        private Panel rowHintPanel;
        private Panel colHintPanel;
        private FlowLayoutPanel buttonPanel;

        private int completedPuzzles;

        public GameForm(Level level)
        {
            InitializeComponent();
            selectedLevel = level;
            this.Load += GameForm_Load;
        }

        private void LoadProgress()
        {
            string path = "progress.txt";
            if (File.Exists(path))
            {
              
                string progressText = File.ReadAllText(path);
                if (int.TryParse(progressText, out int loadedProgress))
                {
                    completedPuzzles = loadedProgress;
                }
            }
            else
            {
                
                completedPuzzles = 0;
            }

            
            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            LoadProgress();
            gridSize = selectedLevel.GridSize;
            crosswordGrid = new Button[gridSize, gridSize];

            
            this.Controls.Clear();
            this.Size = gridSize >= 10 ? new Size(1100, 950) : new Size(800, 800);

            
            gamePanel = new Panel
            {
                Location = new Point(120, 120),
                Size = new Size(gridSize * 50, gridSize * 50),
                AutoScroll = true
            };
            this.Controls.Add(gamePanel);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                Screen.PrimaryScreen.Bounds.Width / 2 - this.Width / 2,
                Screen.PrimaryScreen.Bounds.Height / 2 - this.Height / 2
            );

            InitializeGrid();
            DisplayHints();

            
            buttonPanel = new FlowLayoutPanel
            {
                Location = new Point(gamePanel.Right + 20, gamePanel.Top),
                AutoSize = true,
                FlowDirection = FlowDirection.TopDown,
                BackColor = Color.Transparent
            };

            buttonPanel.Controls.Add(CreateButton("Очистити", BtnClear_Click, Color.FromArgb(190, 175, 160), Color.Black));
            buttonPanel.Controls.Add(CreateButton("Перевірити", BtnCheck_Click, Color.FromArgb(150, 75, 75), Color.White));
            buttonPanel.Controls.Add(CreateButton("Назад", BtnReturn_Click, Color.Gray, Color.White));

            this.Controls.Add(buttonPanel);
        }

        private Button CreateButton(string text, EventHandler clickEvent, Color bgColor, Color textColor)
        {
            Button btn = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                ForeColor = textColor,
                Width = 120,
                Height = 40,
                BackColor = bgColor,  
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = bgColor, MouseDownBackColor = bgColor }
            };
            btn.Click += clickEvent;
            return btn;
        }

        private void SaveProgress()
        {
            string path = "progress.txt";
            File.WriteAllText(path, completedPuzzles.ToString());
        }


        private void InitializeGrid()
        {
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    crosswordGrid[i, j] = new Button
                    {
                        Size = new Size(50, 50),
                        Location = new Point(50 * j, 50 * i),
                        BackColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Arial", 16, FontStyle.Bold)
                    };
                    crosswordGrid[i, j].Click += Cell_Click;
                    gamePanel.Controls.Add(crosswordGrid[i, j]);
                }
            }
        }

        private void DisplayHints()
        {
            
            if (rowHintPanel != null) this.Controls.Remove(rowHintPanel);
            if (colHintPanel != null) this.Controls.Remove(colHintPanel);

            
            rowHintPanel = CreateRoundedPanel(new Point(20, gamePanel.Top), new Size(100, gamePanel.Height));
            this.Controls.Add(rowHintPanel);

            
            colHintPanel = CreateRoundedPanel(new Point(gamePanel.Left, 20), new Size(gamePanel.Width, 100));
            this.Controls.Add(colHintPanel);

            
            for (int i = 0; i < gridSize; i++)
            {
                Label rowHintLabel = new Label
                {
                    Text = string.Join(" ", selectedLevel.RowHints[i]),
                    Location = new Point(10, 50 * i),
                    Size = new Size(80, 30),
                    TextAlign = ContentAlignment.MiddleRight,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    BackColor = Color.Transparent
                };
                rowHintPanel.Controls.Add(rowHintLabel);
            }

            
            for (int j = 0; j < gridSize; j++)
            {
                Label colHintLabel = new Label
                {
                    Text = string.Join("\n", selectedLevel.ColHints[j]),
                    Location = new Point(50 * j, 10),
                    Size = new Size(50, 90),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    BackColor = Color.Transparent
                };
                colHintPanel.Controls.Add(colHintLabel);
            }
        }

        private Panel CreateRoundedPanel(Point location, Size size)
        {
            Panel panel = new Panel
            {
                Location = location,
                Size = size,
                BackColor = Color.FromArgb(200, 200, 200),
                Region = new Region(CreateRoundedRectangle(size, 20)) 
            };
            return panel;
        }

        private GraphicsPath CreateRoundedRectangle(Size size, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(size.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(size.Width - radius, size.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, size.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                button.BackColor = button.BackColor == Color.Black ? Color.White : Color.Black;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            foreach (var button in crosswordGrid)
            {
                button.BackColor = Color.White;
            }
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            bool isCorrect = true;

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    bool isBlack = crosswordGrid[i, j].BackColor == Color.Black;
                    if (isBlack != selectedLevel.Solution[i, j])
                    {
                        isCorrect = false;
                    }
                }
            }

            if (isCorrect)
            {
                completedPuzzles++;  
                SaveProgress(); 
                MessageBox.Show("Вітаємо! Ви розв'язали кросворд!", "Перевірка завершена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Є помилки. Спробуйте ще раз.", "Перевірка завершена", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var levelsForm = new LevelsForm();
            levelsForm.Show();
        }

        private void GameForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
