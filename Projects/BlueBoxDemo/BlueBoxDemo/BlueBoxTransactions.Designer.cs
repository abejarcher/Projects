namespace BlueBoxDemo
{
    partial class BlueBoxTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueBoxTransactions));
            btnMainMenu = new Button();
            dgvTransactions = new DataGridView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(972, 22);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(150, 46);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(3, 354);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 82;
            dgvTransactions.Size = new Size(1119, 304);
            dgvTransactions.TabIndex = 2;
            dgvTransactions.CellContentClick += dgvTransactions_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(371, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 242);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(3, 304);
            label1.Name = "label1";
            label1.Size = new Size(210, 47);
            label1.TabIndex = 10;
            label1.Text = "Transactions";
            // 
            // BlueBoxTransactions
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1148, 718);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvTransactions);
            Controls.Add(btnMainMenu);
            Name = "BlueBoxTransactions";
            Text = "BlueBoxTransactions";
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainMenu;
        private DataGridView dgvTransactions;
        private PictureBox pictureBox1;
        private Label label1;
    }
}