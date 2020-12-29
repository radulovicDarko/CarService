
namespace CarServiceApp
{
    partial class AddClient
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
            this.labelClientsSurname = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelNewCarInspectionTitle = new System.Windows.Forms.Label();
            this.labelOwnersName = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelClientsGender = new System.Windows.Forms.Label();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.textBoxClientsSurname = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.labelEmailRegex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelClientsSurname
            // 
            this.labelClientsSurname.AutoSize = true;
            this.labelClientsSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientsSurname.Location = new System.Drawing.Point(41, 163);
            this.labelClientsSurname.Name = "labelClientsSurname";
            this.labelClientsSurname.Size = new System.Drawing.Size(68, 18);
            this.labelClientsSurname.TabIndex = 24;
            this.labelClientsSurname.Text = "Surname";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(66, 374);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(113, 44);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelNewCarInspectionTitle
            // 
            this.labelNewCarInspectionTitle.AutoSize = true;
            this.labelNewCarInspectionTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelNewCarInspectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCarInspectionTitle.Location = new System.Drawing.Point(90, 36);
            this.labelNewCarInspectionTitle.Name = "labelNewCarInspectionTitle";
            this.labelNewCarInspectionTitle.Size = new System.Drawing.Size(203, 31);
            this.labelNewCarInspectionTitle.TabIndex = 19;
            this.labelNewCarInspectionTitle.Text = "Add client\'s info";
            // 
            // labelOwnersName
            // 
            this.labelOwnersName.AutoSize = true;
            this.labelOwnersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwnersName.Location = new System.Drawing.Point(41, 119);
            this.labelOwnersName.Name = "labelOwnersName";
            this.labelOwnersName.Size = new System.Drawing.Size(48, 18);
            this.labelOwnersName.TabIndex = 18;
            this.labelOwnersName.Text = "Name";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(162, 285);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(175, 20);
            this.textBoxPhone.TabIndex = 17;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(41, 285);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(105, 18);
            this.labelPhone.TabIndex = 16;
            this.labelPhone.Text = "Phone number";
            // 
            // labelClientsGender
            // 
            this.labelClientsGender.AutoSize = true;
            this.labelClientsGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientsGender.Location = new System.Drawing.Point(41, 205);
            this.labelClientsGender.Name = "labelClientsGender";
            this.labelClientsGender.Size = new System.Drawing.Size(57, 18);
            this.labelClientsGender.TabIndex = 14;
            this.labelClientsGender.Text = "Gender";
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Location = new System.Drawing.Point(161, 119);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(175, 20);
            this.textBoxClientName.TabIndex = 27;
            // 
            // textBoxClientsSurname
            // 
            this.textBoxClientsSurname.Location = new System.Drawing.Point(162, 161);
            this.textBoxClientsSurname.Name = "textBoxClientsSurname";
            this.textBoxClientsSurname.Size = new System.Drawing.Size(175, 20);
            this.textBoxClientsSurname.TabIndex = 28;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(161, 206);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(64, 21);
            this.comboBoxGender.TabIndex = 29;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(162, 247);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(175, 20);
            this.textBoxAddress.TabIndex = 31;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(42, 247);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 18);
            this.labelAddress.TabIndex = 30;
            this.labelAddress.Text = "Address";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(162, 324);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(175, 20);
            this.textBoxEmail.TabIndex = 33;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(41, 324);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 18);
            this.labelEmail.TabIndex = 32;
            this.labelEmail.Text = "E-mail";
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(195, 374);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(113, 44);
            this.buttonNewClient.TabIndex = 34;
            this.buttonNewClient.Text = "Add client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // labelEmailRegex
            // 
            this.labelEmailRegex.AutoSize = true;
            this.labelEmailRegex.BackColor = System.Drawing.Color.Transparent;
            this.labelEmailRegex.ForeColor = System.Drawing.Color.Red;
            this.labelEmailRegex.Location = new System.Drawing.Point(167, 349);
            this.labelEmailRegex.Name = "labelEmailRegex";
            this.labelEmailRegex.Size = new System.Drawing.Size(0, 13);
            this.labelEmailRegex.TabIndex = 35;
            // 
            // AddClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 435);
            this.Controls.Add(this.labelEmailRegex);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxClientsSurname);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.labelClientsSurname);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelNewCarInspectionTitle);
            this.Controls.Add(this.labelOwnersName);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelClientsGender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOwner";
            this.Load += new System.EventHandler(this.AddOwner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClientsSurname;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelNewCarInspectionTitle;
        private System.Windows.Forms.Label labelOwnersName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelClientsGender;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.TextBox textBoxClientsSurname;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Label labelEmailRegex;
    }
}