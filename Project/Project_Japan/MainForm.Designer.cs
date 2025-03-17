namespace Project
{
    partial class MainForm
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

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnStart = new Button();
            btnExit = new Button();
            lblTitle = new Label();
            statsbutton = new Button();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(190, 175, 160);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnStart.ForeColor = Color.Black;
            btnStart.Location = new Point(300, 222);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(200, 60);
            btnStart.TabIndex = 0;
            btnStart.Text = "Почати";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(150, 75, 75);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Arial", 14F, FontStyle.Bold);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(300, 382);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 60);
            btnExit.TabIndex = 1;
            btnExit.Text = "Вихід";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 24F, FontStyle.Bold);
            lblTitle.Location = new Point(202, 136);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 50);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Японський кросворд";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Click += lblTitle_Click;
            // 
            // statsbutton
            // 
            statsbutton.BackColor = Color.FromArgb(190, 175, 160);
            statsbutton.FlatStyle = FlatStyle.Flat;
            statsbutton.Font = new Font("Arial", 14F, FontStyle.Bold);
            statsbutton.ForeColor = Color.Black;
            statsbutton.Location = new Point(300, 300);
            statsbutton.Name = "statsbutton";
            statsbutton.Size = new Size(200, 60);
            statsbutton.TabIndex = 3;
            statsbutton.Text = "Статистика";
            statsbutton.UseVisualStyleBackColor = false;
            statsbutton.Click += statsbutton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 600);
            Controls.Add(statsbutton);
            Controls.Add(lblTitle);
            Controls.Add(btnStart);
            Controls.Add(btnExit);
            ForeColor = Color.Black;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Японський кросворд";
            Load += MainForm_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private Button btnExit;
        private Label lblTitle;
        private Button statsbutton;
    }
}