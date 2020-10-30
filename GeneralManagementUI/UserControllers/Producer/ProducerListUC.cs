using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Models;
using System.Linq;

namespace ProductManageUI.UserControllers.Producer
{
    public partial class ProducerListUC : UserControl
    {
        List<ProducerModel> ProductModels { get; set; }
        List<ProducerViewModel> ProducerViewModels { get; set; } = new List<ProducerViewModel>();

        public ProducerListUC()
        {
            InitializeComponent();

            this.Dock = DockStyle.Fill;

            LoadDataFromDatabase();

            DgvProducers.AutoGenerateColumns = false;

            DgvProducers.DataSource = ProducerViewModels;
        }

        void LoadDataFromDatabase()
        {
            //var db = DatabaseConnectionFactory.DbFacProducer.GetProducersCreateInst();
            //ProductModels = db.GetAllProducers();
            //ResetData();
        }

        void ResetData()
        {
            //var converter = CollectionsManagementFactory.CollFacProducer.ProductViewModelConverterCreateInst();
            //ProducerViewModels = converter.Convert(ProductModels);
            //TxbCountry.Text = string.Empty;
            //TxbCompanyName.Text = string.Empty;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            //if (ProducerViewModels.Where(e => e.WasModified() == true).Count() > 0)
            //{
            //    if (MessageBox.Show($"Are you sure you want to discard all changes?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            //    {
            //        return;
            //    }
            //}
            
            //ResetData();

            //DgvProducers.DataSource = ProducerViewModels;
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            //if (ProducerViewModels.Where(e => e.WasModified() == true).Count() > 0)
            //{
            //    if (MessageBox.Show($"Are you sure you want to discard all changes?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            //    {
            //        return;
            //    }
            //}

            //var filter = CollectionsManagementFactory.CollFacProducer.FilterProducerObjectsCreateInst();

            //var converter = CollectionsManagementFactory.CollFacProducer.ProductViewModelConverterCreateInst();

            //DgvProducers.DataSource = ProducerViewModels = converter.Convert(filter.FilterByNameAndCountry(ProductModels, TxbCompanyName.Text, TxbCountry.Text));
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            //if(ProducerViewModels.Where(e => e.WasModified() == true).Count() < 1)
            //{
            //    MessageBox.Show("No changes applied.");
            //    return;
            //}

            //if (MessageBox.Show($"Are you sure you want to apply changes for {ProducerViewModels.Where(e => e.WasModified() == true ).Count()} object(s)?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            //{
            //    return;
            //}

            //var validation = DataValidationFactory.ValFacProducer.FullProducerListValCreateInst();

            //var converter = CollectionsManagementFactory.CollFacProducer.ProductViewModelConverterCreateInst();

            //if (!validation.AreAllProducersCorrect(converter.Convert(ProducerViewModels.Where(e => e.WasModified() == true).ToList())) == true)
            //{
            //    MessageBox.Show("Input data is in incorrect format.");
            //}

            //var db = DatabaseConnectionFactory.DbFacProducer.UpdateProducerListCreateInst();

            //db.Update(converter.Convert(ProducerViewModels.Where(e => e.WasModified() == true).ToList()));

            //LoadDataFromDatabase();
            //DgvProducers.DataSource = ProducerViewModels;
        }
    }
}
