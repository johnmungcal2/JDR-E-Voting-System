namespace WinFormsApp1
{
    partial class Form3
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            logoutButton = new Button();
            panel3 = new Panel();
            profileButton = new Button();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            passwordLabel = new Label();
            label14 = new Label();
            panel14 = new Panel();
            panel15 = new Panel();
            addressLabel = new Label();
            label12 = new Label();
            panel12 = new Panel();
            panel13 = new Panel();
            sexLabel = new Label();
            label9 = new Label();
            panel10 = new Panel();
            panel11 = new Panel();
            ageLabel = new Label();
            lastNameLabel = new Label();
            firstNameLabel = new Label();
            label7 = new Label();
            panel8 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel5 = new Panel();
            welcomeLabel = new Label();
            label11 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 70);
            panel1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(68, 43);
            label5.Name = "label5";
            label5.Size = new Size(238, 20);
            label5.TabIndex = 6;
            label5.Text = "Making Voting Effortless and Secure.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(68, 0);
            label6.Name = "label6";
            label6.Size = new Size(336, 46);
            label6.TabIndex = 9;
            label6.Text = "JDR E-voting System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 72);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(logoutButton);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(152, 384);
            panel2.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 112);
            button1.Name = "button1";
            button1.Size = new Size(153, 34);
            button1.TabIndex = 21;
            button1.Text = "Vote";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // logoutButton
            // 
            logoutButton.BackColor = Color.Black;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutButton.ForeColor = Color.White;
            logoutButton.Location = new Point(-1, 155);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(153, 34);
            logoutButton.TabIndex = 9;
            logoutButton.Text = "Log Out";
            logoutButton.UseVisualStyleBackColor = false;
            logoutButton.Click += logoutButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(profileButton);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(-1, -2);
            panel3.Name = "panel3";
            panel3.Size = new Size(152, 105);
            panel3.TabIndex = 20;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.Black;
            profileButton.FlatAppearance.BorderSize = 0;
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            profileButton.ForeColor = Color.White;
            profileButton.Location = new Point(0, 71);
            profileButton.Name = "profileButton";
            profileButton.Size = new Size(153, 34);
            profileButton.TabIndex = 21;
            profileButton.Text = "Profile";
            profileButton.UseVisualStyleBackColor = false;
            profileButton.Click += profileButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(passwordLabel);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(panel14);
            panel4.Controls.Add(addressLabel);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(panel12);
            panel4.Controls.Add(sexLabel);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(ageLabel);
            panel4.Controls.Add(lastNameLabel);
            panel4.Controls.Add(firstNameLabel);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(panel8);
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(welcomeLabel);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(160, 80);
            panel4.Name = "panel4";
            panel4.Size = new Size(632, 361);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(156, 292);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 28;
            passwordLabel.Text = "Password";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(13, 292);
            label14.Name = "label14";
            label14.Size = new Size(137, 20);
            label14.TabIndex = 27;
            label14.Text = "Account Password:";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Controls.Add(panel15);
            panel14.Location = new Point(13, 315);
            panel14.Name = "panel14";
            panel14.Size = new Size(600, 2);
            panel14.TabIndex = 20;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Location = new Point(0, 40);
            panel15.Name = "panel15";
            panel15.Size = new Size(600, 2);
            panel15.TabIndex = 17;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(86, 244);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(62, 20);
            addressLabel.TabIndex = 26;
            addressLabel.Text = "Address";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(13, 244);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 25;
            label12.Text = "Address:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Controls.Add(panel13);
            panel12.Location = new Point(13, 267);
            panel12.Name = "panel12";
            panel12.Size = new Size(600, 2);
            panel12.TabIndex = 19;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Location = new Point(0, 40);
            panel13.Name = "panel13";
            panel13.Size = new Size(600, 2);
            panel13.TabIndex = 17;
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new Point(56, 196);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(32, 20);
            sexLabel.TabIndex = 24;
            sexLabel.Text = "Sex";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(13, 196);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 23;
            label9.Text = "Sex:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Controls.Add(panel11);
            panel10.Location = new Point(13, 219);
            panel10.Name = "panel10";
            panel10.Size = new Size(600, 2);
            panel10.TabIndex = 18;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(0, 40);
            panel11.Name = "panel11";
            panel11.Size = new Size(600, 2);
            panel11.TabIndex = 17;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(59, 148);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(36, 20);
            ageLabel.TabIndex = 22;
            ageLabel.Text = "Age";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(188, 101);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(79, 20);
            lastNameLabel.TabIndex = 21;
            lastNameLabel.Text = "Last Name";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(102, 101);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(80, 20);
            firstNameLabel.TabIndex = 20;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 148);
            label7.Name = "label7";
            label7.Size = new Size(40, 20);
            label7.TabIndex = 19;
            label7.Text = "Age:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Controls.Add(panel9);
            panel8.Location = new Point(13, 171);
            panel8.Name = "panel8";
            panel8.Size = new Size(600, 2);
            panel8.TabIndex = 18;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(0, 40);
            panel9.Name = "panel9";
            panel9.Size = new Size(600, 2);
            panel9.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(13, 123);
            panel6.Name = "panel6";
            panel6.Size = new Size(600, 2);
            panel6.TabIndex = 16;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(0, 40);
            panel7.Name = "panel7";
            panel7.Size = new Size(600, 2);
            panel7.TabIndex = 17;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(13, 63);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 4);
            panel5.TabIndex = 15;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            welcomeLabel.ForeColor = Color.IndianRed;
            welcomeLabel.Location = new Point(319, 15);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(93, 38);
            welcomeLabel.TabIndex = 14;
            welcomeLabel.Text = "Name";
            welcomeLabel.Click += welcomeLabel_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(178, 15);
            label11.Name = "label11";
            label11.Size = new Size(135, 38);
            label11.TabIndex = 13;
            label11.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 101);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Full Name:";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel14.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label6;
        private Label label5;
        private Panel panel2;
        private Button logoutButton;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Button profileButton;
        private Button button1;
        private Panel panel4;
        private Label label11;
        private Label label2;
        private Label welcomeLabel;
        private Panel panel6;
        private Panel panel5;
        private Label label7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel7;
        private Label ageLabel;
        private Label lastNameLabel;
        private Label firstNameLabel;
        private Label passwordLabel;
        private Label label14;
        private Panel panel14;
        private Panel panel15;
        private Label addressLabel;
        private Label label12;
        private Panel panel12;
        private Panel panel13;
        private Label sexLabel;
        private Label label9;
        private Panel panel10;
        private Panel panel11;
    }
}