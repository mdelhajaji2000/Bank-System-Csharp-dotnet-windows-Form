namespace BankSystem_Presentation_Tier.ClientsManagements.Forms
{
    partial class FindClientMiniForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SerchControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerchControls
            // 
            this.SerchControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(30)))));
            this.SerchControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerchControls.Controls.Add(this.btn_Find);
            this.SerchControls.Controls.Add(this.panel3);
            this.SerchControls.Controls.Add(this.button1);
            this.SerchControls.Controls.Add(this.FindTextBox);
            this.SerchControls.Controls.Add(this.label6);
            this.SerchControls.Location = new System.Drawing.Point(4, 3);
            this.SerchControls.Name = "SerchControls";
            this.SerchControls.Size = new System.Drawing.Size(657, 60);
            this.SerchControls.TabIndex = 6;
            // 
            // btn_Find
            // 
            this.btn_Find.BackgroundImage = global::BankSystem_Presentation_Tier.Properties.Resources._001_people;
            this.btn_Find.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Location = new System.Drawing.Point(434, 10);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(80, 43);
            this.btn_Find.TabIndex = 8;
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(295, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(133, 2);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(522, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.FindTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FindTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.FindTextBox.ForeColor = System.Drawing.SystemColors.Menu;
            this.FindTextBox.Location = new System.Drawing.Point(296, 10);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(132, 41);
            this.FindTextBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 40);
            this.label6.TabIndex = 3;
            this.label6.Text = "Account Number : ";
            // 
            // FindClientMiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(665, 67);
            this.Controls.Add(this.SerchControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindClientMiniForm";
            this.Text = "FinduserMiniForm";
            this.SerchControls.ResumeLayout(false);
            this.SerchControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SerchControls;
        protected System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox FindTextBox;
        protected System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button button1;
    }
}