namespace ProductManageUI.UserControllers
{
    partial class CreateProducerUC
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
            this.TxbCompanyName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxbCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxbStreet = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new producer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Company Name";
            // 
            // TxbCompanyName
            // 
            this.TxbCompanyName.Location = new System.Drawing.Point(148, 102);
            this.TxbCompanyName.Name = "TxbCompanyName";
            this.TxbCompanyName.Size = new System.Drawing.Size(302, 23);
            this.TxbCompanyName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Country";
            // 
            // TxbCountry
            // 
            this.TxbCountry.Location = new System.Drawing.Point(148, 148);
            this.TxbCountry.Name = "TxbCountry";
            this.TxbCountry.Size = new System.Drawing.Size(302, 23);
            this.TxbCountry.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "City";
            // 
            // TbxCity
            // 
            this.TbxCity.Location = new System.Drawing.Point(148, 195);
            this.TbxCity.Name = "TbxCity";
            this.TbxCity.Size = new System.Drawing.Size(302, 23);
            this.TbxCity.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Street";
            // 
            // TxbStreet
            // 
            this.TxbStreet.Location = new System.Drawing.Point(148, 243);
            this.TxbStreet.Name = "TxbStreet";
            this.TxbStreet.Size = new System.Drawing.Size(302, 23);
            this.TxbStreet.TabIndex = 2;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(234, 272);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(129, 23);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // CreateProducerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxbStreet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxbCountry);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxbCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateProducerUC";
            this.Size = new System.Drawing.Size(616, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxbCompanyName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxbCountry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxbStreet;
        private System.Windows.Forms.Button BtnSave;
    }
}
