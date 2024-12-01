namespace WinFormsApp1
{
    partial class Form4
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            panel2 = new Panel();
            button1 = new Button();
            logoutButton = new Button();
            panel3 = new Panel();
            profileButton = new Button();
            pictureBox2 = new PictureBox();
            submitVoteButton = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            candidate2RadioButton = new RadioButton();
            candidate1RadioButton = new RadioButton();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            firstNameLabel = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
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
            panel2.TabIndex = 9;
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
            // submitVoteButton
            // 
            submitVoteButton.BackColor = Color.IndianRed;
            submitVoteButton.FlatAppearance.BorderSize = 0;
            submitVoteButton.FlatStyle = FlatStyle.Flat;
            submitVoteButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitVoteButton.ForeColor = Color.White;
            submitVoteButton.Location = new Point(368, 369);
            submitVoteButton.Name = "submitVoteButton";
            submitVoteButton.Size = new Size(208, 34);
            submitVoteButton.TabIndex = 22;
            submitVoteButton.Text = "SUBMIT VOTE";
            submitVoteButton.UseVisualStyleBackColor = false;
            submitVoteButton.Click += submitVoteButton_Click;
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
            panel1.TabIndex = 10;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(393, 86);
            label11.Name = "label11";
            label11.Size = new Size(158, 38);
            label11.TabIndex = 14;
            label11.Text = "Candidates";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(candidate2RadioButton);
            panel4.Controls.Add(candidate1RadioButton);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(195, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(567, 165);
            panel4.TabIndex = 15;
            // 
            // candidate2RadioButton
            // 
            candidate2RadioButton.AutoSize = true;
            candidate2RadioButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            candidate2RadioButton.ForeColor = Color.Coral;
            candidate2RadioButton.Location = new Point(376, 116);
            candidate2RadioButton.Name = "candidate2RadioButton";
            candidate2RadioButton.Size = new Size(160, 27);
            candidate2RadioButton.TabIndex = 24;
            candidate2RadioButton.TabStop = true;
            candidate2RadioButton.Text = "Candidate Name";
            candidate2RadioButton.UseVisualStyleBackColor = true;
            candidate2RadioButton.CheckedChanged += candidate2RadioButton_CheckedChanged;
            // 
            // candidate1RadioButton
            // 
            candidate1RadioButton.AutoSize = true;
            candidate1RadioButton.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            candidate1RadioButton.ForeColor = Color.RoyalBlue;
            candidate1RadioButton.Location = new Point(43, 116);
            candidate1RadioButton.Name = "candidate1RadioButton";
            candidate1RadioButton.Size = new Size(160, 27);
            candidate1RadioButton.TabIndex = 24;
            candidate1RadioButton.TabStop = true;
            candidate1RadioButton.Text = "Candidate Name";
            candidate1RadioButton.UseVisualStyleBackColor = true;
            candidate1RadioButton.CheckedChanged += candidate1RadioButton_CheckedChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(421, 27);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(65, 65);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(91, 27);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 65);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(400, 137);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(145, 20);
            firstNameLabel.TabIndex = 27;
            firstNameLabel.Text = "(Position: President)";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(submitVoteButton);
            Controls.Add(firstNameLabel);
            Controls.Add(panel4);
            Controls.Add(label11);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button submitVoteButton;
        private Button button1;
        private Button logoutButton;
        private Panel panel3;
        private Button profileButton;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label11;
        private Panel panel4;
        private PictureBox pictureBox3;
        private RadioButton candidate1RadioButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label firstNameLabel;
        private RadioButton candidate2RadioButton;
        private PictureBox pictureBox4;
    }
}