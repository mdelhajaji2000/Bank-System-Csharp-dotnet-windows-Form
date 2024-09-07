namespace BankSystem_Presentation_Tier.Controls
{
    partial class ClientCard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientCard));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.LB_FirstName = new System.Windows.Forms.Label();
            this.LB_LastName = new System.Windows.Forms.Label();
            this.LB_Email = new System.Windows.Forms.Label();
            this.LB_Balance = new System.Windows.Forms.Label();
            this.LB_CreationDate = new System.Windows.Forms.Label();
            this.LB_ActivationStatus = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.PB_ClientPictureAvatar = new System.Windows.Forms.PictureBox();
            this.LB_AccountNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ClientPictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-man.png");
            this.imageList1.Images.SetKeyName(1, "002-man-1.png");
            this.imageList1.Images.SetKeyName(2, "003-woman.png");
            this.imageList1.Images.SetKeyName(3, "004-man-2.png");
            this.imageList1.Images.SetKeyName(4, "005-woman-1.png");
            this.imageList1.Images.SetKeyName(5, "006-man-3.png");
            this.imageList1.Images.SetKeyName(6, "007-man-4.png");
            this.imageList1.Images.SetKeyName(7, "008-man-5.png");
            // 
            // LB_FirstName
            // 
            this.LB_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FirstName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LB_FirstName.Location = new System.Drawing.Point(124, 31);
            this.LB_FirstName.Name = "LB_FirstName";
            this.LB_FirstName.Size = new System.Drawing.Size(154, 31);
            this.LB_FirstName.TabIndex = 1;
            this.LB_FirstName.Text = "First Name ";
            this.LB_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_FirstName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // LB_LastName
            // 
            this.LB_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LastName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LB_LastName.Location = new System.Drawing.Point(287, 31);
            this.LB_LastName.Name = "LB_LastName";
            this.LB_LastName.Size = new System.Drawing.Size(145, 31);
            this.LB_LastName.TabIndex = 2;
            this.LB_LastName.Text = "Last Name";
            this.LB_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_LastName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // LB_Email
            // 
            this.LB_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Email.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LB_Email.Location = new System.Drawing.Point(452, 31);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(384, 31);
            this.LB_Email.TabIndex = 3;
            this.LB_Email.Text = "ExamleEmail@Exmp.com";
            this.LB_Email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Email.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // LB_Balance
            // 
            this.LB_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Balance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LB_Balance.Location = new System.Drawing.Point(860, 31);
            this.LB_Balance.Name = "LB_Balance";
            this.LB_Balance.Size = new System.Drawing.Size(135, 31);
            this.LB_Balance.TabIndex = 4;
            this.LB_Balance.Text = "4.453.564";
            this.LB_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_Balance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // LB_CreationDate
            // 
            this.LB_CreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreationDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.LB_CreationDate.Location = new System.Drawing.Point(1024, 1);
            this.LB_CreationDate.Name = "LB_CreationDate";
            this.LB_CreationDate.Size = new System.Drawing.Size(182, 89);
            this.LB_CreationDate.TabIndex = 5;
            this.LB_CreationDate.Text = "Creation Date";
            this.LB_CreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_CreationDate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // LB_ActivationStatus
            // 
            this.LB_ActivationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ActivationStatus.ForeColor = System.Drawing.Color.Lime;
            this.LB_ActivationStatus.Location = new System.Drawing.Point(1245, 31);
            this.LB_ActivationStatus.Name = "LB_ActivationStatus";
            this.LB_ActivationStatus.Size = new System.Drawing.Size(112, 31);
            this.LB_ActivationStatus.TabIndex = 6;
            this.LB_ActivationStatus.Text = "InActive";
            this.LB_ActivationStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_ActivationStatus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_info;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(1377, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 78);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // PB_ClientPictureAvatar
            // 
            this.PB_ClientPictureAvatar.Image = global::BankSystem_Presentation_Tier.Properties.Resources._008_man_5;
            this.PB_ClientPictureAvatar.Location = new System.Drawing.Point(0, 0);
            this.PB_ClientPictureAvatar.Name = "PB_ClientPictureAvatar";
            this.PB_ClientPictureAvatar.Size = new System.Drawing.Size(116, 63);
            this.PB_ClientPictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ClientPictureAvatar.TabIndex = 0;
            this.PB_ClientPictureAvatar.TabStop = false;
            this.PB_ClientPictureAvatar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // LB_AccountNumber
            // 
            this.LB_AccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AccountNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LB_AccountNumber.Location = new System.Drawing.Point(-3, 65);
            this.LB_AccountNumber.Name = "LB_AccountNumber";
            this.LB_AccountNumber.Size = new System.Drawing.Size(119, 31);
            this.LB_AccountNumber.TabIndex = 8;
            this.LB_AccountNumber.Text = "1234566";
            this.LB_AccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_AccountNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            // 
            // ClientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(61)))));
            this.Controls.Add(this.LB_AccountNumber);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.LB_ActivationStatus);
            this.Controls.Add(this.LB_CreationDate);
            this.Controls.Add(this.LB_Balance);
            this.Controls.Add(this.LB_Email);
            this.Controls.Add(this.LB_LastName);
            this.Controls.Add(this.LB_FirstName);
            this.Controls.Add(this.PB_ClientPictureAvatar);
            this.Name = "ClientCard";
            this.Size = new System.Drawing.Size(1457, 104);
            this.Load += new System.EventHandler(this.ClientCard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LB_AccountNumber_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.PB_ClientPictureAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox PB_ClientPictureAvatar;
        private System.Windows.Forms.Label LB_FirstName;
        private System.Windows.Forms.Label LB_LastName;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LB_Balance;
        private System.Windows.Forms.Label LB_CreationDate;
        private System.Windows.Forms.Label LB_ActivationStatus;
        protected System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label LB_AccountNumber;
    }
}
