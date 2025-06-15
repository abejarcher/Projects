namespace BlueBoxDemo
{
    partial class BlueBoxMovies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueBoxMovies));
            txtPlaceholder = new Label();
            btnMainMenu = new Button();
            dgvMovies = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtPlaceholder
            // 
            txtPlaceholder.AutoSize = true;
            txtPlaceholder.Location = new Point(311, 186);
            txtPlaceholder.Name = "txtPlaceholder";
            txtPlaceholder.Size = new Size(0, 32);
            txtPlaceholder.TabIndex = 0;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(1036, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(150, 46);
            btnMainMenu.TabIndex = 1;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // dgvMovies
            // 
            dgvMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovies.Location = new Point(45, 328);
            dgvMovies.Name = "dgvMovies";
            dgvMovies.RowHeadersWidth = 82;
            dgvMovies.Size = new Size(892, 370);
            dgvMovies.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(341, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 242);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(45, 278);
            label1.Name = "label1";
            label1.Size = new Size(130, 47);
            label1.TabIndex = 12;
            label1.Text = "Movies";
            // 
            // BlueBoxMovies
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1198, 782);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvMovies);
            Controls.Add(btnMainMenu);
            Controls.Add(txtPlaceholder);
            Name = "BlueBoxMovies";
            Text = "BlueBoxMovies";
            ((System.ComponentModel.ISupportInitialize)dgvMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtPlaceholder;
        private Button btnMainMenu;
        private DataGridView dgvMovies;
        private PictureBox pictureBox1;
        private Label label1;
    }
}