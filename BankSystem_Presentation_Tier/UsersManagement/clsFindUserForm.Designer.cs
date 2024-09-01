namespace BankSystem_Presentation_Tier.UsersManagement
{
    partial class clsFindUserForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.userDetailsinfoControl1 = new BankSystem_Presentation_Tier.Controls.UserDetailsinfoControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 23F);
            this.comboBox1.ForeColor = System.Drawing.Color.Yellow;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "User Name",
            "User ID"});
            this.comboBox1.Location = new System.Drawing.Point(257, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 48);
            this.comboBox1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(16, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "Search Using : ";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_Find);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.FindTextBox);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 60);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(485, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(548, 2);
            this.panel3.TabIndex = 6;
            // 
            // FindTextBox
            // 
            this.FindTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FindTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.FindTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.FindTextBox.Location = new System.Drawing.Point(486, 10);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(547, 34);
            this.FindTextBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 52);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(372, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find User Page";
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
            // button7
            // 
            this.button7.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_close;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(1063, -1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 50);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_people;
            this.btn_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Location = new System.Drawing.Point(1039, 3);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(49, 50);
            this.btn_Find.TabIndex = 8;
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // userDetailsinfoControl1
            // 
            this.userDetailsinfoControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.userDetailsinfoControl1.Location = new System.Drawing.Point(-7, 116);
            this.userDetailsinfoControl1.Name = "userDetailsinfoControl1";
            this.userDetailsinfoControl1.Size = new System.Drawing.Size(1132, 669);
            this.userDetailsinfoControl1.TabIndex = 6;
            // 
            // clsFindUserForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1117, 781);
            this.Controls.Add(this.userDetailsinfoControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clsFindUserForm";
            this.Text = "Find SUer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox FindTextBox;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Button btn_Find;
        private Controls.UserDetailsinfoControl userDetailsinfoControl1;
    }
}