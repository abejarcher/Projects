namespace BlueBoxDemo
{
    partial class BlueBoxMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueBoxMainMenu));
            btnMovieList = new Button();
            btnLocation = new Button();
            btnTransactions = new Button();
            btnRent = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMovieList
            // 
            btnMovieList.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMovieList.Location = new Point(87, 530);
            btnMovieList.Name = "btnMovieList";
            btnMovieList.Size = new Size(660, 218);
            btnMovieList.TabIndex = 0;
            btnMovieList.Text = "Browse Movies";
            btnMovieList.UseVisualStyleBackColor = true;
            btnMovieList.Click += btnMovieList_Click;
            // 
            // btnLocation
            // 
            btnLocation.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocation.Location = new Point(87, 806);
            btnLocation.Name = "btnLocation";
            btnLocation.Size = new Size(660, 240);
            btnLocation.TabIndex = 1;
            btnLocation.Text = "Locations";
            btnLocation.UseVisualStyleBackColor = true;
            btnLocation.Click += button2_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTransactions.Location = new Point(970, 530);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(685, 218);
            btnTransactions.TabIndex = 2;
            btnTransactions.Text = "Transaction History";
            btnTransactions.UseVisualStyleBackColor = true;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnRent
            // 
            btnRent.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRent.Location = new Point(970, 806);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(685, 226);
            btnRent.TabIndex = 3;
            btnRent.Text = "Rent a Movie";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += button4_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1456, 26);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(199, 80);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Sign Out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(738, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 252);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(717, 293);
            label1.Name = "label1";
            label1.Size = new Size(286, 65);
            label1.TabIndex = 6;
            label1.Text = "Main Menu";
            // 
            // BlueBoxMainMenu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1742, 1142);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnRent);
            Controls.Add(btnTransactions);
            Controls.Add(btnLocation);
            Controls.Add(btnMovieList);
            Name = "BlueBoxMainMenu";
            Text = "BlueBoxMainMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMovieList;
        private Button btnLocation;
        private Button btnTransactions;
        private Button btnRent;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Label label1;
    }
}