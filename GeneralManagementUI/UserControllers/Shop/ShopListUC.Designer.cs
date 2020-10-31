namespace ProductManageUI.UserControllers.Shop
{
    partial class ShopListUC
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
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDiscard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TxbStreet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgvShop = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShop)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(168, 390);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(120, 23);
            this.BtnSave.TabIndex = 1;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDiscard
            // 
            this.BtnDiscard.Location = new System.Drawing.Point(42, 390);
            this.BtnDiscard.Name = "BtnDiscard";
            this.BtnDiscard.Size = new System.Drawing.Size(120, 23);
            this.BtnDiscard.TabIndex = 1;
            this.BtnDiscard.Text = "Discard";
            this.BtnDiscard.UseVisualStyleBackColor = true;
            this.BtnDiscard.Click += new System.EventHandler(this.BtnDiscard_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxbStreet);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxbCity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnDiscard);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Location = new System.Drawing.Point(551, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 459);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(117, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change data";
            // 
            // TxbStreet
            // 
            this.TxbStreet.Location = new System.Drawing.Point(69, 223);
            this.TxbStreet.Name = "TxbStreet";
            this.TxbStreet.Size = new System.Drawing.Size(194, 23);
            this.TxbStreet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Street";
            // 
            // TxbCity
            // 
            this.TxbCity.Location = new System.Drawing.Point(69, 176);
            this.TxbCity.Name = "TxbCity";
            this.TxbCity.Size = new System.Drawing.Size(194, 23);
            this.TxbCity.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "City";
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Street
            // 
            this.Street.DataPropertyName = "Street";
            this.Street.HeaderText = "Street";
            this.Street.Name = "Street";
            this.Street.ReadOnly = true;
            this.Street.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DgvShop
            // 
            this.DgvShop.AllowUserToAddRows = false;
            this.DgvShop.AllowUserToDeleteRows = false;
            this.DgvShop.AllowUserToResizeColumns = false;
            this.DgvShop.AllowUserToResizeRows = false;
            this.DgvShop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvShop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvShop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvShop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.City,
            this.Street});
            this.DgvShop.Location = new System.Drawing.Point(0, 0);
            this.DgvShop.MultiSelect = false;
            this.DgvShop.Name = "DgvShop";
            this.DgvShop.ReadOnly = true;
            this.DgvShop.Size = new System.Drawing.Size(545, 459);
            this.DgvShop.TabIndex = 0;
            this.DgvShop.Text = "dataGridView1";
            this.DgvShop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvShop_MouseClick);
            // 
            // ShopListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvShop);
            this.Name = "ShopListUC";
            this.Size = new System.Drawing.Size(885, 459);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvShop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDiscard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgvShop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxbStreet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
    }
}
