namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    partial class FindClientForm
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
            this.SerchControls = new System.Windows.Forms.Panel();
            this.btn_Find = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.clientAccountInfo1 = new BankSystem_Presentation_Tier.Controls.ClientAccountInfo();
            this.userFullInfo1 = new BankSystem_Presentation_Tier.Controls.UserFullInfo();
            this.DeleteControl = new System.Windows.Forms.Panel();
            this.BT_deleteClient = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SerchControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DeleteControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerchControls
            // 
            this.SerchControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerchControls.Controls.Add(this.btn_Find);
            this.SerchControls.Controls.Add(this.panel3);
            this.SerchControls.Controls.Add(this.FindTextBox);
            this.SerchControls.Controls.Add(this.label6);
            this.SerchControls.Location = new System.Drawing.Point(13, 64);
            this.SerchControls.Name = "SerchControls";
            this.SerchControls.Size = new System.Drawing.Size(1093, 60);
            this.SerchControls.TabIndex = 5;
            // 
            // btn_Find
            // 
            this.btn_Find.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_people;
            this.btn_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Location = new System.Drawing.Point(907, 3);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(161, 50);
            this.btn_Find.TabIndex = 8;
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(336, 45);
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
            this.FindTextBox.Location = new System.Drawing.Point(337, 10);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(547, 34);
            this.FindTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(47, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "Account Number : ";
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
            this.panel2.Size = new System.Drawing.Size(1121, 52);
            this.panel2.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(321, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Find Client Account ";
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
            // clientAccountInfo1
            // 
            this.clientAccountInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.clientAccountInfo1.Location = new System.Drawing.Point(11, 123);
            this.clientAccountInfo1.Name = "clientAccountInfo1";
            this.clientAccountInfo1.Size = new System.Drawing.Size(1102, 207);
            this.clientAccountInfo1.TabIndex = 8;
            // 
            // userFullInfo1
            // 
            this.userFullInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.userFullInfo1.Location = new System.Drawing.Point(13, 321);
            this.userFullInfo1.Name = "userFullInfo1";
            this.userFullInfo1.Size = new System.Drawing.Size(1111, 456);
            this.userFullInfo1.TabIndex = 7;
            // 
            // DeleteControl
            // 
            this.DeleteControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DeleteControl.Controls.Add(this.BT_deleteClient);
            this.DeleteControl.Controls.Add(this.button1);
            this.DeleteControl.Controls.Add(this.label2);
            this.DeleteControl.Location = new System.Drawing.Point(13, 58);
            this.DeleteControl.Name = "DeleteControl";
            this.DeleteControl.Size = new System.Drawing.Size(1093, 71);
            this.DeleteControl.TabIndex = 9;
            this.DeleteControl.Visible = false;
            // 
            // BT_deleteClient
            // 
            this.BT_deleteClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.BT_deleteClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.BT_deleteClient.FlatAppearance.BorderSize = 2;
            this.BT_deleteClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_deleteClient.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_deleteClient.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BT_deleteClient.Image = global::BankSystem_Presentation_Tier.Properties.Resources._001_user3;
            this.BT_deleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BT_deleteClient.Location = new System.Drawing.Point(792, 3);
            this.BT_deleteClient.Name = "BT_deleteClient";
            this.BT_deleteClient.Size = new System.Drawing.Size(254, 63);
            this.BT_deleteClient.TabIndex = 14;
            this.BT_deleteClient.Text = "         Delete Account";
            this.BT_deleteClient.UseVisualStyleBackColor = false;
            this.BT_deleteClient.Click += new System.EventHandler(this.BT_deleteClient_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_warning;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(93, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 63);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(239, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Are you Sure You Want To Delete That User ...!";
            // 
            // FindClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1121, 773);
            this.Controls.Add(this.DeleteControl);
            this.Controls.Add(this.clientAccountInfo1);
            this.Controls.Add(this.userFullInfo1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SerchControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindClientForm";
            this.Text = "FindClientForm";
            this.SerchControls.ResumeLayout(false);
            this.SerchControls.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.DeleteControl.ResumeLayout(false);
            this.DeleteControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SerchControls;
        protected System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox FindTextBox;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label4;
        private Controls.UserFullInfo userFullInfo1;
        private Controls.ClientAccountInfo clientAccountInfo1;
        private System.Windows.Forms.Panel DeleteControl;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button BT_deleteClient;
    }
}