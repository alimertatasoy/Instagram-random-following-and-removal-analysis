namespace instagram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnGetAnalytics = new Button();
            panel1 = new Panel();
            btnUnfollowNonFollowers = new Button();
            btnFollowTenUsers = new Button();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(885, 486);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(282, 39);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(885, 559);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(282, 39);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(846, 635);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(282, 46);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGetAnalytics
            // 
            btnGetAnalytics.Location = new Point(126, 296);
            btnGetAnalytics.Name = "btnGetAnalytics";
            btnGetAnalytics.Size = new Size(282, 46);
            btnGetAnalytics.TabIndex = 3;
            btnGetAnalytics.Text = "Analitik Verileri ver";
            btnGetAnalytics.UseVisualStyleBackColor = true;
            btnGetAnalytics.Click += btnGetAnalytics_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnUnfollowNonFollowers);
            panel1.Controls.Add(btnFollowTenUsers);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnGetAnalytics);
            panel1.Location = new Point(52, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(549, 686);
            panel1.TabIndex = 5;
            // 
            // btnUnfollowNonFollowers
            // 
            btnUnfollowNonFollowers.Location = new Point(288, 513);
            btnUnfollowNonFollowers.Name = "btnUnfollowNonFollowers";
            btnUnfollowNonFollowers.Size = new Size(200, 86);
            btnUnfollowNonFollowers.TabIndex = 14;
            btnUnfollowNonFollowers.Text = "Takipten Çıkar!";
            btnUnfollowNonFollowers.UseVisualStyleBackColor = true;
            btnUnfollowNonFollowers.Click += btnUnfollowNonFollowers_Click;
            // 
            // btnFollowTenUsers
            // 
            btnFollowTenUsers.Location = new Point(44, 513);
            btnFollowTenUsers.Name = "btnFollowTenUsers";
            btnFollowTenUsers.Size = new Size(200, 86);
            btnFollowTenUsers.TabIndex = 13;
            btnFollowTenUsers.Text = "Takip Et!";
            btnFollowTenUsers.UseVisualStyleBackColor = true;
            btnFollowTenUsers.Click += btnFollowTenUsers_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(97, 436);
            label11.Name = "label11";
            label11.Size = new Size(343, 39);
            label11.TabIndex = 12;
            label11.Text = "Takipçi Otomasyonu";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(332, 222);
            label10.Name = "label10";
            label10.Size = new Size(91, 32);
            label10.TabIndex = 11;
            label10.Text = "label10";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(330, 165);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 10;
            label9.Text = "label9";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(330, 108);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 9;
            label8.Text = "label8";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 165);
            label7.Name = "label7";
            label7.Size = new Size(209, 32);
            label7.TabIndex = 8;
            label7.Text = "Takip edilen sayısı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 222);
            label6.Name = "label6";
            label6.Size = new Size(170, 32);
            label6.TabIndex = 7;
            label6.Text = "Gönderi Sayısı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 108);
            label5.Name = "label5";
            label5.Size = new Size(202, 32);
            label5.TabIndex = 6;
            label5.Text = "İnstagram Takipçi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(127, 26);
            label4.Name = "label4";
            label4.Size = new Size(267, 39);
            label4.TabIndex = 5;
            label4.Text = "Analitik Verileri";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(645, 365);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(33, 379);
            label1.Name = "label1";
            label1.Size = new Size(580, 35);
            label1.TabIndex = 7;
            label1.Text = "Instagram Hesabı Yönetim Sistemi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(732, 489);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 8;
            label2.Text = "Kullanıcı adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(812, 562);
            label3.Name = "label3";
            label3.Size = new Size(67, 32);
            label3.TabIndex = 9;
            label3.Text = "Şifre:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(665, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(645, 686);
            panel2.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 807);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(panel1);
            Controls.Add(txtUsername);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnGetAnalytics;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnUnfollowNonFollowers;
        private Button btnFollowTenUsers;
        private Label label11;
    }
}