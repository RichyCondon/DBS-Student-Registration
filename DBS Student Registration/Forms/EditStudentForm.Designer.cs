namespace DBS_Student_Registration.Forms
{
    partial class EditStudentForm
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
            this.levelLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.countyLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.addressL2Label = new System.Windows.Forms.Label();
            this.addressL1Label = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.textBoxAddressL1 = new System.Windows.Forms.TextBox();
            this.textBoxAddressL2 = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.menuStripDefault = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDatabaseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            this.studentGrid = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cBoxCounty = new System.Windows.Forms.ComboBox();
            this.menuStripDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.levelLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.levelLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(110, 501);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(69, 31);
            this.levelLabel.TabIndex = 18;
            this.levelLabel.Text = "Level";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.emailLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.emailLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(110, 448);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(72, 31);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Email";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.phoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.phoneLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLabel.Location = new System.Drawing.Point(110, 400);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(113, 31);
            this.phoneLabel.TabIndex = 16;
            this.phoneLabel.Text = "Phone No";
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.countyLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.countyLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyLabel.Location = new System.Drawing.Point(110, 350);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(88, 31);
            this.countyLabel.TabIndex = 15;
            this.countyLabel.Text = "County";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.cityLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cityLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(110, 297);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(55, 31);
            this.cityLabel.TabIndex = 14;
            this.cityLabel.Text = "City";
            // 
            // addressL2Label
            // 
            this.addressL2Label.AutoSize = true;
            this.addressL2Label.BackColor = System.Drawing.Color.SteelBlue;
            this.addressL2Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addressL2Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressL2Label.Location = new System.Drawing.Point(110, 245);
            this.addressL2Label.Name = "addressL2Label";
            this.addressL2Label.Size = new System.Drawing.Size(162, 31);
            this.addressL2Label.TabIndex = 13;
            this.addressL2Label.Text = "Address Line 2";
            // 
            // addressL1Label
            // 
            this.addressL1Label.AutoSize = true;
            this.addressL1Label.BackColor = System.Drawing.Color.SteelBlue;
            this.addressL1Label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.addressL1Label.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressL1Label.Location = new System.Drawing.Point(110, 198);
            this.addressL1Label.Name = "addressL1Label";
            this.addressL1Label.Size = new System.Drawing.Size(158, 31);
            this.addressL1Label.TabIndex = 12;
            this.addressL1Label.Text = "Address Line 1";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(348, 445);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(327, 28);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLevel.Location = new System.Drawing.Point(348, 495);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(327, 28);
            this.textBoxLevel.TabIndex = 7;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.Location = new System.Drawing.Point(348, 394);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(327, 28);
            this.textBoxPhone.TabIndex = 5;
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhone_KeyPress);
            // 
            // textBoxCity
            // 
            this.textBoxCity.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCity.Location = new System.Drawing.Point(348, 291);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(327, 28);
            this.textBoxCity.TabIndex = 3;
            // 
            // textBoxAddressL1
            // 
            this.textBoxAddressL1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAddressL1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddressL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddressL1.Location = new System.Drawing.Point(348, 198);
            this.textBoxAddressL1.Name = "textBoxAddressL1";
            this.textBoxAddressL1.Size = new System.Drawing.Size(327, 28);
            this.textBoxAddressL1.TabIndex = 1;
            // 
            // textBoxAddressL2
            // 
            this.textBoxAddressL2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAddressL2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddressL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddressL2.Location = new System.Drawing.Point(348, 245);
            this.textBoxAddressL2.Name = "textBoxAddressL2";
            this.textBoxAddressL2.Size = new System.Drawing.Size(327, 28);
            this.textBoxAddressL2.TabIndex = 2;
            // 
            // submitBtn
            // 
            this.submitBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.submitBtn.BackColor = System.Drawing.Color.Silver;
            this.submitBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.submitBtn.Location = new System.Drawing.Point(324, 553);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(161, 56);
            this.submitBtn.TabIndex = 8;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // menuStripDefault
            // 
            this.menuStripDefault.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStripDefault.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStripDefault.Location = new System.Drawing.Point(0, 0);
            this.menuStripDefault.Name = "menuStripDefault";
            this.menuStripDefault.Size = new System.Drawing.Size(1431, 33);
            this.menuStripDefault.TabIndex = 53;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.deleteStudentToolStripMenuItem,
            this.viewDatabaseHistoryToolStripMenuItem,
            this.exportXMLToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // deleteStudentToolStripMenuItem
            // 
            this.deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            this.deleteStudentToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.deleteStudentToolStripMenuItem.Text = "Delete Student";
            this.deleteStudentToolStripMenuItem.Click += new System.EventHandler(this.deleteStudentToolStripMenuItem_Click);
            // 
            // viewDatabaseHistoryToolStripMenuItem
            // 
            this.viewDatabaseHistoryToolStripMenuItem.Name = "viewDatabaseHistoryToolStripMenuItem";
            this.viewDatabaseHistoryToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.viewDatabaseHistoryToolStripMenuItem.Text = "View Database History";
            this.viewDatabaseHistoryToolStripMenuItem.Click += new System.EventHandler(this.viewDatabaseHistoryToolStripMenuItem_Click);
            // 
            // exportXMLToolStripMenuItem
            // 
            this.exportXMLToolStripMenuItem.Name = "exportXMLToolStripMenuItem";
            this.exportXMLToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.exportXMLToolStripMenuItem.Text = "Export XML";
            this.exportXMLToolStripMenuItem.Click += new System.EventHandler(this.exportXMLToolStripMenuItem_Click);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.BackColor = System.Drawing.Color.SteelBlue;
            this.lblStudentId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudentId.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentId.Location = new System.Drawing.Point(110, 139);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(124, 31);
            this.lblStudentId.TabIndex = 11;
            this.lblStudentId.Text = "Student ID";
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxStudentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStudentId.Location = new System.Drawing.Point(348, 139);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(327, 28);
            this.textBoxStudentId.TabIndex = 0;
            this.textBoxStudentId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStudentId_KeyPress);
            // 
            // studentGrid
            // 
            this.studentGrid.AllowUserToOrderColumns = true;
            this.studentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGrid.Location = new System.Drawing.Point(756, 139);
            this.studentGrid.Name = "studentGrid";
            this.studentGrid.RowTemplate.Height = 28;
            this.studentGrid.Size = new System.Drawing.Size(602, 416);
            this.studentGrid.TabIndex = 10;
            this.studentGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentGrid_CellDoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(529, 553);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 56);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cBoxCounty
            // 
            this.cBoxCounty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBoxCounty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxCounty.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cBoxCounty.FormattingEnabled = true;
            this.cBoxCounty.Items.AddRange(new object[] {
            "Antrim",
            "Armagh",
            "Carlow",
            "Cavan",
            "Clare",
            "Cork",
            "Derry",
            "Donegal",
            "Down",
            "Dublin",
            "Fermanagh",
            "Galway",
            "Kerry",
            "Kildare",
            "Kilkenny",
            "Laois",
            "Leitrim",
            "Limerick",
            "Longford",
            "Louth",
            "Mayo",
            "Monaghan",
            "Offaly",
            "Roscommon",
            "Sligo",
            "Tipperary",
            "Tyrone",
            "Waterford",
            "Westmeath",
            "Wexford",
            "Wicklow"});
            this.cBoxCounty.Location = new System.Drawing.Point(348, 337);
            this.cBoxCounty.Name = "cBoxCounty";
            this.cBoxCounty.Size = new System.Drawing.Size(327, 28);
            this.cBoxCounty.TabIndex = 54;
            this.cBoxCounty.Text = "  Choose...";
            // 
            // EditStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1431, 697);
            this.Controls.Add(this.cBoxCounty);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.studentGrid);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.menuStripDefault);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.countyLabel);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.addressL2Label);
            this.Controls.Add(this.addressL1Label);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.textBoxAddressL1);
            this.Controls.Add(this.textBoxAddressL2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditStudentForm";
            this.Text = "EditStudentForm";
            this.menuStripDefault.ResumeLayout(false);
            this.menuStripDefault.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label addressL2Label;
        private System.Windows.Forms.Label addressL1Label;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.TextBox textBoxAddressL1;
        private System.Windows.Forms.TextBox textBoxAddressL2;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.MenuStrip menuStripDefault;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDatabaseHistoryToolStripMenuItem;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox textBoxStudentId;
        private System.Windows.Forms.DataGridView studentGrid;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolStripMenuItem exportXMLToolStripMenuItem;
        private System.Windows.Forms.ComboBox cBoxCounty;
    }
}