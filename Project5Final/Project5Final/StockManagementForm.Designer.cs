namespace Project5Final
{
    partial class StockManagementForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.unitsComboBox = new System.Windows.Forms.ComboBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.stocksDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.increaseRadioButton = new System.Windows.Forms.RadioButton();
            this.decreaseRadioButton = new System.Windows.Forms.RadioButton();
            this.manageStockButton = new System.Windows.Forms.Button();
            this.stockActionGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.stockActionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK (INCREASE / DECREASE)";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Blood Group";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Units";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bloodGroupComboBox
            // 
            this.bloodGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bloodGroupComboBox.FormattingEnabled = true;
            this.bloodGroupComboBox.Items.AddRange(new object[] {
            "A+",
            "O+",
            "B+",
            "AB+",
            "A-",
            "O-",
            "B-",
            "AB-"});
            this.bloodGroupComboBox.Location = new System.Drawing.Point(133, 84);
            this.bloodGroupComboBox.Name = "bloodGroupComboBox";
            this.bloodGroupComboBox.Size = new System.Drawing.Size(121, 21);
            this.bloodGroupComboBox.TabIndex = 3;
            // 
            // unitsComboBox
            // 
            this.unitsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitsComboBox.FormattingEnabled = true;
            this.unitsComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.unitsComboBox.Location = new System.Drawing.Point(354, 84);
            this.unitsComboBox.Name = "unitsComboBox";
            this.unitsComboBox.Size = new System.Drawing.Size(121, 21);
            this.unitsComboBox.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(598, 499);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 27);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // stocksDataGridView
            // 
            this.stocksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stocksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stocksDataGridView.Location = new System.Drawing.Point(12, 163);
            this.stocksDataGridView.Name = "stocksDataGridView";
            this.stocksDataGridView.Size = new System.Drawing.Size(686, 317);
            this.stocksDataGridView.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // increaseRadioButton
            // 
            this.increaseRadioButton.AutoSize = true;
            this.increaseRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.increaseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.increaseRadioButton.Location = new System.Drawing.Point(17, 22);
            this.increaseRadioButton.Name = "increaseRadioButton";
            this.increaseRadioButton.Size = new System.Drawing.Size(80, 19);
            this.increaseRadioButton.TabIndex = 9;
            this.increaseRadioButton.TabStop = true;
            this.increaseRadioButton.Text = "Increase";
            this.increaseRadioButton.UseVisualStyleBackColor = false;
            this.increaseRadioButton.CheckedChanged += new System.EventHandler(this.increaseDecreaseRadioButton_CheckedChanged);
            // 
            // decreaseRadioButton
            // 
            this.decreaseRadioButton.AutoSize = true;
            this.decreaseRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.decreaseRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decreaseRadioButton.Location = new System.Drawing.Point(17, 56);
            this.decreaseRadioButton.Name = "decreaseRadioButton";
            this.decreaseRadioButton.Size = new System.Drawing.Size(86, 19);
            this.decreaseRadioButton.TabIndex = 10;
            this.decreaseRadioButton.TabStop = true;
            this.decreaseRadioButton.Text = "Decrease";
            this.decreaseRadioButton.UseVisualStyleBackColor = false;
            this.decreaseRadioButton.CheckedChanged += new System.EventHandler(this.increaseDecreaseRadioButton_CheckedChanged);
            // 
            // manageStockButton
            // 
            this.manageStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStockButton.Location = new System.Drawing.Point(633, 89);
            this.manageStockButton.Name = "manageStockButton";
            this.manageStockButton.Size = new System.Drawing.Size(75, 30);
            this.manageStockButton.TabIndex = 11;
            this.manageStockButton.Text = "Manage";
            this.manageStockButton.UseVisualStyleBackColor = true;
            this.manageStockButton.Click += new System.EventHandler(this.manageStockButton_Click);
            // 
            // stockActionGroupBox
            // 
            this.stockActionGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.stockActionGroupBox.Controls.Add(this.increaseRadioButton);
            this.stockActionGroupBox.Controls.Add(this.decreaseRadioButton);
            this.stockActionGroupBox.Location = new System.Drawing.Point(491, 67);
            this.stockActionGroupBox.Name = "stockActionGroupBox";
            this.stockActionGroupBox.Size = new System.Drawing.Size(135, 90);
            this.stockActionGroupBox.TabIndex = 12;
            this.stockActionGroupBox.TabStop = false;
            this.stockActionGroupBox.Text = "Action";
            // 
            // StockManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project5Final.Properties.Resources.AllPagesBackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(720, 550);
            this.Controls.Add(this.stockActionGroupBox);
            this.Controls.Add(this.manageStockButton);
            this.Controls.Add(this.stocksDataGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.unitsComboBox);
            this.Controls.Add(this.bloodGroupComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockManagementForm";
            this.Load += new System.EventHandler(this.StockManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stocksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.stockActionGroupBox.ResumeLayout(false);
            this.stockActionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox bloodGroupComboBox;
        private System.Windows.Forms.ComboBox unitsComboBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView stocksDataGridView;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton decreaseRadioButton;
        private System.Windows.Forms.RadioButton increaseRadioButton;
        private System.Windows.Forms.Button manageStockButton;
        private System.Windows.Forms.GroupBox stockActionGroupBox;
    }
}