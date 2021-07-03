
namespace CarServiceApp
{
    partial class DeleteClientInfo
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
            this.labelCarClientID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelClients = new System.Windows.Forms.Label();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxClientID
            // 
            this.textBoxClientID.Location = new System.Drawing.Point(50, 573);
            this.textBoxClientID.Name = "textBoxClientID";
            this.textBoxClientID.Size = new System.Drawing.Size(127, 20);
            this.textBoxClientID.TabIndex = 22;
            // 
            // labelCarClientID
            // 
            this.labelCarClientID.AutoSize = true;
            this.labelCarClientID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarClientID.Location = new System.Drawing.Point(78, 538);
            this.labelCarClientID.Name = "labelCarClientID";
            this.labelCarClientID.Size = new System.Drawing.Size(70, 20);
            this.labelCarClientID.TabIndex = 21;
            this.labelCarClientID.Text = "Client ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(209, 538);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 55);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "DELETE INFO";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClients.Location = new System.Drawing.Point(176, 36);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(98, 31);
            this.labelClients.TabIndex = 19;
            this.labelClients.Text = "Clients";
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.HorizontalScrollbar = true;
            this.listBoxClients.Location = new System.Drawing.Point(44, 102);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(373, 420);
            this.listBoxClients.TabIndex = 18;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(320, 538);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(97, 55);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // DeleteClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(462, 622);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.textBoxClientID);
            this.Controls.Add(this.labelCarClientID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.listBoxClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteClientInfo";
            this.Load += new System.EventHandler(this.DeleteClientInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxClientID;
        private System.Windows.Forms.Label labelCarClientID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.ListBox listBoxClients;
        private System.Windows.Forms.Button buttonClose;
    }
}