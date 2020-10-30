using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Models;

namespace ProductManageUI.UserControllers.Product
{
    public partial class ProductListUC : UserControl
    {
        List<FullProductDataModelBasicCompany> Models { get; set; }
        List<FullProductDataModelBasicCompany> FilteredModels { get; set; } = new List<FullProductDataModelBasicCompany>();
        Panel MainPanel { get; }
        public ProductListUC(Panel mainPanel)
        {
            InitializeComponent();
            //LoadModelsForDataGridView();
            //FilteredModels.AddRange(Models);
            //PopulateDataGridViewWithData();
            //MainPanel = mainPanel;
        }

        #region Buttons Methods
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            //var filter = CollectionsManagementFactory.CollFacProduct.FilterProductByNameBarecodeProducerCreateInst();

            //FilteredModels = filter.Filter(Models, TxbNameBarecode.Text, TxbCompanyName.Text, CkbIsAvaliableAtProducer.Checked, CkbIsInSale.Checked);

            //PopulateDataGridViewWithData();
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            //FilteredModels = Models;
            //PopulateDataGridViewWithData();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            //if (DgvProducts.CurrentCell.RowIndex < 0)
            //{
            //    MessageBox.Show("Select product first");
            //    return;
            //}

            //MainPanel.Controls.Clear();
            //MainPanel.Controls.Add(new UpdateProductUC(FilteredModels[DgvProducts.CurrentCell.RowIndex].Id));
        }
        #endregion

        #region UI Methods
        public void PopulateDataGridViewWithData()
        {
            //DgvProducts.DataSource = FilteredModels;
        }

        public void LoadModelsForDataGridView()
        {
            //var db = DatabaseConnectionFactory.DbFacProduct.GetFullProductBasicProducerCrerateInst();

            //Models = db.GetFullProductModel();
        }

        #endregion
    }
}
