
namespace CarServiceApp
{
    partial class DeleteCarInspectionInfo
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
            this.textBoxInspectionID = new System.Windows.Forms.TextBox();
            this.labelCarInspectionID = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxActiveCarInspections = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxInspectionID
            // 
            this.textBoxInspectionID.Location = new System.Drawing.Point(127, 586);
            this.textBoxInspectionID.Name = "textBoxInspectionID";
            this.textBoxInspectionID.Size = new System.Drawing.Size(127, 20);
            this.textBoxInspectionID.TabIndex = 17;
            // 
            // labelCarInspectionID
            // 
            this.labelCarInspectionID.AutoSize = true;
            this.labelCarInspectionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarInspectionID.Location = new System.Drawing.Point(123, 551);
            this.labelCarInspectionID.Name = "labelCarInspectionID";
            this.labelCarInspectionID.Size = new System.Drawing.Size(131, 20);
            this.labelCarInspectionID.TabIndex = 16;
            this.labelCarInspectionID.Text = "Car inspection ID";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(286, 551);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(97, 55);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "DELETE INFO";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Active car inspections";
            // 
            // listBoxActiveCarInspections
            // 
            this.listBoxActiveCarInspections.FormattingEnabled = true;
            this.listBoxActiveCarInspections.HorizontalScrollbar = true;
            this.listBoxActiveCarInspections.Location = new System.Drawing.Point(55, 109);
            this.listBoxActiveCarInspections.Name = "listBoxActiveCarInspections";
            this.listBoxActiveCarInspections.Size = new System.Drawing.Size(373, 420);
            this.listBoxActiveCarInspections.TabIndex = 13;
            // 
            // DeleteCarInspectionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(486, 642);
            this.Controls.Add(this.textBoxInspectionID);
            this.Controls.Add(this.labelCarInspectionID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxActiveCarInspections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DeleteCarInspectionInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteCarInspectionInfo";
            this.Load += new System.EventHandler(this.DeleteCarInspectionInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInspectionID;
        private System.Windows.Forms.Label labelCarInspectionID;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxActiveCarInspections;
    }
}