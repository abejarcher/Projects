namespace BlueBoxDemo
{
    partial class BlueBoxLocations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlueBoxLocations));
            btnMainMenu = new Button();
            dgvLocation = new DataGridView();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLocation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(902, 12);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(150, 46);
            btnMainMenu.TabIndex = 0;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // dgvLocation
            // 
            dgvLocation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLocation.Location = new Point(29, 344);
            dgvLocation.Name = "dgvLocation";
            dgvLocation.RowHeadersWidth = 82;
            dgvLocation.Size = new Size(1023, 312);
            dgvLocation.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(29, 294);
            label1.Name = "label1";
            label1.Size = new Size(167, 47);
            label1.TabIndex = 9;
            label1.Text = "Locations";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(340, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 242);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // BlueBoxLocations
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 716);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(dgvLocation);
            Controls.Add(btnMainMenu);
            Name = "BlueBoxLocations";
            Text = "BlueBoxLocations";
            ((System.ComponentModel.ISupportInitialize)dgvLocation).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMainMenu;
        private DataGridView dgvLocation;
        private Label label1;
        private PictureBox pictureBox1;
    }
}