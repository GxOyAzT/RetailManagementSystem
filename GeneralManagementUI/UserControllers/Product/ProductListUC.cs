using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using GeneralManagementUI;
using GMProcessor;
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
            LoadModelsForDataGridView();
            FilteredModels.AddRange(Models);
            PopulateDataGridViewWithData();
            MainPanel = mainPanel;
        }

        #region Buttons Methods
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            IFilterProductsForProductListUC filterProductsForProductListUC;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                filterProductsForProductListUC = scope.Resolve<IFilterProductsForProductListUC>();
            }

            FilteredModels = filterProductsForProductListUC.Filter(Models, TxbNameBarecode.Text, TxbCompanyName.Text, CkbIsAvaliableAtProducer.Checked, CkbIsInSale.Checked);

            PopulateDataGridViewWithData();
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            FilteredModels = Models.ToList();
            PopulateDataGridViewWithData();
        }

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (DgvProducts.CurrentCell.RowIndex < 0)
            {
                MessageBox.Show("Select product first");
                return;
            }

            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new UpdateProductUC(FilteredModels[DgvProducts.CurrentCell.RowIndex].Id));
        }
        #endregion

        #region UI Methods
        public void PopulateDataGridViewWithData()
        {
            DgvProducts.DataSource = FilteredModels;
        }

        public void LoadModelsForDataGridView()
        {
            ILoadProductDataForProductListUC loadProductDataForProductListUC;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadProductDataForProductListUC = scope.Resolve<ILoadProductDataForProductListUC>();
            }

            Models = loadProductDataForProductListUC.Load();
        }

        #endregion
    }
}
