namespace GUI_Project
{
    partial class StaffWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffWindow));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.staffButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header_label = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProgressBar = new CircularProgressBar.CircularProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(23)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.staffButton);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.HomeButton);
            this.panel2.Location = new System.Drawing.Point(0, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 544);
            this.panel2.TabIndex = 3;
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
            this.HomeButton.Size = new System.Drawing.Size(158, 33);
            this.HomeButton.TabIndex = 3;
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
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
            this.panel1.TabIndex = 5;
            // 
            // Header_label
            // 
            this.Header_label.AllowDrop = true;
            this.Header_label.AutoSize = true;
            this.Header_label.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.Header_label.Location = new System.Drawing.Point(173, 16);
            this.Header_label.Name = "Header_label";
            this.Header_label.Size = new System.Drawing.Size(164, 31);
            this.Header_label.TabIndex = 0;
            this.Header_label.Text = "Staff Window";
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
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(179, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 110);
            this.panel4.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.label3.Location = new System.Drawing.Point(108, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "0$";
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Daily Budget:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.ProgressBar);
            this.panel6.Location = new System.Drawing.Point(172, 206);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 234);
            this.panel6.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.label4.Location = new System.Drawing.Point(232, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Outgo";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.label1.Location = new System.Drawing.Point(48, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Income";
            // 
            // ProgressBar
            // 
            this.ProgressBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.ProgressBar.AnimationSpeed = 500;
            this.ProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.ProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.ProgressBar.InnerMargin = 2;
            this.ProgressBar.InnerWidth = -1;
            this.ProgressBar.Location = new System.Drawing.Point(22, 65);
            this.ProgressBar.MarqueeAnimationSpeed = 2000;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.OuterColor = System.Drawing.Color.Gray;
            this.ProgressBar.OuterMargin = -25;
            this.ProgressBar.OuterWidth = 26;
            this.ProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.ProgressBar.ProgressWidth = 25;
            this.ProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.ProgressBar.Size = new System.Drawing.Size(148, 150);
            this.ProgressBar.StartAngle = 270;
            this.ProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.ProgressBar.SubscriptText = ".23";
            this.ProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.ProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.ProgressBar.SuperscriptText = "";
            this.ProgressBar.TabIndex = 0;
            this.ProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(206)))), ((int)(((byte)(203)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(621, 89);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(259, 368);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(631, 553);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // StaffWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(29)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(940, 675);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffWindow";
            this.Load += new System.EventHandler(this.StaffWindow_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button staffButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Header_label;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar ProgressBar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}