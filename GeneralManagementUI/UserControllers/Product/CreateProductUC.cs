using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Autofac;
using GeneralManagementUI;
using GMProcessor;
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
            NudQuoInBox.Value = 1;
            NudWeight.Value = 1;

            CkbIsAvaliableAtProducer.Checked = false;
            CkbIsInSale.Checked = false;
        }

        void LoadProducerModelsToCombobox()
        {
            ILoadProducersForComboBox loadProducersForComboBox;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadProducersForComboBox = scope.Resolve<ILoadProducersForComboBox>();
            }

            ProducerModels = loadProducersForComboBox.Load();
            CbxProducer.DataSource = ProducerModels;
            CbxProducer.DisplayMember = "CompanyName";
            CbxProducer.SelectedIndex = -1;
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete all input data?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ResetAllInputControllers();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CbxProducer.SelectedIndex == -1)
            {
                MessageBox.Show("Select producer from list.");
                return;
            }

            IInsertProductProcessor insertProductProcessor;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                insertProductProcessor = scope.Resolve<IInsertProductProcessor>();
            }

            var productStorage = new ProductStorageModel()
            {
                AimInWarehouse = Convert.ToInt32(NudQuantityWarehouse.Value),
                ProductWeight = Convert.ToInt32(NudWeight.Value),
                QuantityInBox = Convert.ToInt32(NudQuoInBox.Value)
            };

            var productAvaliability = new ProductAvaliabilityModel()
            {
                AvailabilityAtProducer = CkbIsAvaliableAtProducer.Checked,
                IsInSale = CkbIsInSale.Checked
            };

            if (!insertProductProcessor.Insert(TxbProductName.Text, TxbShortName.Text, TxbBarecode.Text, ProducerModels[CbxProducer.SelectedIndex].Id, TxbPrice.Text, TxbTax.Text, productStorage, productAvaliability))
            {
                MessageBox.Show(insertProductProcessor.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully added.");
            ResetAllInputControllers();
        }
    }
}
