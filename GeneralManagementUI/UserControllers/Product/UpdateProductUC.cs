using System;
using System.Windows.Forms;
using Autofac;
using GeneralManagementUI;
using GMProcessor;
using Models;

namespace ProductManageUI.UserControllers.Product
{
    public partial class UpdateProductUC : UserControl
    {
        FullProductDataEachModels Model { get; set; }

        public UpdateProductUC(Guid productId)
        {
            InitializeComponent();
            LoadModelData(productId);
            InitializeControllersWithData();
        }

        void LoadModelData(Guid productId)
        {
            ILoadModelForUpdateProductUC loadModelForUpdateProductUC;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadModelForUpdateProductUC = scope.Resolve<ILoadModelForUpdateProductUC>();
            }

            Model = loadModelForUpdateProductUC.Load(productId);
        }

        void InitializeControllersWithData()
        {
            TxbId.Text = Model.ProductBasicsModel.Id.ToString();
            TxbProductName.Text = Model.ProductBasicsModel.Name;
            TxbShortName.Text = Model.ProductBasicsModel.ShortName;
            TxbBarecode.Text = Model.ProductBasicsModel.Barecode;
            TxbProducer.Text = Model.ProducerModel.CompanyName;
            TxbPrice.Text = Model.ProductPriceModel.Price.ToString();
            TxbTax.Text = Model.ProductPriceModel.Tax.ToString();
            TxbQantityInBox.Text = Model.ProductStorageModel.QuantityInBox.ToString();
            TxbWeight.Text = Model.ProductStorageModel.ProductWeight.ToString();
            CkbIsAvaliableAtProducer.Checked = Model.ProductAvaliabilityModel.AvailabilityAtProducer;
            CkbIsInSale.Checked = Model.ProductAvaliabilityModel.IsInSale;
            NudAimInWarehouse.Value = Model.ProductStorageModel.AimInWarehouse;
        }

        private void BtnUpdateBasics_Click(object sender, EventArgs e)
        {
            IUpdateProductBasic updateProductBasic;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                updateProductBasic = scope.Resolve<IUpdateProductBasic>();
            }

            Model.ProductBasicsModel.Name = TxbProductName.Text;
            Model.ProductBasicsModel.ShortName = TxbShortName.Text;

            if (!updateProductBasic.Update(Model.ProductBasicsModel))
            {
                MessageBox.Show(updateProductBasic.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully updated.");
        }

        private void BtnUpdatePrice_Click(object sender, EventArgs e)
        {
            IUpdateProductPrice updateProductPrice;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                updateProductPrice = scope.Resolve<IUpdateProductPrice>();
            }

            if (!updateProductPrice.Update(Model.ProductPriceModel, TxbPrice.Text, TxbTax.Text))
            {
                MessageBox.Show(updateProductPrice.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully updated.");
        }

        private void BtnUpdateStorage_Click(object sender, EventArgs e)
        {
            IUpdateProductStorage updateProductStorage;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                updateProductStorage = scope.Resolve<IUpdateProductStorage>();
            }
            
            Model.ProductStorageModel.AimInWarehouse = (int)NudAimInWarehouse.Value;

            updateProductStorage.Update(Model.ProductStorageModel);

            MessageBox.Show("Successfully updated.");
        }

        private void BtnUpdateAvaliability_Click_1(object sender, EventArgs e)
        {
            IUpdateProductAvaliability updateProductAvaliability;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                updateProductAvaliability = scope.Resolve<IUpdateProductAvaliability>();
            }

            updateProductAvaliability.Update(Model.ProductAvaliabilityModel, CkbIsAvaliableAtProducer.Checked, CkbIsInSale.Checked);

            MessageBox.Show("Successfully updated.");
        }
    }
}
