namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    partial class ClientsListForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsListForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Pagetitle = new System.Windows.Forms.Label();
            this.ClientsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectedClientMenuStripDisplayName = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTransactionHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editActivationStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.Pagetitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1466, 72);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::BankSystem_Presentation_Tier.Properties.Resources._001_service;
            this.pictureBox4.Location = new System.Drawing.Point(522, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // Pagetitle
            // 
            this.Pagetitle.AutoSize = true;
            this.Pagetitle.Font = new System.Drawing.Font("Palatino Linotype", 35F, System.Drawing.FontStyle.Bold);
            this.Pagetitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Pagetitle.Location = new System.Drawing.Point(581, 6);
            this.Pagetitle.Name = "Pagetitle";
            this.Pagetitle.Size = new System.Drawing.Size(369, 63);
            this.Pagetitle.TabIndex = 0;
            this.Pagetitle.Text = "Manage Clients";
            // 
            // ClientsContainer
            // 
            this.ClientsContainer.AutoScroll = true;
            this.ClientsContainer.ContextMenuStrip = this.contextMenuStrip1;
            this.ClientsContainer.Location = new System.Drawing.Point(0, 143);
            this.ClientsContainer.Name = "ClientsContainer";
            this.ClientsContainer.Size = new System.Drawing.Size(1465, 509);
            this.ClientsContainer.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 20F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedClientMenuStripDisplayName,
            this.detailsInfoToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.showTransactionHistoryToolStripMenuItem,
            this.editActivationStatusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(461, 446);
            // 
            // selectedClientMenuStripDisplayName
            // 
            this.selectedClientMenuStripDisplayName.Enabled = false;
            this.selectedClientMenuStripDisplayName.Image = global::BankSystem_Presentation_Tier.Properties.Resources._004_man_2;
            this.selectedClientMenuStripDisplayName.Name = "selectedClientMenuStripDisplayName";
            this.selectedClientMenuStripDisplayName.Size = new System.Drawing.Size(460, 70);
            this.selectedClientMenuStripDisplayName.Text = "Selected Client";
            // 
            // detailsInfoToolStripMenuItem
            // 
            this.detailsInfoToolStripMenuItem.Image = global::BankSystem_Presentation_Tier.Properties.Resources._001_info;
            this.detailsInfoToolStripMenuItem.Name = "detailsInfoToolStripMenuItem";
            this.detailsInfoToolStripMenuItem.Size = new System.Drawing.Size(460, 70);
            this.detailsInfoToolStripMenuItem.Text = "Details info";
            this.detailsInfoToolStripMenuItem.Click += new System.EventHandler(this.detailsInfoToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Image = global::BankSystem_Presentation_Tier.Properties.Resources._003_add_user;
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(460, 70);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Image = global::BankSystem_Presentation_Tier.Properties.Resources._001_user3;
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(460, 70);
            this.deleteClientToolStripMenuItem.Text = "delete Client";
            // 
            // showTransactionHistoryToolStripMenuItem
            // 
            this.showTransactionHistoryToolStripMenuItem.Image = global::BankSystem_Presentation_Tier.Properties.Resources._002_transaction;
            this.showTransactionHistoryToolStripMenuItem.Name = "showTransactionHistoryToolStripMenuItem";
            this.showTransactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(460, 70);
            this.showTransactionHistoryToolStripMenuItem.Text = "Show transaction History";
            // 
            // editActivationStatusToolStripMenuItem
            // 
            this.editActivationStatusToolStripMenuItem.Image = global::BankSystem_Presentation_Tier.Properties.Resources._004_resume;
            this.editActivationStatusToolStripMenuItem.Name = "editActivationStatusToolStripMenuItem";
            this.editActivationStatusToolStripMenuItem.Size = new System.Drawing.Size(460, 70);
            this.editActivationStatusToolStripMenuItem.Text = "Edit Client Info";
            this.editActivationStatusToolStripMenuItem.Click += new System.EventHandler(this.editActivationStatusToolStripMenuItem_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.button8);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.label22);
            this.panel7.Controls.Add(this.label21);
            this.panel7.Controls.Add(this.label20);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1466, 70);
            this.panel7.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 63);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(1234, 5);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(137, 63);
            this.label22.TabIndex = 7;
            this.label22.Text = "Activation Status";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(1035, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(167, 29);
            this.label21.TabIndex = 6;
            this.label21.Text = "Creation Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(853, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 29);
            this.label20.TabIndex = 5;
            this.label20.Text = "Balance ($)";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Transparent;
            this.label18.Location = new System.Drawing.Point(462, 21);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(367, 29);
            this.label18.TabIndex = 4;
            this.label18.Text = "Email";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Transparent;
            this.label17.Location = new System.Drawing.Point(292, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(133, 29);
            this.label17.TabIndex = 3;
            this.label17.Text = "Last Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(123, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 29);
            this.label16.TabIndex = 2;
            this.label16.Text = "First Name ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "002-bank-account.png");
            this.imageList1.Images.SetKeyName(1, "user-avatar.png");
            this.imageList1.Images.SetKeyName(2, "001-delete.png");
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources.loading_arrow;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1406, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 34);
            this.button8.TabIndex = 9;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.label2.Location = new System.Drawing.Point(1399, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Refresh";
            // 
            // ClientsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1466, 651);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.ClientsContainer);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientsListForm";
            this.Text = "ClientsListForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel3;
        protected System.Windows.Forms.Label Pagetitle;
        protected System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.FlowLayoutPanel ClientsContainer;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detailsInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTransactionHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editActivationStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedClientMenuStripDisplayName;
        private System.Windows.Forms.ImageList imageList1;
        protected System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
    }
}