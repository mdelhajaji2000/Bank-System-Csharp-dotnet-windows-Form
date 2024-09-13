namespace BankSystem_Presentation_Tier.Controls
{
    partial class ClientMiniCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DisplayAccountNumber = new System.Windows.Forms.Label();
            this.DisplayFullName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DisplayBalance = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::BankSystem_Presentation_Tier.Properties.Resources._001_man;
            this.pictureBox1.Location = new System.Drawing.Point(82, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.DisplayAccountNumber);
            this.panel1.Controls.Add(this.DisplayFullName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DisplayBalance);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 213);
            this.panel1.TabIndex = 1;
            // 
            // DisplayAccountNumber
            // 
            this.DisplayAccountNumber.AutoSize = true;
            this.DisplayAccountNumber.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayAccountNumber.ForeColor = System.Drawing.Color.Gold;
            this.DisplayAccountNumber.Location = new System.Drawing.Point(177, 75);
            this.DisplayAccountNumber.Name = "DisplayAccountNumber";
            this.DisplayAccountNumber.Size = new System.Drawing.Size(48, 24);
            this.DisplayAccountNumber.TabIndex = 15;
            this.DisplayAccountNumber.Text = "8701";
            // 
            // DisplayFullName
            // 
            this.DisplayFullName.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayFullName.ForeColor = System.Drawing.Color.Gold;
            this.DisplayFullName.Location = new System.Drawing.Point(115, 0);
            this.DisplayFullName.Name = "DisplayFullName";
            this.DisplayFullName.Size = new System.Drawing.Size(137, 62);
            this.DisplayFullName.TabIndex = 14;
            this.DisplayFullName.Text = "Mohammed El hajaji";
            this.DisplayFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Account Number : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 41);
            this.label3.TabIndex = 11;
            this.label3.Text = "($) Balance : ";
            // 
            // DisplayBalance
            // 
            this.DisplayBalance.AutoSize = true;
            this.DisplayBalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.DisplayBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayBalance.Font = new System.Drawing.Font("Perpetua Titling MT", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayBalance.ForeColor = System.Drawing.Color.Lime;
            this.DisplayBalance.Location = new System.Drawing.Point(3, 159);
            this.DisplayBalance.Name = "DisplayBalance";
            this.DisplayBalance.Size = new System.Drawing.Size(243, 43);
            this.DisplayBalance.TabIndex = 10;
            this.DisplayBalance.Text = "000.000.000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.pictureBox2.Image = global::BankSystem_Presentation_Tier.Properties.Resources._001_dollar_sign;
            this.pictureBox2.Location = new System.Drawing.Point(248, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name : ";
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_delete;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(205, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 38);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_info;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(205, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 41);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientMiniCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientMiniCard";
            this.Size = new System.Drawing.Size(302, 346);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DisplayAccountNumber;
        private System.Windows.Forms.Label DisplayFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DisplayBalance;
        protected System.Windows.Forms.PictureBox pictureBox2;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.Button button1;
    }
}
