using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            InitializeGgvWithData();
            DgvShop.AutoGenerateColumns = false;
        }

        void LoadShopModels()
        {
            //var db = DatabaseConnectionFactory.DbFacShop.GetShopsCreateInst();

            //ShopModels = db.Get();
        }

        void InitializeGgvWithData()
        {
            DgvShop.DataSource = ShopModels;
        }

        void ResetControllers()
        {
            TxbCity.Text = string.Empty;
            TxbStreet.Text = string.Empty;
            NudStorageCapacity.Value = 0;
        }

        void InitializeChangeControllersWithData(ShopModel model)
        {
            TxbCity.Text = model.City;
            TxbStreet.Text = model.Street;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //if (SelectedModel == null)
            //    return;

            //var validator = DataValidationFactory.ValFacShop.FullShopValCreateInst();

            //if (!validator.Validate(TxbCity.Text, TxbStreet.Text))
            //{
            //    MessageBox.Show("Data is in incorrect format");
            //    return;
            //}

            //SelectedModel.City = TxbCity.Text;
            //SelectedModel.Street = TxbStreet.Text;
            //SelectedModel.StorageCapacity = (int)NudStorageCapacity.Value;

            //var db = DatabaseConnectionFactory.DbFacShop.UpdateShopCreateInst();

            //db.Update(SelectedModel);

            //MessageBox.Show("Successfully updated.");
            //SelectedModel = null;
            //ResetControllers();
            //LoadShopModels();
            //InitializeGgvWithData();
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            //if (SelectedModel == null)
            //    return;

            //InitializeChangeControllersWithData(SelectedModel);
        }

        private void DgvShop_MouseClick(object sender, MouseEventArgs e)
        {
            //if (DgvShop.CurrentCell.RowIndex < 0)
            //    return;

            //SelectedModel = ShopModels[DgvShop.CurrentCell.RowIndex];

            //InitializeChangeControllersWithData(SelectedModel);
        }
    }
}
