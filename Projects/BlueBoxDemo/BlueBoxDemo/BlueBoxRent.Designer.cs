namespace BlueBoxDemo
{
    partial class BlueBoxRent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueBoxRent));
            btnMenuReturn = new Button();
            cmbMovies = new ComboBox();
            cmbLocation = new ComboBox();
            cmbPaymentType = new ComboBox();
            btnRent = new Button();
            dgvTransactions = new DataGridView();
            lblMovies = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMenuReturn
            // 
            btnMenuReturn.Location = new Point(1357, 12);
            btnMenuReturn.Name = "btnMenuReturn";
            btnMenuReturn.Size = new Size(150, 46);
            btnMenuReturn.TabIndex = 1;
            btnMenuReturn.Text = "Main Menu";
            btnMenuReturn.UseVisualStyleBackColor = true;
            btnMenuReturn.Click += btnMenuReturn_Click;
            // 
            // cmbMovies
            // 
            cmbMovies.FormattingEnabled = true;
            cmbMovies.Location = new Point(381, 310);
            cmbMovies.Name = "cmbMovies";
            cmbMovies.Size = new Size(242, 40);
            cmbMovies.TabIndex = 2;
            cmbMovies.SelectedIndexChanged += cmbMovies_SelectedIndexChanged;
            // 
            // cmbLocation
            // 
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(37, 310);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(242, 40);
            cmbLocation.TabIndex = 3;
            cmbLocation.SelectedIndexChanged += cmbLocation_SelectedIndexChanged;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Location = new Point(725, 310);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(242, 40);
            cmbPaymentType.TabIndex = 4;
            cmbPaymentType.SelectedIndexChanged += cmbPaymentType_SelectedIndexChanged;
            // 
            // btnRent
            // 
            btnRent.Font = new Font("Segoe UI", 25.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRent.Location = new Point(1079, 82);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(428, 268);
            btnRent.TabIndex = 5;
            btnRent.Text = "Rent";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // dgvTransactions
            // 
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.Location = new Point(37, 408);
            dgvTransactions.Name = "dgvTransactions";
            dgvTransactions.RowHeadersWidth = 82;
            dgvTransactions.Size = new Size(1338, 356);
            dgvTransactions.TabIndex = 6;
            // 
            // lblMovies
            // 
            lblMovies.AutoSize = true;
            lblMovies.Font = new Font("Segoe UI", 13F);
            lblMovies.Location = new Point(381, 260);
            lblMovies.Name = "lblMovies";
            lblMovies.Size = new Size(130, 47);
            lblMovies.TabIndex = 7;
            lblMovies.Text = "Movies";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(37, 260);
            label1.Name = "label1";
            label1.Size = new Size(167, 47);
            label1.TabIndex = 8;
            label1.Text = "Locations";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(725, 260);
            label2.Name = "label2";
            label2.Size = new Size(236, 47);
            label2.TabIndex = 9;
            label2.Text = "Payment Type";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(381, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 242);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BlueBoxRent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1538, 812);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblMovies);
            Controls.Add(dgvTransactions);
            Controls.Add(btnRent);
            Controls.Add(cmbPaymentType);
            Controls.Add(cmbLocation);
            Controls.Add(cmbMovies);
            Controls.Add(btnMenuReturn);
            Name = "BlueBoxRent";
            Text = "BlueBoxRent";
            Load += BlueBoxRent_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvTransactions).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMenuReturn;
        private ComboBox cmbMovies;
        private ComboBox cmbLocation;
        private ComboBox cmbPaymentType;
        private Button btnRent;
        private DataGridView dgvTransactions;
        private Label lblMovies;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}