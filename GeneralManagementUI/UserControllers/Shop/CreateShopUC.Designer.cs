﻿namespace ProductManageUI.UserControllers.Shop
{
    partial class CreateShopUC
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxbCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbStreet = new System.Windows.Forms.TextBox();
            this.NudStorageCap = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnDiscard = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudStorageCap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(192, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create New Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "City";
            // 
            // TxbCity
            // 
            this.TxbCity.Location = new System.Drawing.Point(42, 73);
            this.TxbCity.Name = "TxbCity";
            this.TxbCity.Size = new System.Drawing.Size(194, 23);
            this.TxbCity.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Street";
            // 
            // TxbStreet
            // 
            this.TxbStreet.Location = new System.Drawing.Point(42, 120);
            this.TxbStreet.Name = "TxbStreet";
            this.TxbStreet.Size = new System.Drawing.Size(194, 23);
            this.TxbStreet.TabIndex = 2;
            // 
            // NudStorageCap
            // 
            this.NudStorageCap.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NudStorageCap.Location = new System.Drawing.Point(42, 167);
            this.NudStorageCap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudStorageCap.Name = "NudStorageCap";
            this.NudStorageCap.Size = new System.Drawing.Size(120, 23);
            this.NudStorageCap.TabIndex = 3;
            this.NudStorageCap.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Storage Capacity";
            // 
            // BtnDiscard
            // 
            this.BtnDiscard.Location = new System.Drawing.Point(260, 207);
            this.BtnDiscard.Name = "BtnDiscard";
            this.BtnDiscard.Size = new System.Drawing.Size(131, 23);
            this.BtnDiscard.TabIndex = 4;
            this.BtnDiscard.Text = "Discard";
            this.BtnDiscard.UseVisualStyleBackColor = true;
            this.BtnDiscard.Click += new System.EventHandler(this.BtnDiscard_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // CreateShopUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnDiscard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NudStorageCap);
            this.Controls.Add(this.TxbStreet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateShopUC";
            this.Size = new System.Drawing.Size(521, 246);
            ((System.ComponentModel.ISupportInitialize)(this.NudStorageCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbStreet;
        private System.Windows.Forms.NumericUpDown NudStorageCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnDiscard;
        private System.Windows.Forms.Button button1;
    }
}