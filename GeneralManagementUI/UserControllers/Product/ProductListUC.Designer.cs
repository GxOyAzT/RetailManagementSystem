namespace ProductManageUI.UserControllers.Product
{
    partial class ProductListUC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnDiscard = new System.Windows.Forms.Button();
            this.CkbIsAvaliableAtProducer = new System.Windows.Forms.CheckBox();
            this.CkbIsInSale = new System.Windows.Forms.CheckBox();
            this.BtnFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxbCompanyName = new System.Windows.Forms.TextBox();
            this.TxbNameBarecode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvProducts = new System.Windows.Forms.DataGridView();
            this.BtnChange = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnDiscard);
            this.panel1.Controls.Add(this.CkbIsAvaliableAtProducer);
            this.panel1.Controls.Add(this.CkbIsInSale);
            this.panel1.Controls.Add(this.BtnFilter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TxbCompanyName);
            this.panel1.Controls.Add(this.TxbNameBarecode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 93);
            this.panel1.TabIndex = 0;
            // 
            // BtnDiscard
            // 
            this.BtnDiscard.Location = new System.Drawing.Point(197, 57);
            this.BtnDiscard.Name = "BtnDiscard";
            this.BtnDiscard.Size = new System.Drawing.Size(181, 36);
            this.BtnDiscard.TabIndex = 2;
            this.BtnDiscard.Text = "Discard";
            this.BtnDiscard.UseVisualStyleBackColor = true;
            this.BtnDiscard.Click += new System.EventHandler(this.BtnDiscard_Click);
            // 
            // CkbIsAvaliableAtProducer
            // 
            this.CkbIsAvaliableAtProducer.AutoSize = true;
            this.CkbIsAvaliableAtProducer.Checked = true;
            this.CkbIsAvaliableAtProducer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbIsAvaliableAtProducer.Location = new System.Drawing.Point(693, 31);
            this.CkbIsAvaliableAtProducer.Name = "CkbIsAvaliableAtProducer";
            this.CkbIsAvaliableAtProducer.Size = new System.Drawing.Size(147, 19);
            this.CkbIsAvaliableAtProducer.TabIndex = 3;
            this.CkbIsAvaliableAtProducer.Text = "Is avaliable at producer";
            this.CkbIsAvaliableAtProducer.UseVisualStyleBackColor = true;
            // 
            // CkbIsInSale
            // 
            this.CkbIsInSale.AutoSize = true;
            this.CkbIsInSale.Checked = true;
            this.CkbIsInSale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CkbIsInSale.Location = new System.Drawing.Point(602, 31);
            this.CkbIsInSale.Name = "CkbIsInSale";
            this.CkbIsInSale.Size = new System.Drawing.Size(70, 19);
            this.CkbIsInSale.TabIndex = 3;
            this.CkbIsInSale.Text = "Is in sale";
            this.CkbIsInSale.UseVisualStyleBackColor = true;
            // 
            // BtnFilter
            // 
            this.BtnFilter.Location = new System.Drawing.Point(10, 57);
            this.BtnFilter.Name = "BtnFilter";
            this.BtnFilter.Size = new System.Drawing.Size(181, 36);
            this.BtnFilter.TabIndex = 2;
            this.BtnFilter.Text = "Search";
            this.BtnFilter.UseVisualStyleBackColor = true;
            this.BtnFilter.Click += new System.EventHandler(this.BtnFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Company Name";
            // 
            // TxbCompanyName
            // 
            this.TxbCompanyName.Location = new System.Drawing.Point(306, 27);
            this.TxbCompanyName.Name = "TxbCompanyName";
            this.TxbCompanyName.Size = new System.Drawing.Size(268, 23);
            this.TxbCompanyName.TabIndex = 1;
            // 
            // TxbNameBarecode
            // 
            this.TxbNameBarecode.Location = new System.Drawing.Point(10, 27);
            this.TxbNameBarecode.Name = "TxbNameBarecode";
            this.TxbNameBarecode.Size = new System.Drawing.Size(268, 23);
            this.TxbNameBarecode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name / Barecode";
            // 
            // DgvProducts
            // 
            this.DgvProducts.AllowUserToAddRows = false;
            this.DgvProducts.AllowUserToDeleteRows = false;
            this.DgvProducts.AllowUserToResizeColumns = false;
            this.DgvProducts.AllowUserToResizeRows = false;
            this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProducts.Location = new System.Drawing.Point(0, 99);
            this.DgvProducts.Name = "DgvProducts";
            this.DgvProducts.Size = new System.Drawing.Size(1489, 600);
            this.DgvProducts.TabIndex = 1;
            this.DgvProducts.Text = "dataGridView1";
            // 
            // BtnChange
            // 
            this.BtnChange.Location = new System.Drawing.Point(1315, 705);
            this.BtnChange.Name = "BtnChange";
            this.BtnChange.Size = new System.Drawing.Size(158, 23);
            this.BtnChange.TabIndex = 2;
            this.BtnChange.Text = "Modify";
            this.BtnChange.UseVisualStyleBackColor = true;
            this.BtnChange.Click += new System.EventHandler(this.BtnChange_Click);
            // 
            // ProductListUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnChange);
            this.Controls.Add(this.DgvProducts);
            this.Controls.Add(this.panel1);
            this.Name = "ProductListUC";
            this.Size = new System.Drawing.Size(1489, 736);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TxbNameBarecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbCompanyName;
        private System.Windows.Forms.Button BtnFilter;
        private System.Windows.Forms.CheckBox CkbIsAvaliableAtProducer;
        private System.Windows.Forms.CheckBox CkbIsInSale;
        private System.Windows.Forms.Button BtnDiscard;
        private System.Windows.Forms.Button BtnChange;
    }
}
