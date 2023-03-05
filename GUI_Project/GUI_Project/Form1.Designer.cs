namespace GUI_Project
{
    partial class Resturant_Manegment_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resturant_Manegment_System));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.staffButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TelegramButton = new System.Windows.Forms.Button();
            this.FaceBookButton = new System.Windows.Forms.Button();
            this.InstagramButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.Header_label);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 64);
            this.panel1.TabIndex = 0;
            // 
            // Header_label
            // 
            this.Header_label.AllowDrop = true;
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.Header_label.Location = new System.Drawing.Point(173, 16);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(79, 31);
            this.Header_label.TabIndex = 0;
            this.Header_label.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.staffButton);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Location = new System.Drawing.Point(0, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(164, 533);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(167, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 33);
            this.panel3.TabIndex = 2;
            // 
            // staffButton
            // 
            this.staffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.staffButton.FlatAppearance.BorderSize = 0;
            this.staffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.staffButton.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.staffButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.staffButton.Location = new System.Drawing.Point(0, 81);
            this.staffButton.Name = "staffButton";
            this.staffButton.Size = new System.Drawing.Size(161, 33);
            this.staffButton.TabIndex = 5;
            this.staffButton.Text = "Staff";
            this.staffButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.staffButton.UseVisualStyleBackColor = true;
            this.staffButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(0, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 33);
            this.button3.TabIndex = 4;
            this.button3.Text = "Menu List";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HomeButton.Location = new System.Drawing.Point(3, 3);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(161, 33);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(180, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contact Us:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(175, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "0882854555";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(170, 647);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "hidden.sloth16@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(778, 592);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Creator: Stoyan Peev";
            // 
            // TelegramButton
            // 
            this.TelegramButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TelegramButton.BackgroundImage")));
            this.TelegramButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TelegramButton.FlatAppearance.BorderSize = 0;
            this.TelegramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TelegramButton.Location = new System.Drawing.Point(820, 631);
            this.TelegramButton.Name = "TelegramButton";
            this.TelegramButton.Size = new System.Drawing.Size(32, 32);
            this.TelegramButton.TabIndex = 8;
            this.TelegramButton.UseVisualStyleBackColor = true;
            this.TelegramButton.Click += new System.EventHandler(this.TelegramButton_Click);
            // 
            // FaceBookButton
            // 
            this.FaceBookButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FaceBookButton.BackgroundImage")));
            this.FaceBookButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FaceBookButton.FlatAppearance.BorderSize = 0;
            this.FaceBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FaceBookButton.Location = new System.Drawing.Point(858, 631);
            this.FaceBookButton.Name = "FaceBookButton";
            this.FaceBookButton.Size = new System.Drawing.Size(32, 32);
            this.FaceBookButton.TabIndex = 7;
            this.FaceBookButton.UseVisualStyleBackColor = true;
            this.FaceBookButton.Click += new System.EventHandler(this.FaceBookButton_Click);
            // 
            // InstagramButton
            // 
            this.InstagramButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("InstagramButton.BackgroundImage")));
            this.InstagramButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.InstagramButton.FlatAppearance.BorderSize = 0;
            this.InstagramButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InstagramButton.Location = new System.Drawing.Point(896, 631);
            this.InstagramButton.Name = "InstagramButton";
            this.InstagramButton.Size = new System.Drawing.Size(32, 32);
            this.InstagramButton.TabIndex = 6;
            this.InstagramButton.UseVisualStyleBackColor = true;
            this.InstagramButton.Click += new System.EventHandler(this.InstagramButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(893, 16);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 31);
            this.closeButton.TabIndex = 1;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_Project.Properties.Resources.WallPaper;
            this.pictureBox2.Location = new System.Drawing.Point(3, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(937, 522);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Resturant_Manegment_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(940, 675);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TelegramButton);
            this.Controls.Add(this.FaceBookButton);
            this.Controls.Add(this.InstagramButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resturant_Manegment_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resturant Managment System";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InstagramButton;
        private System.Windows.Forms.Button FaceBookButton;
        private System.Windows.Forms.Button TelegramButton;
        private System.Windows.Forms.Label label4;
    }
}

