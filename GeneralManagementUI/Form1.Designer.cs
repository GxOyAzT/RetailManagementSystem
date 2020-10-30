namespace ProductManage
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnTrucks = new System.Windows.Forms.Button();
            this.BtnAddTruck = new System.Windows.Forms.Button();
            this.BtnAllShops = new System.Windows.Forms.Button();
            this.BtnNewShop = new System.Windows.Forms.Button();
            this.BtnAllProducts = new System.Windows.Forms.Button();
            this.BtnCreateNewProduct = new System.Windows.Forms.Button();
            this.btnAddNewProducer = new System.Windows.Forms.Button();
            this.BtnProducers = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.MainPanel, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1184, 661);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.BtnTrucks, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.BtnAddTruck, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.BtnAllShops, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.BtnNewShop, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.BtnAllProducts, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.BtnCreateNewProduct, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAddNewProducer, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.BtnProducers, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 589);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // BtnTrucks
            // 
            this.BtnTrucks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnTrucks.Location = new System.Drawing.Point(3, 514);
            this.BtnTrucks.Name = "BtnTrucks";
            this.BtnTrucks.Size = new System.Drawing.Size(188, 72);
            this.BtnTrucks.TabIndex = 0;
            this.BtnTrucks.Text = "Trucks";
            this.BtnTrucks.UseVisualStyleBackColor = true;
            this.BtnTrucks.Click += new System.EventHandler(this.BtnTrucks_Click);
            // 
            // BtnAddTruck
            // 
            this.BtnAddTruck.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAddTruck.Location = new System.Drawing.Point(3, 441);
            this.BtnAddTruck.Name = "BtnAddTruck";
            this.BtnAddTruck.Size = new System.Drawing.Size(188, 67);
            this.BtnAddTruck.TabIndex = 0;
            this.BtnAddTruck.Text = "New Truck";
            this.BtnAddTruck.UseVisualStyleBackColor = true;
            this.BtnAddTruck.Click += new System.EventHandler(this.BtnAddTruck_Click);
            // 
            // BtnAllShops
            // 
            this.BtnAllShops.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAllShops.Location = new System.Drawing.Point(3, 368);
            this.BtnAllShops.Name = "BtnAllShops";
            this.BtnAllShops.Size = new System.Drawing.Size(188, 67);
            this.BtnAllShops.TabIndex = 0;
            this.BtnAllShops.Text = "Shops";
            this.BtnAllShops.UseVisualStyleBackColor = true;
            this.BtnAllShops.Click += new System.EventHandler(this.BtnAllShops_Click);
            // 
            // BtnNewShop
            // 
            this.BtnNewShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNewShop.Location = new System.Drawing.Point(3, 295);
            this.BtnNewShop.Name = "BtnNewShop";
            this.BtnNewShop.Size = new System.Drawing.Size(188, 67);
            this.BtnNewShop.TabIndex = 0;
            this.BtnNewShop.Text = "New Shop";
            this.BtnNewShop.UseVisualStyleBackColor = true;
            this.BtnNewShop.Click += new System.EventHandler(this.BtnNewShop_Click);
            // 
            // BtnAllProducts
            // 
            this.BtnAllProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnAllProducts.Location = new System.Drawing.Point(3, 222);
            this.BtnAllProducts.Name = "BtnAllProducts";
            this.BtnAllProducts.Size = new System.Drawing.Size(188, 67);
            this.BtnAllProducts.TabIndex = 0;
            this.BtnAllProducts.Text = "Products";
            this.BtnAllProducts.UseVisualStyleBackColor = true;
            this.BtnAllProducts.Click += new System.EventHandler(this.BtnAllProducts_Click);
            // 
            // BtnCreateNewProduct
            // 
            this.BtnCreateNewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCreateNewProduct.Location = new System.Drawing.Point(3, 149);
            this.BtnCreateNewProduct.Name = "BtnCreateNewProduct";
            this.BtnCreateNewProduct.Size = new System.Drawing.Size(188, 67);
            this.BtnCreateNewProduct.TabIndex = 0;
            this.BtnCreateNewProduct.Text = "New Product";
            this.BtnCreateNewProduct.UseVisualStyleBackColor = true;
            this.BtnCreateNewProduct.Click += new System.EventHandler(this.BtnCreateNewProduct_Click);
            // 
            // btnAddNewProducer
            // 
            this.btnAddNewProducer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewProducer.Location = new System.Drawing.Point(3, 76);
            this.btnAddNewProducer.Name = "btnAddNewProducer";
            this.btnAddNewProducer.Size = new System.Drawing.Size(188, 67);
            this.btnAddNewProducer.TabIndex = 0;
            this.btnAddNewProducer.Text = "New Producer";
            this.btnAddNewProducer.UseVisualStyleBackColor = true;
            this.btnAddNewProducer.Click += new System.EventHandler(this.btnAddNewProducer_Click);
            // 
            // BtnProducers
            // 
            this.BtnProducers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnProducers.FlatAppearance.BorderSize = 0;
            this.BtnProducers.Location = new System.Drawing.Point(3, 3);
            this.BtnProducers.Name = "BtnProducers";
            this.BtnProducers.Size = new System.Drawing.Size(188, 67);
            this.BtnProducers.TabIndex = 0;
            this.BtnProducers.Text = "Producers";
            this.BtnProducers.UseVisualStyleBackColor = true;
            this.BtnProducers.Click += new System.EventHandler(this.BtnProducers_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(203, 69);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(978, 589);
            this.MainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnTrucks;
        private System.Windows.Forms.Button BtnAddTruck;
        private System.Windows.Forms.Button BtnAllShops;
        private System.Windows.Forms.Button BtnNewShop;
        private System.Windows.Forms.Button BtnAllProducts;
        private System.Windows.Forms.Button BtnCreateNewProduct;
        private System.Windows.Forms.Button btnAddNewProducer;
        private System.Windows.Forms.Button BtnProducers;
        private System.Windows.Forms.Panel MainPanel;
    }
}

