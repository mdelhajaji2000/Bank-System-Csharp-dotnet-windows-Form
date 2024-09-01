namespace BankSystem_Presentation_Tier.Controls
{
    partial class PersonDataReader
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DTP_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DisplayPersonID = new System.Windows.Forms.TextBox();
            this.CBCountry = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TB_Address = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Tbphone = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TB_email = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TB_Lastname = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TB_FirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dfg3456 = new System.Windows.Forms.Label();
            this.lbb = new System.Windows.Forms.Label();
            this.ert = new System.Windows.Forms.Label();
            this.bankDBDataSet = new BankSystem_Presentation_Tier.BankDBDataSet();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new BankSystem_Presentation_Tier.BankDBDataSetTableAdapters.CountriesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DTP_DateOfBirth);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.DisplayPersonID);
            this.groupBox1.Controls.Add(this.CBCountry);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.TB_Address);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.Tbphone);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.TB_email);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.TB_Lastname);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.TB_FirstName);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dfg3456);
            this.groupBox1.Controls.Add(this.lbb);
            this.groupBox1.Controls.Add(this.ert);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 687);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Info : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(28, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 31);
            this.label6.TabIndex = 99;
            this.label6.Text = "Contact Info : ";
            // 
            // DTP_DateOfBirth
            // 
            this.DTP_DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_DateOfBirth.Location = new System.Drawing.Point(250, 162);
            this.DTP_DateOfBirth.Name = "DTP_DateOfBirth";
            this.DTP_DateOfBirth.Size = new System.Drawing.Size(332, 30);
            this.DTP_DateOfBirth.TabIndex = 98;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(547, 672);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(51, 2);
            this.panel6.TabIndex = 97;
            // 
            // DisplayPersonID
            // 
            this.DisplayPersonID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.DisplayPersonID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayPersonID.Enabled = false;
            this.DisplayPersonID.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.DisplayPersonID.ForeColor = System.Drawing.SystemColors.Menu;
            this.DisplayPersonID.Location = new System.Drawing.Point(548, 637);
            this.DisplayPersonID.Name = "DisplayPersonID";
            this.DisplayPersonID.Size = new System.Drawing.Size(55, 34);
            this.DisplayPersonID.TabIndex = 96;
            // 
            // CBCountry
            // 
            this.CBCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.CBCountry.DataSource = this.countriesBindingSource;
            this.CBCountry.DisplayMember = "CountryName";
            this.CBCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CBCountry.Font = new System.Drawing.Font("Microsoft YaHei UI", 23F);
            this.CBCountry.ForeColor = System.Drawing.Color.Yellow;
            this.CBCountry.FormattingEnabled = true;
            this.CBCountry.Location = new System.Drawing.Point(206, 479);
            this.CBCountry.Name = "CBCountry";
            this.CBCountry.Size = new System.Drawing.Size(198, 48);
            this.CBCountry.TabIndex = 95;
            this.CBCountry.ValueMember = "CountryID";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(207, 443);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(386, 2);
            this.panel5.TabIndex = 94;
            // 
            // TB_Address
            // 
            this.TB_Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.TB_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Address.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.TB_Address.ForeColor = System.Drawing.SystemColors.Menu;
            this.TB_Address.Location = new System.Drawing.Point(208, 408);
            this.TB_Address.Name = "TB_Address";
            this.TB_Address.Size = new System.Drawing.Size(390, 34);
            this.TB_Address.TabIndex = 93;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(206, 383);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 2);
            this.panel4.TabIndex = 92;
            // 
            // Tbphone
            // 
            this.Tbphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.Tbphone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Tbphone.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.Tbphone.ForeColor = System.Drawing.SystemColors.Menu;
            this.Tbphone.Location = new System.Drawing.Point(207, 348);
            this.Tbphone.Name = "Tbphone";
            this.Tbphone.Size = new System.Drawing.Size(392, 34);
            this.Tbphone.TabIndex = 91;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(207, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 2);
            this.panel2.TabIndex = 90;
            // 
            // TB_email
            // 
            this.TB_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.TB_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_email.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.TB_email.ForeColor = System.Drawing.SystemColors.Menu;
            this.TB_email.Location = new System.Drawing.Point(207, 287);
            this.TB_email.Name = "TB_email";
            this.TB_email.Size = new System.Drawing.Size(393, 34);
            this.TB_email.TabIndex = 89;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(208, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 2);
            this.panel1.TabIndex = 88;
            // 
            // TB_Lastname
            // 
            this.TB_Lastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.TB_Lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Lastname.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.TB_Lastname.ForeColor = System.Drawing.SystemColors.Menu;
            this.TB_Lastname.Location = new System.Drawing.Point(209, 101);
            this.TB_Lastname.Name = "TB_Lastname";
            this.TB_Lastname.Size = new System.Drawing.Size(391, 34);
            this.TB_Lastname.TabIndex = 87;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(211, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 2);
            this.panel3.TabIndex = 86;
            // 
            // TB_FirstName
            // 
            this.TB_FirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(43)))));
            this.TB_FirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_FirstName.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F);
            this.TB_FirstName.ForeColor = System.Drawing.SystemColors.Menu;
            this.TB_FirstName.Location = new System.Drawing.Point(212, 37);
            this.TB_FirstName.Name = "TB_FirstName";
            this.TB_FirstName.Size = new System.Drawing.Size(391, 34);
            this.TB_FirstName.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(27, 407);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 35);
            this.label10.TabIndex = 84;
            this.label10.Text = "Address : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(385, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 35);
            this.label2.TabIndex = 83;
            this.label2.Text = "PersonID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 35);
            this.label1.TabIndex = 82;
            this.label1.Text = "Date Of Birth : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(27, 479);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 35);
            this.label15.TabIndex = 81;
            this.label15.Text = "Country : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(27, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 35);
            this.label13.TabIndex = 80;
            this.label13.Text = "Phone : ";
            // 
            // dfg3456
            // 
            this.dfg3456.AutoSize = true;
            this.dfg3456.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dfg3456.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dfg3456.Location = new System.Drawing.Point(28, 286);
            this.dfg3456.Name = "dfg3456";
            this.dfg3456.Size = new System.Drawing.Size(107, 35);
            this.dfg3456.TabIndex = 79;
            this.dfg3456.Text = "Email : ";
            // 
            // lbb
            // 
            this.lbb.AutoSize = true;
            this.lbb.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbb.Location = new System.Drawing.Point(29, 100);
            this.lbb.Name = "lbb";
            this.lbb.Size = new System.Drawing.Size(175, 35);
            this.lbb.TabIndex = 78;
            this.lbb.Text = "Last Name : ";
            // 
            // ert
            // 
            this.ert.AutoSize = true;
            this.ert.Font = new System.Drawing.Font("Microsoft YaHei UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ert.Location = new System.Drawing.Point(29, 37);
            this.ert.Name = "ert";
            this.ert.Size = new System.Drawing.Size(177, 35);
            this.ert.TabIndex = 77;
            this.ert.Text = "First Name : ";
            // 
            // bankDBDataSet
            // 
            this.bankDBDataSet.DataSetName = "BankDBDataSet";
            this.bankDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.bankDBDataSet;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // PersonDataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.groupBox1);
            this.Name = "PersonDataReader";
            this.Size = new System.Drawing.Size(635, 693);
            this.Load += new System.EventHandler(this.PersonDataReader_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bankDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker DTP_DateOfBirth;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox DisplayPersonID;
        private System.Windows.Forms.ComboBox CBCountry;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TB_Address;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Tbphone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TB_email;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TB_Lastname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TB_FirstName;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.Label dfg3456;
        protected System.Windows.Forms.Label lbb;
        protected System.Windows.Forms.Label ert;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private BankDBDataSet bankDBDataSet;
        private BankDBDataSetTableAdapters.CountriesTableAdapter countriesTableAdapter;
    }
}
