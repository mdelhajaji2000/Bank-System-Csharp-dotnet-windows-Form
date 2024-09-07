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
            this.contextMenuStrip1.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Bold);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectedClientMenuStripDisplayName,
            this.detailsInfoToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.showTransactionHistoryToolStripMenuItem,
            this.editActivationStatusToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(317, 218);
            // 
            // selectedClientMenuStripDisplayName
            // 
            this.selectedClientMenuStripDisplayName.Enabled = false;
            this.selectedClientMenuStripDisplayName.Name = "selectedClientMenuStripDisplayName";
            this.selectedClientMenuStripDisplayName.Size = new System.Drawing.Size(316, 32);
            this.selectedClientMenuStripDisplayName.Text = "Selected Client";
            // 
            // detailsInfoToolStripMenuItem
            // 
            this.detailsInfoToolStripMenuItem.Name = "detailsInfoToolStripMenuItem";
            this.detailsInfoToolStripMenuItem.Size = new System.Drawing.Size(316, 32);
            this.detailsInfoToolStripMenuItem.Text = "Details info";
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(316, 32);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(316, 32);
            this.deleteClientToolStripMenuItem.Text = "delete Client";
            // 
            // showTransactionHistoryToolStripMenuItem
            // 
            this.showTransactionHistoryToolStripMenuItem.Name = "showTransactionHistoryToolStripMenuItem";
            this.showTransactionHistoryToolStripMenuItem.Size = new System.Drawing.Size(316, 32);
            this.showTransactionHistoryToolStripMenuItem.Text = "Show transaction History";
            // 
            // editActivationStatusToolStripMenuItem
            // 
            this.editActivationStatusToolStripMenuItem.Name = "editActivationStatusToolStripMenuItem";
            this.editActivationStatusToolStripMenuItem.Size = new System.Drawing.Size(316, 32);
            this.editActivationStatusToolStripMenuItem.Text = "edit Client info";
            // 
            // panel7
            // 
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
    }
}