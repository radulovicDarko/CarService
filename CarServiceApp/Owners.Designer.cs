
namespace CarServiceApp
{
    partial class Owners
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.buttonUpdateClient = new System.Windows.Forms.Button();
            this.buttonDeleteClient = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.buttonClientsVehicles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Existing clients";
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.Location = new System.Drawing.Point(70, 107);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(373, 420);
            this.listBoxClients.TabIndex = 12;
            // 
            // buttonUpdateClient
            // 
            this.buttonUpdateClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateClient.Location = new System.Drawing.Point(272, 552);
            this.buttonUpdateClient.Name = "buttonUpdateClient";
            this.buttonUpdateClient.Size = new System.Drawing.Size(141, 47);
            this.buttonUpdateClient.TabIndex = 11;
            this.buttonUpdateClient.Text = "Update info about existing client";
            this.buttonUpdateClient.UseVisualStyleBackColor = true;
            this.buttonUpdateClient.Click += new System.EventHandler(this.buttonUpdateClient_Click);
            // 
            // buttonDeleteClient
            // 
            this.buttonDeleteClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteClient.Location = new System.Drawing.Point(100, 617);
            this.buttonDeleteClient.Name = "buttonDeleteClient";
            this.buttonDeleteClient.Size = new System.Drawing.Size(138, 47);
            this.buttonDeleteClient.TabIndex = 10;
            this.buttonDeleteClient.Text = "Delete client";
            this.buttonDeleteClient.UseVisualStyleBackColor = true;
            this.buttonDeleteClient.Click += new System.EventHandler(this.buttonDeleteClient_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewClient.Location = new System.Drawing.Point(100, 552);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(138, 47);
            this.buttonNewClient.TabIndex = 9;
            this.buttonNewClient.Text = "New client";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.buttonNewClient_Click);
            // 
            // buttonClientsVehicles
            // 
            this.buttonClientsVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientsVehicles.Location = new System.Drawing.Point(273, 617);
            this.buttonClientsVehicles.Name = "buttonClientsVehicles";
            this.buttonClientsVehicles.Size = new System.Drawing.Size(140, 47);
            this.buttonClientsVehicles.TabIndex = 8;
            this.buttonClientsVehicles.Text = "Show clients vehicles";
            this.buttonClientsVehicles.UseVisualStyleBackColor = true;
            this.buttonClientsVehicles.Click += new System.EventHandler(this.buttonClientsVehicles_Click);
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxClients);
            this.Controls.Add(this.buttonUpdateClient);
            this.Controls.Add(this.buttonDeleteClient);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.buttonClientsVehicles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Owners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Owners_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Button buttonUpdateClient;
        private System.Windows.Forms.Button buttonDeleteClient;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Button buttonClientsVehicles;
    }
}