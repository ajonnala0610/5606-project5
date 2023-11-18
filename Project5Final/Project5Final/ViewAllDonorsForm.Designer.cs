namespace Project5Final
{
    partial class ViewAllDonorsForm
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
            this.viewAllDonorLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.bbDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewAllDonorLabel
            // 
            this.viewAllDonorLabel.AutoSize = true;
            this.viewAllDonorLabel.BackColor = System.Drawing.Color.Transparent;
            this.viewAllDonorLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllDonorLabel.Location = new System.Drawing.Point(340, 24);
            this.viewAllDonorLabel.Name = "viewAllDonorLabel";
            this.viewAllDonorLabel.Size = new System.Drawing.Size(207, 32);
            this.viewAllDonorLabel.TabIndex = 0;
            this.viewAllDonorLabel.Text = "View All Donors";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(772, 402);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(83, 35);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bbDataGridView
            // 
            this.bbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bbDataGridView.Location = new System.Drawing.Point(55, 72);
            this.bbDataGridView.Name = "bbDataGridView";
            this.bbDataGridView.RowHeadersWidth = 51;
            this.bbDataGridView.RowTemplate.Height = 24;
            this.bbDataGridView.Size = new System.Drawing.Size(776, 298);
            this.bbDataGridView.TabIndex = 2;
            // 
            // ViewAllDonorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project5Final.Properties.Resources.BackgroundGradient;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 497);
            this.Controls.Add(this.bbDataGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.viewAllDonorLabel);
            this.Name = "ViewAllDonorsForm";
            this.Text = "ViewAllDonorsForm";
            this.Load += new System.EventHandler(this.ViewAllDonorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewAllDonorLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView bbDataGridView;
    }
}