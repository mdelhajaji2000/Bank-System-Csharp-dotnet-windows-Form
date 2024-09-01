namespace BankSystem_Presentation_Tier.Controls
{
    partial class UserDetailsinfoControl
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
            this.userInfo1 = new BankSystem_Presentation_Tier.Controls.UserInfo();
            this.PersonInfo1 = new BankSystem_Presentation_Tier.Controls.UserFullInfo();
            this.SuspendLayout();
            // 
            // userInfo1
            // 
            this.userInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.userInfo1.Location = new System.Drawing.Point(18, 0);
            this.userInfo1.Name = "userInfo1";
            this.userInfo1.Size = new System.Drawing.Size(1099, 213);
            this.userInfo1.TabIndex = 0;
            // 
            // PersonInfo1
            // 
            this.PersonInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.PersonInfo1.Location = new System.Drawing.Point(18, 206);
            this.PersonInfo1.Name = "PersonInfo1";
            this.PersonInfo1.Size = new System.Drawing.Size(1111, 456);
            this.PersonInfo1.TabIndex = 1;
            // 
            // UserDetailsinfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.PersonInfo1);
            this.Controls.Add(this.userInfo1);
            this.Name = "UserDetailsinfoControl";
            this.Size = new System.Drawing.Size(1132, 669);
            this.ResumeLayout(false);

        }

        #endregion

        private UserInfo userInfo1;
        private UserFullInfo PersonInfo1;
    }
}
