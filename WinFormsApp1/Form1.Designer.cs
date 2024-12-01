namespace WinFormsApp1
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
            loginButton = new Button();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            passwordTextBox = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            label11 = new Label();
            panel3 = new Panel();
            linkLabel1 = new LinkLabel();
            label12 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.IndianRed;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(17, 233);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(363, 44);
            loginButton.TabIndex = 0;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 452);
            panel1.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(8, 425);
            label10.Name = "label10";
            label10.Size = new Size(112, 20);
            label10.TabIndex = 12;
            label10.Text = "Resty Nazareno";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(8, 406);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 11;
            label9.Text = "Dominic Galan";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(8, 388);
            label8.Name = "label8";
            label8.Size = new Size(100, 20);
            label8.TabIndex = 10;
            label8.Text = "John Mungcal";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(8, 368);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 7;
            label7.Text = "Developed by:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(51, 260);
            label5.Name = "label5";
            label5.Size = new Size(238, 20);
            label5.TabIndex = 5;
            label5.Text = "Making Voting Effortless and Secure.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 72);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(67, 171);
            label3.Name = "label3";
            label3.Size = new Size(219, 38);
            label3.TabIndex = 4;
            label3.Text = "Welcome to the";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 206);
            label6.Name = "label6";
            label6.Size = new Size(346, 46);
            label6.TabIndex = 8;
            label6.Text = "JDR E-voting System!";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(17, 181);
            passwordTextBox.MaxLength = 25;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(363, 27);
            passwordTextBox.TabIndex = 0;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 158);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lastNameLabel);
            panel2.Controls.Add(lastNameTextBox);
            panel2.Controls.Add(firstNameLabel);
            panel2.Controls.Add(firstNameTextBox);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(380, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 290);
            panel2.TabIndex = 7;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(205, 87);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(80, 20);
            lastNameLabel.TabIndex = 19;
            lastNameLabel.Text = "Last Name";
            lastNameLabel.Click += lastNameLabel_Click;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(205, 110);
            lastNameTextBox.MaxLength = 25;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(175, 27);
            lastNameTextBox.TabIndex = 18;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(17, 87);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 20);
            firstNameLabel.TabIndex = 16;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(17, 110);
            firstNameTextBox.MaxLength = 25;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(175, 27);
            firstNameTextBox.TabIndex = 17;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.IndianRed;
            label11.Location = new Point(47, 26);
            label11.Name = "label11";
            label11.Size = new Size(303, 38);
            label11.TabIndex = 13;
            label11.Text = "Log into your account.";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(380, 335);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 89);
            panel3.TabIndex = 14;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.IndianRed;
            linkLabel1.Location = new Point(273, 31);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(96, 31);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 31);
            label12.Name = "label12";
            label12.Size = new Size(251, 31);
            label12.TabIndex = 13;
            label12.Text = "Don't have an account?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button loginButton;
        private Panel panel1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox passwordTextBox;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private Label label11;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private Label label12;
        private Label lastNameLabel;
        private TextBox lastNameTextBox;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
    }
}
