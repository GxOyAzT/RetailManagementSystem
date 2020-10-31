using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Autofac;
using GeneralManagementUI;
using GMProcessor;
using Models;

namespace ProductManageUI.UserControllers.Shop
{
    public partial class ShopListUC : UserControl
    {
        List<ShopModel> ShopModels { get; set; }
        ShopModel SelectedModel { get; set; } = null;
        public ShopListUC()
        {
            InitializeComponent();
            LoadShopModels();
            DgvShop.AutoGenerateColumns = false;
            InitializeGgvWithData();
        }

        void LoadShopModels()
        {
            ILoadShopModels loadShopModels;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadShopModels = scope.Resolve<ILoadShopModels>();
            }

            ShopModels = loadShopModels.Load();
        }

        void InitializeGgvWithData()
        {
            DgvShop.DataSource = ShopModels;
        }

        void ResetControllers()
        {
            TxbCity.Text = string.Empty;
            TxbStreet.Text = string.Empty;
        }

        void InitializeChangeControllersWithData(ShopModel model)
        {
            TxbCity.Text = model.City;
            TxbStreet.Text = model.Street;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (SelectedModel == null)
                return;

            SelectedModel.City = TxbCity.Text;
            SelectedModel.Street = TxbStreet.Text;

            IUpdateShopProcessor updateShop;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                updateShop = scope.Resolve<IUpdateShopProcessor>();
            }

            if (!updateShop.Update(SelectedModel))
            {
                MessageBox.Show(updateShop.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully updated.");
            SelectedModel = null;
            ResetControllers();
            LoadShopModels();
            InitializeGgvWithData();
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            if (SelectedModel == null)
                return;

            InitializeChangeControllersWithData(SelectedModel);
        }

        private void DgvShop_MouseClick(object sender, MouseEventArgs e)
        {
            if (DgvShop.CurrentCell.RowIndex < 0)
                return;

            SelectedModel = ShopModels[DgvShop.CurrentCell.RowIndex];

            InitializeChangeControllersWithData(SelectedModel);
        }
    }
}
