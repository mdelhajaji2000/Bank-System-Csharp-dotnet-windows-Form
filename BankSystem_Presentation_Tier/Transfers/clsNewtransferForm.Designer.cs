namespace BankSystem_Presentation_Tier.Transfers
{
    partial class clsNewtransferForm
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
            this.button7 = new System.Windows.Forms.Button();
            this.PageTitle = new System.Windows.Forms.Label();
            this.PageIcon = new System.Windows.Forms.PictureBox();
            this.AccountFromContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.AccountToContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BTN_Done = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.TB_Amount = new System.Windows.Forms.MaskedTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SetClientFrom = new System.Windows.Forms.LinkLabel();
            this.SetClientTo = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageIcon)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.PageTitle);
            this.panel1.Controls.Add(this.PageIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 91);
            this.panel1.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_close;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(829, 10);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(67, 66);
            this.button7.TabIndex = 8;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // PageTitle
            // 
            this.PageTitle.AutoSize = true;
            this.PageTitle.BackColor = System.Drawing.Color.Transparent;
            this.PageTitle.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PageTitle.Location = new System.Drawing.Point(231, 10);
            this.PageTitle.Name = "PageTitle";
            this.PageTitle.Size = new System.Drawing.Size(521, 50);
            this.PageTitle.TabIndex = 5;
            this.PageTitle.Text = "Transfers-New Transfer ";
            // 
            // PageIcon
            // 
            this.PageIcon.Image = global::BankSystem_Presentation_Tier.Properties.Resources._006_symbols;
            this.PageIcon.Location = new System.Drawing.Point(163, 4);
            this.PageIcon.Name = "PageIcon";
            this.PageIcon.Size = new System.Drawing.Size(67, 61);
            this.PageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PageIcon.TabIndex = 4;
            this.PageIcon.TabStop = false;
            // 
            // AccountFromContainer
            // 
            this.AccountFromContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.AccountFromContainer.Location = new System.Drawing.Point(16, 149);
            this.AccountFromContainer.Name = "AccountFromContainer";
            this.AccountFromContainer.Size = new System.Drawing.Size(309, 348);
            this.AccountFromContainer.TabIndex = 4;
            // 
            // AccountToContainer
            // 
            this.AccountToContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.AccountToContainer.Location = new System.Drawing.Point(585, 149);
            this.AccountToContainer.Name = "AccountToContainer";
            this.AccountToContainer.Size = new System.Drawing.Size(309, 348);
            this.AccountToContainer.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "Account From : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(588, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 52);
            this.label2.TabIndex = 7;
            this.label2.Text = "Account To : ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BTN_Done);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.TB_Amount);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 518);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(907, 135);
            this.panel4.TabIndex = 13;
            // 
            // BTN_Done
            // 
            this.BTN_Done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_Done.FlatAppearance.BorderSize = 3;
            this.BTN_Done.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.BTN_Done.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Done.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Done.ForeColor = System.Drawing.Color.Gold;
            this.BTN_Done.Location = new System.Drawing.Point(757, 25);
            this.BTN_Done.Name = "BTN_Done";
            this.BTN_Done.Size = new System.Drawing.Size(139, 84);
            this.BTN_Done.TabIndex = 12;
            this.BTN_Done.Text = "Done";
            this.BTN_Done.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(-1, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 97);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter Amount : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.pictureBox3.Image = global::BankSystem_Presentation_Tier.Properties.Resources._001_dollar_sign;
            this.pictureBox3.Location = new System.Drawing.Point(684, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 87);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // TB_Amount
            // 
            this.TB_Amount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.TB_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Amount.Font = new System.Drawing.Font("Perpetua Titling MT", 48F, System.Drawing.FontStyle.Bold);
            this.TB_Amount.ForeColor = System.Drawing.SystemColors.Info;
            this.TB_Amount.Location = new System.Drawing.Point(186, 24);
            this.TB_Amount.Name = "TB_Amount";
            this.TB_Amount.PromptChar = '0';
            this.TB_Amount.Size = new System.Drawing.Size(496, 84);
            this.TB_Amount.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(186, 109);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(496, 2);
            this.panel5.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankSystem_Presentation_Tier.Properties.Resources._004_transaction;
            this.pictureBox1.Location = new System.Drawing.Point(331, 149);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 348);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SetClientFrom
            // 
            this.SetClientFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.SetClientFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetClientFrom.Location = new System.Drawing.Point(16, 278);
            this.SetClientFrom.Name = "SetClientFrom";
            this.SetClientFrom.Size = new System.Drawing.Size(309, 59);
            this.SetClientFrom.TabIndex = 14;
            this.SetClientFrom.TabStop = true;
            this.SetClientFrom.Text = "Select Client account";
            this.SetClientFrom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetClientFrom.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetClientFrom_LinkClicked);
            // 
            // SetClientTo
            // 
            this.SetClientTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.SetClientTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetClientTo.Location = new System.Drawing.Point(585, 286);
            this.SetClientTo.Name = "SetClientTo";
            this.SetClientTo.Size = new System.Drawing.Size(309, 59);
            this.SetClientTo.TabIndex = 15;
            this.SetClientTo.TabStop = true;
            this.SetClientTo.Text = "Select Client account";
            this.SetClientTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SetClientTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetClientTo_LinkClicked);
            // 
            // clsNewtransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(907, 653);
            this.Controls.Add(this.SetClientTo);
            this.Controls.Add(this.SetClientFrom);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountToContainer);
            this.Controls.Add(this.AccountFromContainer);
            this.Controls.Add(this.panel1);
            this.Name = "clsNewtransferForm";
            this.Text = "clsNewtransferForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageIcon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.Label PageTitle;
        protected System.Windows.Forms.PictureBox PageIcon;
        private System.Windows.Forms.FlowLayoutPanel AccountFromContainer;
        private System.Windows.Forms.FlowLayoutPanel AccountToContainer;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Button BTN_Done;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MaskedTextBox TB_Amount;
        private System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel SetClientFrom;
        private System.Windows.Forms.LinkLabel SetClientTo;
    }
}