namespace ProductManageUI.UserControllers.Product
{
    partial class UpdateProductUC
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxbBarecode = new System.Windows.Forms.TextBox();
            this.TxbShortName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbProductName = new System.Windows.Forms.TextBox();
            this.PanelBasics = new System.Windows.Forms.Panel();
            this.BtnUpdateBasics = new System.Windows.Forms.Button();
            this.TxbId = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.TxbProducer = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.PanelPrice = new System.Windows.Forms.Panel();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TxbTax = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxbPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NudInEachShop = new System.Windows.Forms.NumericUpDown();
            this.NudAimInWarehouse = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.PanelStorage = new System.Windows.Forms.Panel();
            this.BtnUpdateStorage = new System.Windows.Forms.Button();
            this.TxbQantityInBox = new System.Windows.Forms.TextBox();
            this.TxbWeight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnUpdateAvaliability = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CkbIsInSale = new System.Windows.Forms.CheckBox();
            this.CkbIsAvaliableAtProducer = new System.Windows.Forms.CheckBox();
            this.PanelAvaliability = new System.Windows.Forms.Panel();
            this.PanelBasics.SuspendLayout();
            this.PanelPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudInEachShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAimInWarehouse)).BeginInit();
            this.PanelStorage.SuspendLayout();
            this.PanelAvaliability.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Barecode";
            // 
            // TxbBarecode
            // 
            this.TxbBarecode.Location = new System.Drawing.Point(12, 201);
            this.TxbBarecode.Name = "TxbBarecode";
            this.TxbBarecode.ReadOnly = true;
            this.TxbBarecode.Size = new System.Drawing.Size(267, 23);
            this.TxbBarecode.TabIndex = 0;
            // 
            // TxbShortName
            // 
            this.TxbShortName.Location = new System.Drawing.Point(12, 153);
            this.TxbShortName.Name = "TxbShortName";
            this.TxbShortName.Size = new System.Drawing.Size(267, 23);
            this.TxbShortName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Short Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Product Name";
            // 
            // TxbProductName
            // 
            this.TxbProductName.Location = new System.Drawing.Point(12, 105);
            this.TxbProductName.Name = "TxbProductName";
            this.TxbProductName.Size = new System.Drawing.Size(267, 23);
            this.TxbProductName.TabIndex = 0;
            // 
            // PanelBasics
            // 
            this.PanelBasics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelBasics.Controls.Add(this.BtnUpdateBasics);
            this.PanelBasics.Controls.Add(this.TxbId);
            this.PanelBasics.Controls.Add(this.label22);
            this.PanelBasics.Controls.Add(this.TxbProducer);
            this.PanelBasics.Controls.Add(this.label20);
            this.PanelBasics.Controls.Add(this.label16);
            this.PanelBasics.Controls.Add(this.label3);
            this.PanelBasics.Controls.Add(this.TxbBarecode);
            this.PanelBasics.Controls.Add(this.TxbShortName);
            this.PanelBasics.Controls.Add(this.label4);
            this.PanelBasics.Controls.Add(this.label5);
            this.PanelBasics.Controls.Add(this.TxbProductName);
            this.PanelBasics.Location = new System.Drawing.Point(10, 7);
            this.PanelBasics.Name = "PanelBasics";
            this.PanelBasics.Size = new System.Drawing.Size(380, 323);
            this.PanelBasics.TabIndex = 0;
            // 
            // BtnUpdateBasics
            // 
            this.BtnUpdateBasics.Location = new System.Drawing.Point(110, 289);
            this.BtnUpdateBasics.Name = "BtnUpdateBasics";
            this.BtnUpdateBasics.Size = new System.Drawing.Size(144, 23);
            this.BtnUpdateBasics.TabIndex = 4;
            this.BtnUpdateBasics.Text = "Update";
            this.BtnUpdateBasics.UseVisualStyleBackColor = true;
            this.BtnUpdateBasics.Click += new System.EventHandler(this.BtnUpdateBasics_Click);
            // 
            // TxbId
            // 
            this.TxbId.Location = new System.Drawing.Point(12, 54);
            this.TxbId.Name = "TxbId";
            this.TxbId.ReadOnly = true;
            this.TxbId.Size = new System.Drawing.Size(267, 23);
            this.TxbId.TabIndex = 0;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(12, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 15);
            this.label22.TabIndex = 1;
            this.label22.Text = "Id";
            // 
            // TxbProducer
            // 
            this.TxbProducer.Location = new System.Drawing.Point(12, 249);
            this.TxbProducer.Name = "TxbProducer";
            this.TxbProducer.ReadOnly = true;
            this.TxbProducer.Size = new System.Drawing.Size(267, 23);
            this.TxbProducer.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(12, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 30);
            this.label20.TabIndex = 3;
            this.label20.Text = "Basics";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 15);
            this.label16.TabIndex = 1;
            this.label16.Text = "Producer";
            // 
            // PanelPrice
            // 
            this.PanelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelPrice.Controls.Add(this.BtnUpdate);
            this.PanelPrice.Controls.Add(this.label19);
            this.PanelPrice.Controls.Add(this.label18);
            this.PanelPrice.Controls.Add(this.label17);
            this.PanelPrice.Controls.Add(this.TxbTax);
            this.PanelPrice.Controls.Add(this.label8);
            this.PanelPrice.Controls.Add(this.label9);
            this.PanelPrice.Controls.Add(this.TxbPrice);
            this.PanelPrice.Location = new System.Drawing.Point(10, 336);
            this.PanelPrice.Name = "PanelPrice";
            this.PanelPrice.Size = new System.Drawing.Size(380, 323);
            this.PanelPrice.TabIndex = 1;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(110, 289);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(144, 23);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdatePrice_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(11, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 30);
            this.label19.TabIndex = 3;
            this.label19.Text = "Price";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 15);
            this.label18.TabIndex = 0;
            this.label18.Text = "Price";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(24, 15);
            this.label17.TabIndex = 0;
            this.label17.Text = "Tax";
            // 
            // TxbTax
            // 
            this.TxbTax.Location = new System.Drawing.Point(12, 120);
            this.TxbTax.Name = "TxbTax";
            this.TxbTax.Size = new System.Drawing.Size(242, 23);
            this.TxbTax.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(260, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(260, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "$";
            // 
            // TxbPrice
            // 
            this.TxbPrice.Location = new System.Drawing.Point(12, 70);
            this.TxbPrice.Name = "TxbPrice";
            this.TxbPrice.Size = new System.Drawing.Size(242, 23);
            this.TxbPrice.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "Aim In Warehouse";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(12, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 30);
            this.label11.TabIndex = 3;
            this.label11.Text = "Storage";
            // 
            // NudInEachShop
            // 
            this.NudInEachShop.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudInEachShop.Location = new System.Drawing.Point(12, 120);
            this.NudInEachShop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudInEachShop.Name = "NudInEachShop";
            this.NudInEachShop.Size = new System.Drawing.Size(242, 23);
            this.NudInEachShop.TabIndex = 4;
            // 
            // NudAimInWarehouse
            // 
            this.NudAimInWarehouse.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudAimInWarehouse.Location = new System.Drawing.Point(12, 70);
            this.NudAimInWarehouse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudAimInWarehouse.Name = "NudAimInWarehouse";
            this.NudAimInWarehouse.Size = new System.Drawing.Size(242, 23);
            this.NudAimInWarehouse.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Weight";
            // 
            // PanelStorage
            // 
            this.PanelStorage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelStorage.Controls.Add(this.BtnUpdateStorage);
            this.PanelStorage.Controls.Add(this.TxbQantityInBox);
            this.PanelStorage.Controls.Add(this.TxbWeight);
            this.PanelStorage.Controls.Add(this.label15);
            this.PanelStorage.Controls.Add(this.label14);
            this.PanelStorage.Controls.Add(this.NudInEachShop);
            this.PanelStorage.Controls.Add(this.NudAimInWarehouse);
            this.PanelStorage.Controls.Add(this.label13);
            this.PanelStorage.Controls.Add(this.label10);
            this.PanelStorage.Controls.Add(this.label11);
            this.PanelStorage.Location = new System.Drawing.Point(396, 7);
            this.PanelStorage.Name = "PanelStorage";
            this.PanelStorage.Size = new System.Drawing.Size(380, 323);
            this.PanelStorage.TabIndex = 1;
            // 
            // BtnUpdateStorage
            // 
            this.BtnUpdateStorage.Location = new System.Drawing.Point(110, 289);
            this.BtnUpdateStorage.Name = "BtnUpdateStorage";
            this.BtnUpdateStorage.Size = new System.Drawing.Size(144, 23);
            this.BtnUpdateStorage.TabIndex = 4;
            this.BtnUpdateStorage.Text = "Update";
            this.BtnUpdateStorage.UseVisualStyleBackColor = true;
            this.BtnUpdateStorage.Click += new System.EventHandler(this.BtnUpdateStorage_Click);
            // 
            // TxbQantityInBox
            // 
            this.TxbQantityInBox.Location = new System.Drawing.Point(12, 216);
            this.TxbQantityInBox.Name = "TxbQantityInBox";
            this.TxbQantityInBox.ReadOnly = true;
            this.TxbQantityInBox.Size = new System.Drawing.Size(242, 23);
            this.TxbQantityInBox.TabIndex = 0;
            // 
            // TxbWeight
            // 
            this.TxbWeight.Location = new System.Drawing.Point(12, 168);
            this.TxbWeight.Name = "TxbWeight";
            this.TxbWeight.ReadOnly = true;
            this.TxbWeight.Size = new System.Drawing.Size(242, 23);
            this.TxbWeight.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 198);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Quantity In Box";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(149, 15);
            this.label14.TabIndex = 0;
            this.label14.Text = "Aim Quantity In Each Shop";
            // 
            // BtnUpdateAvaliability
            // 
            this.BtnUpdateAvaliability.Location = new System.Drawing.Point(110, 289);
            this.BtnUpdateAvaliability.Name = "BtnUpdateAvaliability";
            this.BtnUpdateAvaliability.Size = new System.Drawing.Size(144, 23);
            this.BtnUpdateAvaliability.TabIndex = 4;
            this.BtnUpdateAvaliability.Text = "Update";
            this.BtnUpdateAvaliability.UseVisualStyleBackColor = true;
            this.BtnUpdateAvaliability.Click += new System.EventHandler(this.BtnUpdateAvaliability_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Avaliability";
            // 
            // CkbIsInSale
            // 
            this.CkbIsInSale.AutoSize = true;
            this.CkbIsInSale.Location = new System.Drawing.Point(213, 52);
            this.CkbIsInSale.Name = "CkbIsInSale";
            this.CkbIsInSale.Size = new System.Drawing.Size(70, 19);
            this.CkbIsInSale.TabIndex = 4;
            this.CkbIsInSale.Text = "Is in sale";
            this.CkbIsInSale.UseVisualStyleBackColor = true;
            // 
            // CkbIsAvaliableAtProducer
            // 
            this.CkbIsAvaliableAtProducer.AutoSize = true;
            this.CkbIsAvaliableAtProducer.Location = new System.Drawing.Point(12, 52);
            this.CkbIsAvaliableAtProducer.Name = "CkbIsAvaliableAtProducer";
            this.CkbIsAvaliableAtProducer.Size = new System.Drawing.Size(141, 19);
            this.CkbIsAvaliableAtProducer.TabIndex = 4;
            this.CkbIsAvaliableAtProducer.Text = "Is avaliable at produer";
            this.CkbIsAvaliableAtProducer.UseVisualStyleBackColor = true;
            // 
            // PanelAvaliability
            // 
            this.PanelAvaliability.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAvaliability.Controls.Add(this.BtnUpdateAvaliability);
            this.PanelAvaliability.Controls.Add(this.label1);
            this.PanelAvaliability.Controls.Add(this.CkbIsInSale);
            this.PanelAvaliability.Controls.Add(this.CkbIsAvaliableAtProducer);
            this.PanelAvaliability.Cursor = System.Windows.Forms.Cursors.Default;
            this.PanelAvaliability.Location = new System.Drawing.Point(396, 336);
            this.PanelAvaliability.Name = "PanelAvaliability";
            this.PanelAvaliability.Size = new System.Drawing.Size(380, 323);
            this.PanelAvaliability.TabIndex = 1;
            // 
            // UpdateProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelStorage);
            this.Controls.Add(this.PanelAvaliability);
            this.Controls.Add(this.PanelBasics);
            this.Controls.Add(this.PanelPrice);
            this.Name = "UpdateProductUC";
            this.Size = new System.Drawing.Size(785, 669);
            this.PanelBasics.ResumeLayout(false);
            this.PanelBasics.PerformLayout();
            this.PanelPrice.ResumeLayout(false);
            this.PanelPrice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudInEachShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAimInWarehouse)).EndInit();
            this.PanelStorage.ResumeLayout(false);
            this.PanelStorage.PerformLayout();
            this.PanelAvaliability.ResumeLayout(false);
            this.PanelAvaliability.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbBarecode;
        private System.Windows.Forms.TextBox TxbShortName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbProductName;
        private System.Windows.Forms.Panel PanelBasics;
        private System.Windows.Forms.TextBox TxbTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxbPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PanelPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NudInEachShop;
        private System.Windows.Forms.NumericUpDown NudAimInWarehouse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel PanelStorage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox TxbProducer;
        private System.Windows.Forms.TextBox TxbQantityInBox;
        private System.Windows.Forms.TextBox TxbWeight;
        private System.Windows.Forms.TextBox TxbId;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button BtnUpdateBasics;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnUpdateStorage;
        private System.Windows.Forms.Button BtnUpdateAvaliability;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CkbIsInSale;
        private System.Windows.Forms.CheckBox CkbIsAvaliableAtProducer;
        private System.Windows.Forms.Panel PanelAvaliability;
    }
}
