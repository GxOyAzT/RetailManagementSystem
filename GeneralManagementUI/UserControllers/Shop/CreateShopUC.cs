using System;
using System.Windows.Forms;
using Models;

namespace ProductManageUI.UserControllers.Shop
{
    public partial class CreateShopUC : UserControl
    {
        public CreateShopUC()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //var cityValidator = DataValidationFactory.ValFacAddress.CityNameValCreateInst();

            //if (!cityValidator.IsCityNameCorrect(TxbCity.Text))
            //{
            //    MessageBox.Show("City is in incorrect format");
            //    return;
            //}

            //var streetValidator = DataValidationFactory.ValFacAddress.StreetAddressValcreateInst();

            //if (!streetValidator.IsStreetCorrect(TxbStreet.Text))
            //{
            //    MessageBox.Show("Street is in incorrect format");
            //    return;
            //}

            //ShopModel model = new ShopModel()
            //{
            //    Id = Guid.NewGuid(),
            //    City = TxbCity.Text,
            //    Street = TxbStreet.Text,
            //    StorageCapacity = (int)NudStorageCap.Value
            //};

            //var db = DatabaseConnectionFactory.DbFacShop.InsertNewShopCreateInst();

            //db.Insert(model);

            //MessageBox.Show("Successfully added.");
            //ResetControllers();
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            //ResetControllers();
        }

        void ResetControllers()
        {
            TxbCity.Text = string.Empty;
            TxbStreet.Text = string.Empty;
            NudStorageCap.Value = 0;
        }
    }
}
