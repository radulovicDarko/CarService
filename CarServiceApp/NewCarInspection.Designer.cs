
namespace CarServiceApp
{
    partial class NewCarInspection
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
            this.labelMalfunctionDesciption = new System.Windows.Forms.Label();
            this.textBoxMalfunctionDescription = new System.Windows.Forms.TextBox();
            this.textBoxRepairPrice = new System.Windows.Forms.TextBox();
            this.labelRepairPrice = new System.Windows.Forms.Label();
            this.labelOwner = new System.Windows.Forms.Label();
            this.labelNewCarInspectionTitle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonNewRepairOrder = new System.Windows.Forms.Button();
            this.comboBoxOwners = new System.Windows.Forms.ComboBox();
            this.buttonAddOwner = new System.Windows.Forms.Button();
            this.buttonAddVehicle = new System.Windows.Forms.Button();
            this.comboBoxVehicles = new System.Windows.Forms.ComboBox();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMalfunctionDesciption
            // 
            this.labelMalfunctionDesciption.AutoSize = true;
            this.labelMalfunctionDesciption.BackColor = System.Drawing.SystemColors.Control;
            this.labelMalfunctionDesciption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMalfunctionDesciption.Location = new System.Drawing.Point(32, 216);
            this.labelMalfunctionDesciption.Name = "labelMalfunctionDesciption";
            this.labelMalfunctionDesciption.Size = new System.Drawing.Size(160, 18);
            this.labelMalfunctionDesciption.TabIndex = 0;
            this.labelMalfunctionDesciption.Text = "Malfunction description";
            // 
            // textBoxMalfunctionDescription
            // 
            this.textBoxMalfunctionDescription.Location = new System.Drawing.Point(216, 214);
            this.textBoxMalfunctionDescription.Name = "textBoxMalfunctionDescription";
            this.textBoxMalfunctionDescription.Size = new System.Drawing.Size(175, 20);
            this.textBoxMalfunctionDescription.TabIndex = 1;
            // 
            // textBoxRepairPrice
            // 
            this.textBoxRepairPrice.Location = new System.Drawing.Point(216, 264);
            this.textBoxRepairPrice.Name = "textBoxRepairPrice";
            this.textBoxRepairPrice.Size = new System.Drawing.Size(175, 20);
            this.textBoxRepairPrice.TabIndex = 3;
            // 
            // labelRepairPrice
            // 
            this.labelRepairPrice.AutoSize = true;
            this.labelRepairPrice.BackColor = System.Drawing.SystemColors.Control;
            this.labelRepairPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRepairPrice.Location = new System.Drawing.Point(32, 266);
            this.labelRepairPrice.Name = "labelRepairPrice";
            this.labelRepairPrice.Size = new System.Drawing.Size(87, 18);
            this.labelRepairPrice.TabIndex = 2;
            this.labelRepairPrice.Text = "Repair price";
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.BackColor = System.Drawing.SystemColors.Control;
            this.labelOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOwner.Location = new System.Drawing.Point(32, 101);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(52, 18);
            this.labelOwner.TabIndex = 4;
            this.labelOwner.Text = "Owner";
            // 
            // labelNewCarInspectionTitle
            // 
            this.labelNewCarInspectionTitle.AutoSize = true;
            this.labelNewCarInspectionTitle.BackColor = System.Drawing.SystemColors.Control;
            this.labelNewCarInspectionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewCarInspectionTitle.Location = new System.Drawing.Point(130, 25);
            this.labelNewCarInspectionTitle.Name = "labelNewCarInspectionTitle";
            this.labelNewCarInspectionTitle.Size = new System.Drawing.Size(170, 31);
            this.labelNewCarInspectionTitle.TabIndex = 6;
            this.labelNewCarInspectionTitle.Text = "Repair Order";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(89, 313);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 44);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonNewRepairOrder
            // 
            this.buttonNewRepairOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRepairOrder.Location = new System.Drawing.Point(246, 313);
            this.buttonNewRepairOrder.Name = "buttonNewRepairOrder";
            this.buttonNewRepairOrder.Size = new System.Drawing.Size(113, 44);
            this.buttonNewRepairOrder.TabIndex = 8;
            this.buttonNewRepairOrder.Text = "Create new repair order";
            this.buttonNewRepairOrder.UseVisualStyleBackColor = true;
            this.buttonNewRepairOrder.Click += new System.EventHandler(this.buttonNewRepairOrder_Click);
            // 
            // comboBoxOwners
            // 
            this.comboBoxOwners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOwners.FormattingEnabled = true;
            this.comboBoxOwners.Location = new System.Drawing.Point(136, 98);
            this.comboBoxOwners.Name = "comboBoxOwners";
            this.comboBoxOwners.Size = new System.Drawing.Size(191, 21);
            this.comboBoxOwners.TabIndex = 9;
            // 
            // buttonAddOwner
            // 
            this.buttonAddOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddOwner.Location = new System.Drawing.Point(350, 83);
            this.buttonAddOwner.Name = "buttonAddOwner";
            this.buttonAddOwner.Size = new System.Drawing.Size(80, 48);
            this.buttonAddOwner.TabIndex = 10;
            this.buttonAddOwner.Text = "Add owner";
            this.buttonAddOwner.UseVisualStyleBackColor = true;
            this.buttonAddOwner.Click += new System.EventHandler(this.buttonAddOwner_Click);
            // 
            // buttonAddVehicle
            // 
            this.buttonAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddVehicle.Location = new System.Drawing.Point(350, 142);
            this.buttonAddVehicle.Name = "buttonAddVehicle";
            this.buttonAddVehicle.Size = new System.Drawing.Size(80, 48);
            this.buttonAddVehicle.TabIndex = 13;
            this.buttonAddVehicle.Text = "Add vehicle";
            this.buttonAddVehicle.UseVisualStyleBackColor = true;
            this.buttonAddVehicle.Click += new System.EventHandler(this.buttonAddVehicle_Click);
            // 
            // comboBoxVehicles
            // 
            this.comboBoxVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVehicles.FormattingEnabled = true;
            this.comboBoxVehicles.Location = new System.Drawing.Point(136, 157);
            this.comboBoxVehicles.Name = "comboBoxVehicles";
            this.comboBoxVehicles.Size = new System.Drawing.Size(191, 21);
            this.comboBoxVehicles.TabIndex = 12;
            // 
            // labelVehicle
            // 
            this.labelVehicle.AutoSize = true;
            this.labelVehicle.BackColor = System.Drawing.SystemColors.Control;
            this.labelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVehicle.Location = new System.Drawing.Point(32, 160);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(55, 18);
            this.labelVehicle.TabIndex = 11;
            this.labelVehicle.Text = "Vehicle";
            // 
            // NewCarInspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(457, 384);
            this.Controls.Add(this.buttonAddVehicle);
            this.Controls.Add(this.comboBoxVehicles);
            this.Controls.Add(this.labelVehicle);
            this.Controls.Add(this.buttonAddOwner);
            this.Controls.Add(this.comboBoxOwners);
            this.Controls.Add(this.buttonNewRepairOrder);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelNewCarInspectionTitle);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.textBoxRepairPrice);
            this.Controls.Add(this.labelRepairPrice);
            this.Controls.Add(this.textBoxMalfunctionDescription);
            this.Controls.Add(this.labelMalfunctionDesciption);
            this.Name = "NewCarInspection";
            this.Text = "NewCarInspection";
            this.Load += new System.EventHandler(this.NewCarInspection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMalfunctionDesciption;
        private System.Windows.Forms.TextBox textBoxMalfunctionDescription;
        private System.Windows.Forms.TextBox textBoxRepairPrice;
        private System.Windows.Forms.Label labelRepairPrice;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.Label labelNewCarInspectionTitle;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonNewRepairOrder;
        private System.Windows.Forms.ComboBox comboBoxOwners;
        private System.Windows.Forms.Button buttonAddOwner;
        private System.Windows.Forms.Button buttonAddVehicle;
        private System.Windows.Forms.ComboBox comboBoxVehicles;
        private System.Windows.Forms.Label labelVehicle;
    }
}