namespace Project
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnReturn;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            btnClear = new Button();
            btnCheck = new Button();
            btnReturn = new Button();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(190, 175, 160);
            btnClear.Location = new Point(520, 150);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 50);
            btnClear.TabIndex = 1;
            btnClear.Text = "Очистити";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.FromArgb(150, 75, 75);
            btnCheck.ForeColor = Color.White;
            btnCheck.Location = new Point(520, 220);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(150, 50);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "Перевірити";
            btnCheck.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(100, 100, 100);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(520, 290);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(150, 50);
            btnReturn.TabIndex = 3;
            btnReturn.Text = "Назад";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(200, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(300, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Гра: Японський кросворд";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 700);
            Controls.Add(lblTitle);
            Controls.Add(btnClear);
            Controls.Add(btnCheck);
            Controls.Add(btnReturn);
            ForeColor = Color.Black;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Японський кросворд";
            Load += GameForm_Load_1;
            ResumeLayout(false);
        }
    }
}
