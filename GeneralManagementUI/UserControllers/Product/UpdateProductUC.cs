using System;
using System.Windows.Forms;
using Models;

namespace ProductManageUI.UserControllers.Product
{
    public partial class UpdateProductUC : UserControl
    {
        Guid ProductId { get; }
        FullProductDataEachModels Model { get; set; }
        public UpdateProductUC(Guid productId)
        {
            InitializeComponent();
            ProductId = productId;
            LoadModelData();
            InitializeControllersWithData();
        }

        void LoadModelData()
        {
            //var db = DatabaseConnectionFactory.DbFacProduct.GetFullProductEachModelsCreateInst();

            //Model = db.GetFullProductDataEachModels(ProductId);
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
            //var validator = DataValidationFactory.ValFacProduct.FullBasicValCreateInst();

            //if (!validator.ValidateName(TxbProductName.Text))
            //{
            //    MessageBox.Show("Product Name is in incorrect format.");
            //    return;
            //}

            //if (!validator.ValidateShortName(TxbShortName.Text))
            //{
            //    MessageBox.Show("Product Short Name is in incorrect format.");
            //    return;
            //}

            //Model.ProductBasicsModel.Name = TxbProductName.Text;
            //Model.ProductBasicsModel.ShortName = TxbShortName.Text;

            //var db = DatabaseConnectionFactory.DbFacProduct.UpdateProductCreateInst();

            //db.UpdateBasic(Model.ProductBasicsModel);


        }

        private void BtnUpdatePrice_Click(object sender, EventArgs e)
        {
            //var validator = DataValidationFactory.ValFacProduct.FullPriceValCreateInst();

            //if (!validator.FullValidation(TxbPrice.Text, TxbTax.Text))
            //{
            //    MessageBox.Show("Price or tax are in incorrect format.");
            //    return;
            //}

            //Model.ProductPriceModel.Price = Convert.ToDecimal(TxbPrice.Text);
            //Model.ProductPriceModel.Tax = Convert.ToInt32(TxbTax.Text);

            //var db = DatabaseConnectionFactory.DbFacProduct.UpdateProductCreateInst();

            //db.UpdatePrice(Model.ProductPriceModel);
        }

        private void BtnUpdateStorage_Click(object sender, EventArgs e)
        {
            //Model.ProductStorageModel.AimInWarehouse = (int)NudAimInWarehouse.Value;
            //Model.ProductStorageModel.AimInEachShop = (int)NudInEachShop.Value;

            //var db = DatabaseConnectionFactory.DbFacProduct.UpdateProductCreateInst();

            //db.UpdateStorage(Model.ProductStorageModel);
        }

        private void BtnUpdateAvaliability_Click_1(object sender, EventArgs e)
        {
            //Model.ProductAvaliabilityModel.AvailabilityAtProducer = CkbIsAvaliableAtProducer.Checked;
            //Model.ProductAvaliabilityModel.IsInSale = CkbIsInSale.Checked;

            //var db = DatabaseConnectionFactory.DbFacProduct.UpdateProductCreateInst();

            //db.UpdateAvaliability(Model.ProductAvaliabilityModel);
        }
    }
}
