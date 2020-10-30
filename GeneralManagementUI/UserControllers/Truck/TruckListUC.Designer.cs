namespace GeneralManagementUI.UserControllers.Truck
{
    partial class TruckListUC
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
            this.CbxFilter = new System.Windows.Forms.ComboBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TruckName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsAvaliable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DgvTruck = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxFilter
            // 
            this.CbxFilter.FormattingEnabled = true;
            this.CbxFilter.Items.AddRange(new object[] {
            "No Filter",
            "Name",
            "Max Capacity",
            "Is Avaliable"});
            this.CbxFilter.Location = new System.Drawing.Point(345, 9);
            this.CbxFilter.Name = "CbxFilter";
            this.CbxFilter.Size = new System.Drawing.Size(165, 23);
            this.CbxFilter.TabIndex = 1;
            this.CbxFilter.Text = "Sort";
            this.CbxFilter.SelectedIndexChanged += new System.EventHandler(this.CbxSort_SelectedIndexChanged);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(345, 460);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(165, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TruckName
            // 
            this.TruckName.DataPropertyName = "Name";
            this.TruckName.HeaderText = "TruckName";
            this.TruckName.Name = "TruckName";
            this.TruckName.ReadOnly = true;
            this.TruckName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaxCapacity
            // 
            this.MaxCapacity.DataPropertyName = "MaxCapacity";
            this.MaxCapacity.HeaderText = "Max Capacity";
            this.MaxCapacity.Name = "MaxCapacity";
            this.MaxCapacity.ReadOnly = true;
            this.MaxCapacity.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IsAvaliable
            // 
            this.IsAvaliable.DataPropertyName = "IsAvaliable";
            this.IsAvaliable.HeaderText = "Is Avaliable";
            this.IsAvaliable.Name = "IsAvaliable";
            // 
            // TruckListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // 
            // DgvTruck
            // 
            this.DgvTruck.AllowUserToAddRows = false;
            this.DgvTruck.AllowUserToDeleteRows = false;
            this.DgvTruck.AllowUserToResizeColumns = false;
            this.DgvTruck.AllowUserToResizeRows = false;
            this.DgvTruck.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTruck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TruckName,
            this.MaxCapacity,
            this.IsAvaliable});
            this.DgvTruck.Location = new System.Drawing.Point(0, 41);
            this.DgvTruck.Name = "DgvTruck";
            this.DgvTruck.Size = new System.Drawing.Size(533, 413);
            this.DgvTruck.TabIndex = 0;
            this.DgvTruck.Text = "dataGridView1";
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CbxFilter);
            this.Controls.Add(this.DgvTruck);
            this.Name = "TruckListUC";
            this.Size = new System.Drawing.Size(533, 490);
            ((System.ComponentModel.ISupportInitialize)(this.DgvTruck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CbxFilter;
        private System.Windows.Forms.DataGridView DgvTruck;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn TruckName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxCapacity;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsAvaliable;
    }
}
