namespace BankSystem_Presentation_Tier.UsersManagement
{
    partial class EditAddnEwUserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddNewEditTitleLael = new System.Windows.Forms.Label();
            this.personDataReader1 = new BankSystem_Presentation_Tier.Controls.PersonDataReader();
            this.userDataReader1 = new BankSystem_Presentation_Tier.Controls.UserDataReader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.AddNewEditTitleLael);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1542, 92);
            this.panel2.TabIndex = 6;
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources.user_avatar;
            this.btn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Location = new System.Drawing.Point(511, 14);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(67, 61);
            this.btn_Edit.TabIndex = 10;
            this.btn_Edit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_close;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1471, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 51);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewEditTitleLael
            // 
            this.AddNewEditTitleLael.AutoSize = true;
            this.AddNewEditTitleLael.BackColor = System.Drawing.Color.Transparent;
            this.AddNewEditTitleLael.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewEditTitleLael.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewEditTitleLael.Location = new System.Drawing.Point(574, 19);
            this.AddNewEditTitleLael.Name = "AddNewEditTitleLael";
            this.AddNewEditTitleLael.Size = new System.Drawing.Size(354, 50);
            this.AddNewEditTitleLael.TabIndex = 5;
            this.AddNewEditTitleLael.Text = "Edit User info : ";
            // 
            // personDataReader1
            // 
            this.personDataReader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.personDataReader1.Location = new System.Drawing.Point(12, 101);
            this.personDataReader1.Name = "personDataReader1";
            this.personDataReader1.Size = new System.Drawing.Size(635, 693);
            this.personDataReader1.TabIndex = 7;
            // 
            // userDataReader1
            // 
            this.userDataReader1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.userDataReader1.Location = new System.Drawing.Point(653, 106);
            this.userDataReader1.Name = "userDataReader1";
            this.userDataReader1.Size = new System.Drawing.Size(886, 688);
            this.userDataReader1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 800);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1519, 92);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EditAddnEwUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1542, 904);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userDataReader1);
            this.Controls.Add(this.personDataReader1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditAddnEwUserForm";
            this.Text = "UsersDetailsForm";
            this.Load += new System.EventHandler(this.EditAddnEwUserForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label AddNewEditTitleLael;
        protected System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Edit;
        private Controls.PersonDataReader personDataReader1;
        private Controls.UserDataReader userDataReader1;
        private System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button3;
    }
}