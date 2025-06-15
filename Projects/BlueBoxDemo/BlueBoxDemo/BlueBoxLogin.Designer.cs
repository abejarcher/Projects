namespace BlueBoxDemo
{
    partial class BlueBoxLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueBoxLogin));
            btnLogin = new Button();
            lblUsername = new Label();
            txtUserName = new TextBox();
            pictureBox1 = new PictureBox();
            txtBlueBoxVision = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.AccessibleName = "Login Button";
            btnLogin.Font = new Font("Segoe UI", 11F);
            btnLogin.Location = new Point(777, 756);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(193, 60);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(603, 561);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(151, 40);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(768, 561);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(229, 39);
            txtUserName.TabIndex = 2;
            txtUserName.TextChanged += TypeUsername_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(768, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 242);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // txtBlueBoxVision
            // 
            txtBlueBoxVision.AutoSize = true;
            txtBlueBoxVision.Font = new Font("Segoe UI Black", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBlueBoxVision.Location = new Point(495, 402);
            txtBlueBoxVision.Name = "txtBlueBoxVision";
            txtBlueBoxVision.Size = new Size(778, 40);
            txtBlueBoxVision.TabIndex = 7;
            txtBlueBoxVision.Text = "Welcome to BlueBox the one stop shop for all Media!";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.875F);
            lblPassword.Location = new Point(612, 647);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(142, 40);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(768, 650);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 39);
            txtPassword.TabIndex = 9;
            // 
            // BlueBoxLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1678, 1072);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBlueBoxVision);
            Controls.Add(pictureBox1);
            Controls.Add(txtUserName);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Name = "BlueBoxLogin";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lblUsername;
        private TextBox txtUserName;
        private PictureBox pictureBox1;
        private Label txtBlueBoxVision;
        private Label lblPassword;
        private TextBox txtPassword;
    }
}
