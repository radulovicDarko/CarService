
namespace CarServiceApp
{
    partial class AddVehicle
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
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxYearOfManufacture = new System.Windows.Forms.TextBox();
            this.labelYearOfManufacture = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxChassisNumber = new System.Windows.Forms.TextBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.buttonNewRepairOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelNewVehicleTitle = new System.Windows.Forms.Label();
            this.labelChassisNumber = new System.Windows.Forms.Label();
            this.textBoxLicencePlate = new System.Windows.Forms.TextBox();
            this.labelLicensePlate = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxOwners = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(161, 325);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(175, 20);
            this.textBoxEmail.TabIndex = 48;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(40, 324);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(50, 18);
            this.labelEmail.TabIndex = 47;
            this.labelEmail.Text = "E-mail";
            // 
            // textBoxYearOfManufacture
            // 
            this.textBoxYearOfManufacture.Location = new System.Drawing.Point(161, 248);
            this.textBoxYearOfManufacture.Name = "textBoxYearOfManufacture";
            this.textBoxYearOfManufacture.Size = new System.Drawing.Size(175, 20);
            this.textBoxYearOfManufacture.TabIndex = 46;
            // 
            // labelYearOfManufacture
            // 
            this.labelYearOfManufacture.AutoSize = true;
            this.labelYearOfManufacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYearOfManufacture.Location = new System.Drawing.Point(40, 240);
            this.labelYearOfManufacture.MaximumSize = new System.Drawing.Size(100, 0);
            this.labelYearOfManufacture.Name = "labelYearOfManufacture";
            this.labelYearOfManufacture.Size = new System.Drawing.Size(90, 36);
            this.labelYearOfManufacture.TabIndex = 45;
            this.labelYearOfManufacture.Text = "Year of manufacture";
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(161, 162);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(175, 20);
            this.textBoxBrand.TabIndex = 43;
            // 
            // textBoxChassisNumber
            // 
            this.textBoxChassisNumber.Location = new System.Drawing.Point(160, 120);
            this.textBoxChassisNumber.Name = "textBoxChassisNumber";
            this.textBoxChassisNumber.Size = new System.Drawing.Size(175, 20);
            this.textBoxChassisNumber.TabIndex = 42;
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBrand.Location = new System.Drawing.Point(40, 164);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(47, 18);
            this.labelBrand.TabIndex = 41;
            this.labelBrand.Text = "Brand";
            // 
            // buttonNewRepairOrder
            // 
            this.buttonNewRepairOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRepairOrder.Location = new System.Drawing.Point(222, 409);
            this.buttonNewRepairOrder.Name = "buttonNewRepairOrder";
            this.buttonNewRepairOrder.Size = new System.Drawing.Size(113, 44);
            this.buttonNewRepairOrder.TabIndex = 40;
            this.buttonNewRepairOrder.Text = "Create new repair order";
            this.buttonNewRepairOrder.UseVisualStyleBackColor = true;
            this.buttonNewRepairOrder.Click += new System.EventHandler(this.buttonNewRepairOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(65, 409);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 44);
            this.buttonCancel.TabIndex = 39;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelNewVehicleTitle
            // 
            this.labelNewVehicleTitle.AutoSize = true;
            this.labelNewVehicleTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelNewVehicleTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewVehicleTitle.Location = new System.Drawing.Point(89, 37);
            this.labelNewVehicleTitle.Name = "labelNewVehicleTitle";
            this.labelNewVehicleTitle.Size = new System.Drawing.Size(224, 31);
            this.labelNewVehicleTitle.TabIndex = 38;
            this.labelNewVehicleTitle.Text = "Add vehicle\'s info";
            // 
            // labelChassisNumber
            // 
            this.labelChassisNumber.AutoSize = true;
            this.labelChassisNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChassisNumber.Location = new System.Drawing.Point(40, 120);
            this.labelChassisNumber.Name = "labelChassisNumber";
            this.labelChassisNumber.Size = new System.Drawing.Size(115, 18);
            this.labelChassisNumber.TabIndex = 37;
            this.labelChassisNumber.Text = "ChassisNumber";
            // 
            // textBoxLicencePlate
            // 
            this.textBoxLicencePlate.Location = new System.Drawing.Point(161, 289);
            this.textBoxLicencePlate.Name = "textBoxLicencePlate";
            this.textBoxLicencePlate.Size = new System.Drawing.Size(175, 20);
            this.textBoxLicencePlate.TabIndex = 36;
            // 
            // labelLicensePlate
            // 
            this.labelLicensePlate.AutoSize = true;
            this.labelLicensePlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLicensePlate.Location = new System.Drawing.Point(40, 290);
            this.labelLicensePlate.Name = "labelLicensePlate";
            this.labelLicensePlate.Size = new System.Drawing.Size(94, 18);
            this.labelLicensePlate.TabIndex = 35;
            this.labelLicensePlate.Text = "License plate";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelType.Location = new System.Drawing.Point(40, 206);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 18);
            this.labelType.TabIndex = 34;
            this.labelType.Text = "Type";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(161, 206);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(175, 20);
            this.textBoxType.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Owner ID";
            // 
            // comboBoxOwners
            // 
            this.comboBoxOwners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwners.FormattingEnabled = true;
            this.comboBoxOwners.Location = new System.Drawing.Point(161, 363);
            this.comboBoxOwners.Name = "comboBoxOwners";
            this.comboBoxOwners.Size = new System.Drawing.Size(175, 21);
            this.comboBoxOwners.TabIndex = 51;
            // 
            // AddVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(384, 467);
            this.Controls.Add(this.comboBoxOwners);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxYearOfManufacture);
            this.Controls.Add(this.labelYearOfManufacture);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.textBoxChassisNumber);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.buttonNewRepairOrder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelNewVehicleTitle);
            this.Controls.Add(this.labelChassisNumber);
            this.Controls.Add(this.textBoxLicencePlate);
            this.Controls.Add(this.labelLicensePlate);
            this.Controls.Add(this.labelType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddVehicle";
            this.Load += new System.EventHandler(this.AddVehicle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxYearOfManufacture;
        private System.Windows.Forms.Label labelYearOfManufacture;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxChassisNumber;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Button buttonNewRepairOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelNewVehicleTitle;
        private System.Windows.Forms.Label labelChassisNumber;
        private System.Windows.Forms.TextBox textBoxLicencePlate;
        private System.Windows.Forms.Label labelLicensePlate;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxOwners;
    }
}