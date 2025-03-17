namespace Project
{
    partial class LevelsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox comboDifficulty;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ListBox lbLevels;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblTitle;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LevelsForm));
            comboDifficulty = new ComboBox();
            btnFilter = new Button();
            lbLevels = new ListBox();
            btnPlay = new Button();
            lblTitle = new Label();
            BackButton = new Button();
            SuspendLayout();
            // 
            // comboDifficulty
            // 
            comboDifficulty.DropDownStyle = ComboBoxStyle.DropDownList;
            comboDifficulty.Location = new Point(50, 60);
            comboDifficulty.Name = "comboDifficulty";
            comboDifficulty.Size = new Size(180, 23);
            comboDifficulty.TabIndex = 1;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(190, 175, 160);
            btnFilter.Location = new Point(250, 60);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(150, 40);
            btnFilter.TabIndex = 2;
            btnFilter.Text = "Фільтрувати";
            btnFilter.UseVisualStyleBackColor = false;
            // 
            // lbLevels
            // 
            lbLevels.BackColor = Color.White;
            lbLevels.ItemHeight = 15;
            lbLevels.Location = new Point(50, 120);
            lbLevels.Name = "lbLevels";
            lbLevels.Size = new Size(400, 169);
            lbLevels.TabIndex = 3;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(150, 75, 75);
            btnPlay.Enabled = false;
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(190, 320);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(150, 50);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Грати";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(30, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(440, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Оберіть рівень";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.FromArgb(190, 175, 160);
            BackButton.ForeColor = Color.Black;
            BackButton.Location = new Point(3, 12);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(111, 35);
            BackButton.TabIndex = 5;
            BackButton.Text = "Повернутися";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // LevelsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(500, 400);
            Controls.Add(BackButton);
            Controls.Add(lblTitle);
            Controls.Add(comboDifficulty);
            Controls.Add(btnFilter);
            Controls.Add(lbLevels);
            Controls.Add(btnPlay);
            ForeColor = Color.Black;
            Name = "LevelsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вибір рівня";
            Load += LevelsForm_Load_1;
            ResumeLayout(false);
        }
        private Button BackButton;
    }
}
