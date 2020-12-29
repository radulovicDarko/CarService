
namespace CarServiceApp
{
    partial class UpdateCarInspectionInfo
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
            this.labelActiveCarInspections = new System.Windows.Forms.Label();
            this.listBoxCarInspections = new System.Windows.Forms.ListBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelCarInspectionID = new System.Windows.Forms.Label();
            this.textBoxInspectionID = new System.Windows.Forms.TextBox();
            this.buttonCloseInspection = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelActiveCarInspections
            // 
            this.labelActiveCarInspections.AutoSize = true;
            this.labelActiveCarInspections.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelActiveCarInspections.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveCarInspections.Location = new System.Drawing.Point(90, 27);
            this.labelActiveCarInspections.Name = "labelActiveCarInspections";
            this.labelActiveCarInspections.Size = new System.Drawing.Size(278, 31);
            this.labelActiveCarInspections.TabIndex = 9;
            this.labelActiveCarInspections.Text = "Active car inspections";
            // 
            // listBoxCarInspections
            // 
            this.listBoxCarInspections.FormattingEnabled = true;
            this.listBoxCarInspections.HorizontalScrollbar = true;
            this.listBoxCarInspections.Location = new System.Drawing.Point(40, 92);
            this.listBoxCarInspections.Name = "listBoxCarInspections";
            this.listBoxCarInspections.Size = new System.Drawing.Size(373, 420);
            this.listBoxCarInspections.TabIndex = 8;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(194, 529);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(102, 55);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "UPDATE INFO";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelCarInspectionID
            // 
            this.labelCarInspectionID.AutoSize = true;
            this.labelCarInspectionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarInspectionID.Location = new System.Drawing.Point(48, 529);
            this.labelCarInspectionID.Name = "labelCarInspectionID";
            this.labelCarInspectionID.Size = new System.Drawing.Size(133, 20);
            this.labelCarInspectionID.TabIndex = 11;
            this.labelCarInspectionID.Text = "Car Inspection ID";
            // 
            // textBoxInspectionID
            // 
            this.textBoxInspectionID.Location = new System.Drawing.Point(52, 564);
            this.textBoxInspectionID.Name = "textBoxInspectionID";
            this.textBoxInspectionID.Size = new System.Drawing.Size(127, 20);
            this.textBoxInspectionID.TabIndex = 12;
            // 
            // buttonCloseInspection
            // 
            this.buttonCloseInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCloseInspection.Location = new System.Drawing.Point(302, 529);
            this.buttonCloseInspection.Name = "buttonCloseInspection";
            this.buttonCloseInspection.Size = new System.Drawing.Size(102, 55);
            this.buttonCloseInspection.TabIndex = 13;
            this.buttonCloseInspection.Text = "CLOSE INSPECTION";
            this.buttonCloseInspection.UseVisualStyleBackColor = true;
            this.buttonCloseInspection.Click += new System.EventHandler(this.buttonCloseInspection_Click);
            // 
            // UpdateCarInspectionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background3;
            this.ClientSize = new System.Drawing.Size(458, 609);
            this.Controls.Add(this.buttonCloseInspection);
            this.Controls.Add(this.textBoxInspectionID);
            this.Controls.Add(this.labelCarInspectionID);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.labelActiveCarInspections);
            this.Controls.Add(this.listBoxCarInspections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateCarInspectionInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCarInspectionInfo";
            this.Load += new System.EventHandler(this.UpdateCarInspectionInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActiveCarInspections;
        private System.Windows.Forms.ListBox listBoxCarInspections;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelCarInspectionID;
        private System.Windows.Forms.TextBox textBoxInspectionID;
        private System.Windows.Forms.Button buttonCloseInspection;
    }
}