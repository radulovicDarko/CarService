
namespace CarServiceApp
{
    partial class ClientsVehicles
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
            this.labelClientID = new System.Windows.Forms.Label();
            this.buttonShowVehicles = new System.Windows.Forms.Button();
            this.labelClients = new System.Windows.Forms.Label();
            this.listBoxClientsVehicles = new System.Windows.Forms.ListBox();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientID.Location = new System.Drawing.Point(129, 545);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(70, 20);
            this.labelClientID.TabIndex = 22;
            this.labelClientID.Text = "Client ID";
            // 
            // buttonShowVehicles
            // 
            this.buttonShowVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowVehicles.Location = new System.Drawing.Point(273, 545);
            this.buttonShowVehicles.Name = "buttonShowVehicles";
            this.buttonShowVehicles.Size = new System.Drawing.Size(106, 54);
            this.buttonShowVehicles.TabIndex = 21;
            this.buttonShowVehicles.Text = "SHOW VEHICLES";
            this.buttonShowVehicles.UseVisualStyleBackColor = true;
            this.buttonShowVehicles.Click += new System.EventHandler(this.buttonShowVehicles_Click);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.Location = new System.Drawing.Point(132, 36);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(209, 31);
            this.labelClients.TabIndex = 20;
            this.labelClients.Text = "Client\'s vehicles";
            // 
            // listBoxClientsVehicles
            // 
            this.listBoxClientsVehicles.FormattingEnabled = true;
            this.listBoxClientsVehicles.HorizontalScrollbar = true;
            this.listBoxClientsVehicles.Location = new System.Drawing.Point(51, 96);
            this.listBoxClientsVehicles.Name = "listBoxClientsVehicles";
            this.listBoxClientsVehicles.Size = new System.Drawing.Size(373, 420);
            this.listBoxClientsVehicles.TabIndex = 19;
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(77, 578);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(172, 21);
            this.comboBoxClients.TabIndex = 23;
            // 
            // ClientsVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background6;
            this.ClientSize = new System.Drawing.Size(477, 648);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.labelClientID);
            this.Controls.Add(this.buttonShowVehicles);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.listBoxClientsVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ClientsVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientsVehicles";
            this.Load += new System.EventHandler(this.ClientsVehicles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Button buttonShowVehicles;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.ListBox listBoxClientsVehicles;
        private System.Windows.Forms.ComboBox comboBoxClients;
    }
}