using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Models;

namespace ProductManageUI.UserControllers.Product
{
    public partial class CreateProductUC : UserControl
    {
        List<ProducerModel> ProducerModels { get; set; }
        public CreateProductUC()
        {
            InitializeComponent();
            LoadProducerModelsToCombobox();
        }

        void ResetAllInputControllers()
        {
            TxbProductName.Text = string.Empty;
            TxbShortName.Text = string.Empty;
            TxbBarecode.Text = string.Empty;
            CbxProducer.SelectedIndex = -1;

            TxbPrice.Text = string.Empty;
            TxbTax.Text = string.Empty;

            NudQuantityWarehouse.Value = 0;
            NudEachShop.Value = 0;
            NudQuoInBox.Value = 1;
            NudWeight.Value = 1;

            CkbIsAvaliableAtProducer.Checked = false;
            CkbIsInSale.Checked = false;
        }

        void LoadProducerModelsToCombobox()
        {
            //var db = DatabaseConnectionFactory.DbFacProducer.GetProducersCreateInst();
            //ProducerModels = db.GetAllProducers();
            //CbxProducer.DataSource = ProducerModels;
            //CbxProducer.DisplayMember = "CompanyName";
            //CbxProducer.SelectedIndex = -1;
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            //if(MessageBox.Show("Are you sure you want to delete all input data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    ResetAllInputControllers();
            //}
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //if (CbxProducer.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Data is in incorrect format.");
            //    return;
            //}

            //var productBasic = new ProductBasicsModel()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = TxbProductName.Text,
            //    ShortName = TxbShortName.Text,
            //    Barecode = TxbBarecode.Text,
            //    ProducerId = ProducerModels[CbxProducer.SelectedIndex].Id
            //};

            //var basicValidator = DataValidationFactory.ValFacProduct.FullBasicModelValCreateInst();

            //if (!basicValidator.FullValidation(productBasic))
            //{
            //    MessageBox.Show("Data is in incorrect format.");
            //    return;
            //}

            //var priceValidator = DataValidationFactory.ValFacProduct.FullPriceValCreateInst();

            //if (!priceValidator.FullValidation(TxbPrice.Text, TxbTax.Text))
            //{
            //    MessageBox.Show("Data is in incorrect format.");
            //    return;
            //}

            //var productPrice = new ProductPriceModel()
            //{
            //    ProductId = productBasic.Id,
            //    Price = Convert.ToDecimal(TxbPrice.Text),
            //    Tax = Convert.ToInt32(TxbTax.Text),
            //};

            //var productStorage = new ProductStorageModel()
            //{
            //    ProductId = productBasic.Id,
            //    AimInWarehouse = Convert.ToInt32(NudQuantityWarehouse.Value),
            //    AimInEachShop = Convert.ToInt32(NudEachShop.Value),
            //    ProductWeight = Convert.ToInt32(NudWeight.Value),
            //    QuantityInBox = Convert.ToInt32(NudQuoInBox.Value)
            //};

            //var productAvaliability = new ProductAvaliabilityModel()
            //{
            //    ProductId = productBasic.Id,
            //    AvailabilityAtProducer = CkbIsAvaliableAtProducer.Checked,
            //    IsInSale = CkbIsInSale.Checked
            //};

            //var fullProductEachModels = new FullProductDataEachModels()
            //{
            //    ProductBasicsModel = productBasic,
            //    ProductPriceModel = productPrice,
            //    ProductStorageModel = productStorage,
            //    ProductAvaliabilityModel = productAvaliability
            //};

            //var lg = DlFacProduct.InsertNewProductCreateInst();

            //lg.ExecuteInsert(fullProductEachModels);

            //MessageBox.Show("Successfully added.");
            //ResetAllInputControllers();
        }
    }
}
