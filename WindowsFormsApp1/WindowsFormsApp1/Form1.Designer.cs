namespace WindowsFormsApp1
{
    partial class personalInfo
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
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.fatherName = new System.Windows.Forms.Label();
            this.motherName = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.fNameText = new System.Windows.Forms.TextBox();
            this.lNameText = new System.Windows.Forms.TextBox();
            this.motherNameText = new System.Windows.Forms.TextBox();
            this.fatherNameText = new System.Windows.Forms.TextBox();
            this.addressText = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.showInfo = new System.Windows.Forms.Button();
            this.showName = new System.Windows.Forms.Button();
            this.showParent = new System.Windows.Forms.Button();
            this.showAddress = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(30, 36);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(57, 13);
            this.fName.TabIndex = 0;
            this.fName.Text = "First Name";
            this.fName.Click += new System.EventHandler(this.fName_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(30, 65);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(58, 13);
            this.lName.TabIndex = 1;
            this.lName.Text = "Last Name";
            this.lName.Click += new System.EventHandler(this.label2_Click);
            // 
            // fatherName
            // 
            this.fatherName.AutoSize = true;
            this.fatherName.Location = new System.Drawing.Point(30, 94);
            this.fatherName.Name = "fatherName";
            this.fatherName.Size = new System.Drawing.Size(72, 13);
            this.fatherName.TabIndex = 2;
            this.fatherName.Text = "father\'s Name";
            this.fatherName.Click += new System.EventHandler(this.label3_Click);
            // 
            // motherName
            // 
            this.motherName.AutoSize = true;
            this.motherName.Location = new System.Drawing.Point(30, 123);
            this.motherName.Name = "motherName";
            this.motherName.Size = new System.Drawing.Size(78, 13);
            this.motherName.TabIndex = 3;
            this.motherName.Text = "Mother\'s Name";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(30, 151);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(45, 13);
            this.address.TabIndex = 4;
            this.address.Text = "Address";
            // 
            // fNameText
            // 
            this.fNameText.Location = new System.Drawing.Point(129, 33);
            this.fNameText.Name = "fNameText";
            this.fNameText.Size = new System.Drawing.Size(150, 20);
            this.fNameText.TabIndex = 5;
            // 
            // lNameText
            // 
            this.lNameText.Location = new System.Drawing.Point(129, 67);
            this.lNameText.Name = "lNameText";
            this.lNameText.Size = new System.Drawing.Size(150, 20);
            this.lNameText.TabIndex = 6;
            // 
            // motherNameText
            // 
            this.motherNameText.Location = new System.Drawing.Point(130, 122);
            this.motherNameText.Name = "motherNameText";
            this.motherNameText.Size = new System.Drawing.Size(149, 20);
            this.motherNameText.TabIndex = 7;
            // 
            // fatherNameText
            // 
            this.fatherNameText.Location = new System.Drawing.Point(131, 95);
            this.fatherNameText.Name = "fatherNameText";
            this.fatherNameText.Size = new System.Drawing.Size(148, 20);
            this.fatherNameText.TabIndex = 8;
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(131, 151);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(148, 20);
            this.addressText.TabIndex = 9;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(100, 192);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(97, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // showInfo
            // 
            this.showInfo.Location = new System.Drawing.Point(228, 192);
            this.showInfo.Name = "showInfo";
            this.showInfo.Size = new System.Drawing.Size(128, 23);
            this.showInfo.TabIndex = 11;
            this.showInfo.Text = "Show All Information";
            this.showInfo.UseVisualStyleBackColor = true;
            this.showInfo.Click += new System.EventHandler(this.showInfo_Click);
            // 
            // showName
            // 
            this.showName.Location = new System.Drawing.Point(100, 222);
            this.showName.Name = "showName";
            this.showName.Size = new System.Drawing.Size(75, 23);
            this.showName.TabIndex = 12;
            this.showName.Text = "Name";
            this.showName.UseVisualStyleBackColor = true;
            // 
            // showParent
            // 
            this.showParent.Location = new System.Drawing.Point(212, 221);
            this.showParent.Name = "showParent";
            this.showParent.Size = new System.Drawing.Size(112, 23);
            this.showParent.TabIndex = 13;
            this.showParent.Text = "Parent\'s Information";
            this.showParent.UseVisualStyleBackColor = true;
            // 
            // showAddress
            // 
            this.showAddress.Location = new System.Drawing.Point(346, 222);
            this.showAddress.Name = "showAddress";
            this.showAddress.Size = new System.Drawing.Size(75, 23);
            this.showAddress.TabIndex = 14;
            this.showAddress.Text = "Address";
            this.showAddress.UseVisualStyleBackColor = true;
            // 
            // personalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 265);
            this.Controls.Add(this.showAddress);
            this.Controls.Add(this.showParent);
            this.Controls.Add(this.showName);
            this.Controls.Add(this.showInfo);
            this.Controls.Add(this.save);
            this.Controls.Add(this.addressText);
            this.Controls.Add(this.fatherNameText);
            this.Controls.Add(this.motherNameText);
            this.Controls.Add(this.lNameText);
            this.Controls.Add(this.fNameText);
            this.Controls.Add(this.address);
            this.Controls.Add(this.motherName);
            this.Controls.Add(this.fatherName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Name = "personalInfo";
            this.Text = "Personal Information";
            this.Load += new System.EventHandler(this.personalInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label fatherName;
        private System.Windows.Forms.Label motherName;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox fNameText;
        private System.Windows.Forms.TextBox lNameText;
        private System.Windows.Forms.TextBox motherNameText;
        private System.Windows.Forms.TextBox fatherNameText;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button showInfo;
        private System.Windows.Forms.Button showName;
        private System.Windows.Forms.Button showParent;
        private System.Windows.Forms.Button showAddress;
    }
}

