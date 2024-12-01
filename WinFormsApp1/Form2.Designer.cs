namespace WinFormsApp1
{
    partial class Form2
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
            panel2 = new Panel();
            passwordTextBox = new TextBox();
            label4 = new Label();
            addressTextBox = new TextBox();
            label3 = new Label();
            femaleRadioButton = new RadioButton();
            maleRadioButton = new RadioButton();
            label1 = new Label();
            lastNameLabel = new Label();
            lastNameTextBox = new TextBox();
            signupButton = new Button();
            ageTextBox = new TextBox();
            label11 = new Label();
            label2 = new Label();
            firstNameLabel = new Label();
            firstNameTextBox = new TextBox();
            panel3 = new Panel();
            linkLabel1 = new LinkLabel();
            label12 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(addressTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(femaleRadioButton);
            panel2.Controls.Add(maleRadioButton);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lastNameLabel);
            panel2.Controls.Add(lastNameTextBox);
            panel2.Controls.Add(signupButton);
            panel2.Controls.Add(ageTextBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(firstNameLabel);
            panel2.Controls.Add(firstNameTextBox);
            panel2.Location = new Point(74, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(396, 465);
            panel2.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(17, 329);
            passwordTextBox.MaxLength = 25;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(363, 27);
            passwordTextBox.TabIndex = 22;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 306);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 21;
            label4.Text = "Password";
            // 
            // addressTextBox
            // 
            addressTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addressTextBox.Location = new Point(17, 256);
            addressTextBox.MaxLength = 25;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(363, 27);
            addressTextBox.TabIndex = 20;
            addressTextBox.TextChanged += addressTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 233);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 19;
            label3.Text = "Address (City)";
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            femaleRadioButton.Location = new Point(301, 184);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(79, 24);
            femaleRadioButton.TabIndex = 18;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            femaleRadioButton.CheckedChanged += femaleRadioButton_CheckedChanged;
            // 
            // maleRadioButton
            // 
            maleRadioButton.AutoSize = true;
            maleRadioButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maleRadioButton.Location = new Point(205, 184);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(64, 24);
            maleRadioButton.TabIndex = 17;
            maleRadioButton.TabStop = true;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += maleRadioButton_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(205, 158);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 16;
            label1.Text = "Sex";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameLabel.Location = new Point(205, 90);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(80, 20);
            lastNameLabel.TabIndex = 15;
            lastNameLabel.Text = "Last Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastNameTextBox.Location = new Point(205, 113);
            lastNameTextBox.MaxLength = 25;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(175, 27);
            lastNameTextBox.TabIndex = 14;
            lastNameTextBox.TextChanged += lastNameTextBox_TextChanged;
            // 
            // signupButton
            // 
            signupButton.BackColor = Color.IndianRed;
            signupButton.FlatStyle = FlatStyle.Flat;
            signupButton.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupButton.ForeColor = Color.White;
            signupButton.Location = new Point(17, 391);
            signupButton.Name = "signupButton";
            signupButton.Size = new Size(363, 44);
            signupButton.TabIndex = 0;
            signupButton.Text = "Sign Up";
            signupButton.UseVisualStyleBackColor = false;
            signupButton.Click += signupButton_Click;
            // 
            // ageTextBox
            // 
            ageTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ageTextBox.Location = new Point(17, 181);
            ageTextBox.MaxLength = 2;
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(175, 27);
            ageTextBox.TabIndex = 0;
            ageTextBox.TextChanged += ageTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.IndianRed;
            label11.Location = new Point(47, 26);
            label11.Name = "label11";
            label11.Size = new Size(297, 38);
            label11.TabIndex = 13;
            label11.Text = "Create a new account.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 158);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 3;
            label2.Text = "Age";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameLabel.Location = new Point(17, 90);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(83, 20);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            firstNameLabel.Click += firstNameLabel_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            firstNameTextBox.Location = new Point(17, 113);
            firstNameTextBox.MaxLength = 25;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(175, 27);
            firstNameTextBox.TabIndex = 0;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(linkLabel1);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(74, 493);
            panel3.Name = "panel3";
            panel3.Size = new Size(396, 89);
            panel3.TabIndex = 23;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.IndianRed;
            linkLabel1.Location = new Point(288, 31);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 31);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Log In";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(17, 31);
            label12.Name = "label12";
            label12.Size = new Size(274, 31);
            label12.TabIndex = 13;
            label12.Text = "Already have an account?";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(542, 594);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox lastNameTextBox;
        private Button signupButton;
        private TextBox ageTextBox;
        private Label label11;
        private Label label2;
        private Label firstNameLabel;
        private TextBox firstNameTextBox;
        private Label lastNameLabel;
        private TextBox passwordTextBox;
        private Label label4;
        private TextBox addressTextBox;
        private Label label3;
        private RadioButton femaleRadioButton;
        private RadioButton maleRadioButton;
        private Label label1;
        private Panel panel3;
        private LinkLabel linkLabel1;
        private Label label12;
    }
}