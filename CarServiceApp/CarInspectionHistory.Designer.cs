
namespace CarServiceApp
{
    partial class CarInspectionHistory
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
            this.labelCarInspectionHistory = new System.Windows.Forms.Label();
            this.listBoxCarInspectionHistory = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCarInspectionHistory
            // 
            this.labelCarInspectionHistory.AutoSize = true;
            this.labelCarInspectionHistory.BackColor = System.Drawing.Color.LightSeaGreen;
            this.labelCarInspectionHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarInspectionHistory.Location = new System.Drawing.Point(124, 30);
            this.labelCarInspectionHistory.Name = "labelCarInspectionHistory";
            this.labelCarInspectionHistory.Size = new System.Drawing.Size(276, 31);
            this.labelCarInspectionHistory.TabIndex = 10;
            this.labelCarInspectionHistory.Text = "Car inspection history";
            // 
            // listBoxCarInspectionHistory
            // 
            this.listBoxCarInspectionHistory.FormattingEnabled = true;
            this.listBoxCarInspectionHistory.HorizontalScrollbar = true;
            this.listBoxCarInspectionHistory.Location = new System.Drawing.Point(80, 86);
            this.listBoxCarInspectionHistory.Name = "listBoxCarInspectionHistory";
            this.listBoxCarInspectionHistory.Size = new System.Drawing.Size(373, 420);
            this.listBoxCarInspectionHistory.TabIndex = 9;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(130, 528);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(252, 37);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CarInspectionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarServiceApp.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(533, 577);
            this.Controls.Add(this.labelCarInspectionHistory);
            this.Controls.Add(this.listBoxCarInspectionHistory);
            this.Controls.Add(this.buttonClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CarInspectionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarInspectionHistory";
            this.Load += new System.EventHandler(this.CarInspectionHistory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCarInspectionHistory;
        private System.Windows.Forms.ListBox listBoxCarInspectionHistory;
        private System.Windows.Forms.Button buttonClose;
    }
}