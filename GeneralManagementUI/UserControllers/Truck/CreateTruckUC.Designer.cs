namespace GeneralManagementUI.UserControllers.Truck
{
    partial class CreateTruckUC
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
            this.TxbName = new System.Windows.Forms.TextBox();
            this.NudMaxCapacity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.CkbIsAvaliable = new System.Windows.Forms.CheckBox();
            this.BtnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Truck";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // TxbName
            // 
            this.TxbName.Location = new System.Drawing.Point(34, 84);
            this.TxbName.Name = "TxbName";
            this.TxbName.Size = new System.Drawing.Size(177, 23);
            this.TxbName.TabIndex = 2;
            // 
            // NudMaxCapacity
            // 
            this.NudMaxCapacity.Location = new System.Drawing.Point(34, 131);
            this.NudMaxCapacity.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NudMaxCapacity.Name = "NudMaxCapacity";
            this.NudMaxCapacity.Size = new System.Drawing.Size(120, 23);
            this.NudMaxCapacity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Max Capacity";
            // 
            // CkbIsAvaliable
            // 
            this.CkbIsAvaliable.AutoSize = true;
            this.CkbIsAvaliable.Location = new System.Drawing.Point(34, 169);
            this.CkbIsAvaliable.Name = "CkbIsAvaliable";
            this.CkbIsAvaliable.Size = new System.Drawing.Size(85, 19);
            this.CkbIsAvaliable.TabIndex = 5;
            this.CkbIsAvaliable.Text = "Is Avaliable";
            this.CkbIsAvaliable.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(173, 229);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(116, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CreateTruckUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.CkbIsAvaliable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NudMaxCapacity);
            this.Controls.Add(this.TxbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateTruckUC";
            this.Size = new System.Drawing.Size(476, 282);
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbName;
        private System.Windows.Forms.NumericUpDown NudMaxCapacity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CkbIsAvaliable;
        private System.Windows.Forms.Button BtnSave;
    }
}
