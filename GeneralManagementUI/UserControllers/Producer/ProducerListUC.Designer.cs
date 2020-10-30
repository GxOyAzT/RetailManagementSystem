namespace ProductManageUI.UserControllers.Producer
{
    partial class ProducerListUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TxbCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbCountry = new System.Windows.Forms.TextBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnSaveChanges = new System.Windows.Forms.Button();
            this.ProducerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvProducers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Company Name";
            // 
            // TxbCompanyName
            // 
            this.TxbCompanyName.Location = new System.Drawing.Point(35, 29);
            this.TxbCompanyName.Name = "TxbCompanyName";
            this.TxbCompanyName.Size = new System.Drawing.Size(218, 23);
            this.TxbCompanyName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Country";
            // 
            // TxbCountry
            // 
            this.TxbCountry.Location = new System.Drawing.Point(275, 29);
            this.TxbCountry.Name = "TxbCountry";
            this.TxbCountry.Size = new System.Drawing.Size(218, 23);
            this.TxbCountry.TabIndex = 3;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(511, 29);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(111, 23);
            this.BtnFilter.TabIndex = 4;
            this.BtnFilter.Text = "Search";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(628, 29);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(110, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnSaveChanges
            // 
            this.BtnSaveChanges.Location = new System.Drawing.Point(511, 431);
            this.BtnSaveChanges.Name = "BtnSaveChanges";
            this.BtnSaveChanges.Size = new System.Drawing.Size(227, 23);
            this.BtnSaveChanges.TabIndex = 5;
            this.BtnSaveChanges.Text = "Save changes";
            this.BtnSaveChanges.UseVisualStyleBackColor = true;
            this.BtnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // ProducerName
            // 
            this.ProducerName.DataPropertyName = "CompanyName";
            this.ProducerName.FillWeight = 150F;
            this.ProducerName.HeaderText = "Company Name";
            this.ProducerName.Name = "ProducerName";
            this.ProducerName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Country
            // 
            this.Country.DataPropertyName = "Country";
            this.Country.FillWeight = 150F;
            this.Country.HeaderText = "Country";
            this.Country.Name = "Country";
            this.Country.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.FillWeight = 150F;
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.FillWeight = 150F;
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProducerListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // DgvProducers
            // 
            this.DgvProducers.AllowUserToAddRows = false;
            this.DgvProducers.AllowUserToDeleteRows = false;
            this.DgvProducers.AllowUserToResizeColumns = false;
            this.DgvProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProducerName,
            this.Country,
            this.City,
            this.Street});
            this.DgvProducers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DgvProducers.Location = new System.Drawing.Point(0, 70);
            this.DgvProducers.MultiSelect = false;
            this.DgvProducers.Name = "DgvProducers";
            this.DgvProducers.ShowCellToolTips = false;
            this.DgvProducers.Size = new System.Drawing.Size(790, 355);
            this.DgvProducers.TabIndex = 0;
            this.DgvProducers.Text = "dataGridView1";
            this.Controls.Add(this.BtnSaveChanges);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnFilter);
            this.Controls.Add(this.TxbCountry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxbCompanyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvProducers);
            this.Name = "ProducerListUC";
            this.Size = new System.Drawing.Size(790, 458);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbCountry;
        private System.Windows.Forms.DataGridView DgvProducers;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnSaveChanges;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProducerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
    }
}
