
namespace CarServiceApp
{
    partial class UpdateOwnerInfo
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
            this.textBoxClientID = new System.Windows.Forms.TextBox();
            this.labelClientID = new System.Windows.Forms.Label();
            this.buttonUpdateClientInfo = new System.Windows.Forms.Button();
            this.labelClients = new System.Windows.Forms.Label();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(112, 572);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(127, 20);
            this.textBoxClientID.TabIndex = 18;
            // 
            // labelClientID
            // 
            this.labelClientID.AutoSize = true;
            this.labelClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClientID.Location = new System.Drawing.Point(138, 537);
            this.labelClientID.Name = "labelClientID";
            this.labelClientID.Size = new System.Drawing.Size(70, 20);
            this.labelClientID.TabIndex = 17;
            this.labelClientID.Text = "Client ID";
            // 
            // buttonUpdateClientInfo
            // 
            this.buttonUpdateClientInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateClientInfo.Location = new System.Drawing.Point(254, 537);
            this.buttonUpdateClientInfo.Name = "buttonUpdateClientInfo";
            this.buttonUpdateClientInfo.Size = new System.Drawing.Size(102, 55);
            this.buttonUpdateClientInfo.TabIndex = 16;
            this.buttonUpdateClientInfo.Text = "UPDATE INFO";
            this.buttonUpdateClientInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateClientInfo.Click += new System.EventHandler(this.buttonUpdateClientInfo_Click);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.Location = new System.Drawing.Point(175, 33);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(98, 31);
            this.labelClients.TabIndex = 15;
            this.labelClients.Text = "Clients";
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.HorizontalScrollbar = true;
            this.listBoxClients.Location = new System.Drawing.Point(48, 92);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(373, 420);
            this.listBoxClients.TabIndex = 14;
            // 
            // UpdateOwnerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background5;
            this.ClientSize = new System.Drawing.Size(471, 620);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.labelClientID);
            this.Controls.Add(this.buttonUpdateClientInfo);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.listBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateOwnerInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateOwnerInfo";
            this.Load += new System.EventHandler(this.UpdateOwnerInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label labelClientID;
        private System.Windows.Forms.Button buttonUpdateClientInfo;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.ListBox listBoxClients;
    }
}