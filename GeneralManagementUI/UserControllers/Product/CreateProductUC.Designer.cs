namespace ProductManageUI.UserControllers.Product
{
    partial class CreateProductUC
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
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Panel panel3;
            this.NudQuantityWarehouse = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxProducer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbBarecode = new System.Windows.Forms.TextBox();
            this.TxbShortName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxbProductName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Price = new System.Windows.Forms.Label();
            this.TxbTax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxbPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.CkbIsInSale = new System.Windows.Forms.CheckBox();
            this.CkbIsAvaliableAtProducer = new System.Windows.Forms.CheckBox();
            this.BtnDiscard = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.NudEachShop = new System.Windows.Forms.NumericUpDown();
            this.NudWeight = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.NudQuoInBox = new System.Windows.Forms.NumericUpDown();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantityWarehouse)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEachShop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuoInBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(12, 6);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(83, 30);
            label10.TabIndex = 3;
            label10.Text = "Storage";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(12, 102);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(149, 15);
            label11.TabIndex = 0;
            label11.Text = "Aim Quantity In Each Shop";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(12, 52);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(153, 15);
            label14.TabIndex = 0;
            label14.Text = "Aim Quantity In Warehouse";
            // 
            // panel3
            // 
            panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel3.Controls.Add(this.NudQuoInBox);
            panel3.Controls.Add(this.NudWeight);
            panel3.Controls.Add(this.NudEachShop);
            panel3.Controls.Add(this.NudQuantityWarehouse);
            panel3.Controls.Add(this.label13);
            panel3.Controls.Add(this.label12);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label14);
            panel3.Location = new System.Drawing.Point(415, 14);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(380, 260);
            panel3.TabIndex = 1;
            // 
            // NudQuantityWarehouse
            // 
            this.NudQuantityWarehouse.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudQuantityWarehouse.Location = new System.Drawing.Point(12, 70);
            this.NudQuantityWarehouse.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudQuantityWarehouse.Name = "NudQuantityWarehouse";
            this.NudQuantityWarehouse.Size = new System.Drawing.Size(242, 23);
            this.NudQuantityWarehouse.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 15);
            this.label13.TabIndex = 0;
            this.label13.Text = "Quantity In Box";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 15);
            this.label12.TabIndex = 0;
            this.label12.Text = "Weight";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.CbxProducer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxbBarecode);
            this.panel1.Controls.Add(this.TxbShortName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TxbProductName);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 260);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(11, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Basics";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Producer";
            // 
            // CbxProducer
            // 
            this.CbxProducer.FormattingEnabled = true;
            this.CbxProducer.Location = new System.Drawing.Point(11, 216);
            this.CbxProducer.Name = "CbxProducer";
            this.CbxProducer.Size = new System.Drawing.Size(267, 23);
            this.CbxProducer.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Barecode";
            // 
            // TxbBarecode
            // 
            this.TxbBarecode.Location = new System.Drawing.Point(11, 168);
            this.TxbBarecode.Name = "TxbBarecode";
            this.TxbBarecode.Size = new System.Drawing.Size(267, 23);
            this.TxbBarecode.TabIndex = 0;
            // 
            // TxbShortName
            // 
            this.TxbShortName.Location = new System.Drawing.Point(11, 120);
            this.TxbShortName.Name = "TxbShortName";
            this.TxbShortName.Size = new System.Drawing.Size(267, 23);
            this.TxbShortName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Short Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // TxbProductName
            // 
            this.TxbProductName.Location = new System.Drawing.Point(11, 72);
            this.TxbProductName.Name = "TxbProductName";
            this.TxbProductName.Size = new System.Drawing.Size(267, 23);
            this.TxbProductName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Price);
            this.panel2.Controls.Add(this.TxbTax);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TxbPrice);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(13, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 165);
            this.panel2.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(12, 6);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(58, 30);
            this.Price.TabIndex = 3;
            this.Price.Text = "Price";
            // 
            // TxbTax
            // 
            this.TxbTax.Location = new System.Drawing.Point(12, 120);
            this.TxbTax.Name = "TxbTax";
            this.TxbTax.Size = new System.Drawing.Size(242, 23);
            this.TxbTax.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tax";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(260, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "$";
            // 
            // TxbPrice
            // 
            this.TxbPrice.Location = new System.Drawing.Point(12, 70);
            this.TxbPrice.Name = "TxbPrice";
            this.TxbPrice.Size = new System.Drawing.Size(242, 23);
            this.TxbPrice.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(12, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 30);
            this.label15.TabIndex = 3;
            this.label15.Text = "Avaliability";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.CkbIsInSale);
            this.panel4.Controls.Add(this.CkbIsAvaliableAtProducer);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(415, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 106);
            this.panel4.TabIndex = 1;
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
            // BtnDiscard
            // 
            this.BtnDiscard.Location = new System.Drawing.Point(415, 418);
            this.BtnDiscard.Name = "BtnDiscard";
            this.BtnDiscard.Size = new System.Drawing.Size(166, 43);
            this.BtnDiscard.TabIndex = 2;
            this.BtnDiscard.Text = "Discard";
            this.BtnDiscard.UseVisualStyleBackColor = true;
            this.BtnDiscard.Click += new System.EventHandler(this.BtnDiscard_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(629, 418);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(166, 43);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // NudEachShop
            // 
            this.NudEachShop.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NudEachShop.Location = new System.Drawing.Point(12, 120);
            this.NudEachShop.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudEachShop.Name = "NudEachShop";
            this.NudEachShop.Size = new System.Drawing.Size(242, 23);
            this.NudEachShop.TabIndex = 4;
            // 
            // NudWeight
            // 
            this.NudWeight.Location = new System.Drawing.Point(12, 168);
            this.NudWeight.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NudWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudWeight.Name = "NudWeight";
            this.NudWeight.Size = new System.Drawing.Size(242, 23);
            this.NudWeight.TabIndex = 4;
            this.NudWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-83, 303);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 15);
            this.label16.TabIndex = 0;
            this.label16.Text = "Quantity In Box";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(-27, 223);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(242, 23);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NudQuoInBox
            // 
            this.NudQuoInBox.Location = new System.Drawing.Point(12, 217);
            this.NudQuoInBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudQuoInBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudQuoInBox.Name = "NudQuoInBox";
            this.NudQuoInBox.Size = new System.Drawing.Size(242, 23);
            this.NudQuoInBox.TabIndex = 4;
            this.NudQuoInBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CreateProductUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnDiscard);
            this.Controls.Add(this.panel4);
            this.Controls.Add(panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CreateProductUC";
            this.Size = new System.Drawing.Size(811, 477);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantityWarehouse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudEachShop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuoInBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxProducer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbBarecode;
        private System.Windows.Forms.TextBox TxbShortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxbProductName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox TxbTax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxbPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox CkbIsInSale;
        private System.Windows.Forms.CheckBox CkbIsAvaliableAtProducer;
        private System.Windows.Forms.Button BtnDiscard;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox Txb;
        private System.Windows.Forms.NumericUpDown NudQuantityWarehouse;
        private System.Windows.Forms.NumericUpDown NudQuoInBox;
        private System.Windows.Forms.NumericUpDown NudWeight;
        private System.Windows.Forms.NumericUpDown NudEachShop;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}
