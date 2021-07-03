
namespace CarServiceApp
{
    partial class CarInspections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarInspections));
            this.buttonCarInspectionHistory = new System.Windows.Forms.Button();
            this.buttonNewRepairOrder = new System.Windows.Forms.Button();
            this.buttonUpdateInspection = new System.Windows.Forms.Button();
            this.buttonDeleteInspection = new System.Windows.Forms.Button();
            this.listBoxActiveCarInspections = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCarInspectionHistory
            // 
            this.buttonCarInspectionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarInspectionHistory.Location = new System.Drawing.Point(276, 620);
            this.buttonCarInspectionHistory.Name = "buttonCarInspectionHistory";
            this.buttonCarInspectionHistory.Size = new System.Drawing.Size(140, 53);
            this.buttonCarInspectionHistory.TabIndex = 0;
            this.buttonCarInspectionHistory.Text = "Show car inspection history";
            this.buttonCarInspectionHistory.UseVisualStyleBackColor = true;
            this.buttonCarInspectionHistory.Click += new System.EventHandler(this.buttonCarInspectionHistory_Click);
            // 
            // buttonNewRepairOrder
            // 
            this.buttonNewRepairOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRepairOrder.Location = new System.Drawing.Point(103, 549);
            this.buttonNewRepairOrder.Name = "buttonNewRepairOrder";
            this.buttonNewRepairOrder.Size = new System.Drawing.Size(138, 59);
            this.buttonNewRepairOrder.TabIndex = 1;
            this.buttonNewRepairOrder.Text = "New repair order";
            this.buttonNewRepairOrder.UseVisualStyleBackColor = true;
            this.buttonNewRepairOrder.Click += new System.EventHandler(this.buttonNewInspection_Click);
            // 
            // buttonUpdateInspection
            // 
            this.buttonUpdateInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateInspection.Location = new System.Drawing.Point(275, 549);
            this.buttonUpdateInspection.Name = "buttonUpdateInspection";
            this.buttonUpdateInspection.Size = new System.Drawing.Size(141, 59);
            this.buttonUpdateInspection.TabIndex = 3;
            this.buttonUpdateInspection.Text = "Update info about existing car inspection";
            this.buttonUpdateInspection.UseVisualStyleBackColor = true;
            this.buttonUpdateInspection.Click += new System.EventHandler(this.buttonUpdateInspection_Click);
            // 
            // buttonDeleteInspection
            // 
            this.buttonDeleteInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteInspection.Location = new System.Drawing.Point(103, 620);
            this.buttonDeleteInspection.Name = "buttonDeleteInspection";
            this.buttonDeleteInspection.Size = new System.Drawing.Size(138, 53);
            this.buttonDeleteInspection.TabIndex = 2;
            this.buttonDeleteInspection.Text = "Delete car inspection";
            this.buttonDeleteInspection.UseVisualStyleBackColor = true;
            this.buttonDeleteInspection.Click += new System.EventHandler(this.buttonDeleteInspection_Click);
            // 
            // listBoxActiveCarInspections
            // 
            this.listBoxActiveCarInspections.FormattingEnabled = true;
            this.listBoxActiveCarInspections.HorizontalScrollbar = true;
            this.listBoxActiveCarInspections.Location = new System.Drawing.Point(73, 110);
            this.listBoxActiveCarInspections.Name = "listBoxActiveCarInspections";
            this.listBoxActiveCarInspections.Size = new System.Drawing.Size(373, 420);
            this.listBoxActiveCarInspections.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Active car inspections";
            // 
            // CarInspections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 685);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxActiveCarInspections);
            this.Controls.Add(this.buttonUpdateInspection);
            this.Controls.Add(this.buttonDeleteInspection);
            this.Controls.Add(this.buttonNewRepairOrder);
            this.Controls.Add(this.buttonCarInspectionHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CarInspections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarInspections";
            this.Load += new System.EventHandler(this.CarInspections_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCarInspectionHistory;
        private System.Windows.Forms.Button buttonNewRepairOrder;
        private System.Windows.Forms.Button buttonUpdateInspection;
        private System.Windows.Forms.Button buttonDeleteInspection;
        private System.Windows.Forms.ListBox listBoxActiveCarInspections;
        private System.Windows.Forms.Label label1;
    }
}