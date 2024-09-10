namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    partial class AddNewUpdateClientAccount
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LB_Title = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DisplayAccountNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personDataReader1 = new BankSystem_Presentation_Tier.Controls.PersonDataReader();
            this.ActivationStatusCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ForUpdatePanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ForUpdatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LB_Title);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 92);
            this.panel1.TabIndex = 2;
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.BackColor = System.Drawing.Color.Transparent;
            this.LB_Title.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LB_Title.Location = new System.Drawing.Point(75, 13);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(532, 60);
            this.LB_Title.TabIndex = 5;
            this.LB_Title.Text = "Craete New Account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(1141, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "V 1.0.1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BankSystem_Presentation_Tier.Properties.Resources._003_add_user;
            this.pictureBox2.Location = new System.Drawing.Point(14, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(5, 777);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 86);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(320, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(2, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(312, 64);
            this.button4.TabIndex = 11;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(1325, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 64);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(1125, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 64);
            this.button2.TabIndex = 9;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(261, 758);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(51, 2);
            this.panel6.TabIndex = 100;
            // 
            // DisplayAccountNumber
            // 
            this.DisplayAccountNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.DisplayAccountNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayAccountNumber.Enabled = false;
            this.DisplayAccountNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.DisplayAccountNumber.ForeColor = System.Drawing.SystemColors.Menu;
            this.DisplayAccountNumber.Location = new System.Drawing.Point(262, 723);
            this.DisplayAccountNumber.Name = "DisplayAccountNumber";
            this.DisplayAccountNumber.Size = new System.Drawing.Size(74, 34);
            this.DisplayAccountNumber.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(12, 722);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 35);
            this.label2.TabIndex = 98;
            this.label2.Text = "Account Number : ";
            // 
            // personDataReader1
            // 
            this.personDataReader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.personDataReader1.Location = new System.Drawing.Point(6, 83);
            this.personDataReader1.Name = "personDataReader1";
            this.personDataReader1.Size = new System.Drawing.Size(630, 706);
            this.personDataReader1.TabIndex = 0;
            // 
            // ActivationStatusCB
            // 
            this.ActivationStatusCB.AutoSize = true;
            this.ActivationStatusCB.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.ActivationStatusCB.ForeColor = System.Drawing.Color.Yellow;
            this.ActivationStatusCB.Location = new System.Drawing.Point(266, 27);
            this.ActivationStatusCB.Name = "ActivationStatusCB";
            this.ActivationStatusCB.Size = new System.Drawing.Size(113, 39);
            this.ActivationStatusCB.TabIndex = 101;
            this.ActivationStatusCB.Text = "Active";
            this.ActivationStatusCB.UseVisualStyleBackColor = true;
            this.ActivationStatusCB.CheckedChanged += new System.EventHandler(this.ActivationStatusCB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 35);
            this.label1.TabIndex = 102;
            this.label1.Text = "Activation Status : ";
            // 
            // ForUpdatePanel
            // 
            this.ForUpdatePanel.Controls.Add(this.ActivationStatusCB);
            this.ForUpdatePanel.Controls.Add(this.label1);
            this.ForUpdatePanel.Location = new System.Drawing.Point(30, 616);
            this.ForUpdatePanel.Name = "ForUpdatePanel";
            this.ForUpdatePanel.Size = new System.Drawing.Size(564, 100);
            this.ForUpdatePanel.TabIndex = 103;
            this.ForUpdatePanel.Visible = false;
            // 
            // AddNewUpdateClientAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(635, 871);
            this.Controls.Add(this.ForUpdatePanel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.DisplayAccountNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personDataReader1);
            this.Name = "AddNewUpdateClientAccount";
            this.Text = "AddNewUpdateClientInfo";
            this.Load += new System.EventHandler(this.AddNewUpdateClientAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ForUpdatePanel.ResumeLayout(false);
            this.ForUpdatePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PersonDataReader personDataReader1;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label LB_Title;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button4;
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox DisplayAccountNumber;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ActivationStatusCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel ForUpdatePanel;
    }
}