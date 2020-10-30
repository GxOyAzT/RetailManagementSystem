using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Models;
using System.Linq;
using GMProcessor;
using GeneralManagementUI;
using Autofac;

namespace ProductManageUI.UserControllers.Producer
{
    public partial class ProducerListUC : UserControl
    {
        List<ProducerViewModel> ProducerViewModels { get; set; } = new List<ProducerViewModel>();
        List<ProducerViewModel> ProducerViewModelsFiltered { get; set; } = new List<ProducerViewModel>();

        public ProducerListUC()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            DgvProducers.AutoGenerateColumns = false;
            TxbCountry.Text = string.Empty;
            TxbCompanyName.Text = string.Empty;

            LoadDataFromDatabase();
            DgvProducers.DataSource = ProducerViewModelsFiltered = ProducerViewModels.ToList();
        }

        void LoadDataFromDatabase()
        {
            ILoadDataForProducerController loadDataForProducerController;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadDataForProducerController = scope.Resolve<ILoadDataForProducerController>();
            }

            ProducerViewModels = loadDataForProducerController.Get();
        }

        void ResetData()
        {
            ProducerViewModelsFiltered = ProducerViewModels;
            DgvProducers.DataSource = ProducerViewModelsFiltered;
            TxbCountry.Text = string.Empty;
            TxbCompanyName.Text = string.Empty;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (ProducerViewModels.Where(e => e.WasModified() == true).Count() > 0)
            {
                if (MessageBox.Show($"Are you sure you want to discard all changes?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            ResetData();
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            if (ProducerViewModels.Where(e => e.WasModified() == true).Count() > 0)
            {
                if (MessageBox.Show($"Are you sure you want to discard all changes?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }

            IFilterProducerViewModels filterProducerViewModels;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                filterProducerViewModels = scope.Resolve<IFilterProducerViewModels>();
            }

            ProducerViewModelsFiltered = filterProducerViewModels.Filter(ProducerViewModels, TxbCompanyName.Text, TxbCountry.Text);
            DgvProducers.DataSource = ProducerViewModelsFiltered;
        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            if (ProducerViewModels.Where(e => e.WasModified() == true).Count() < 1)
            {
                MessageBox.Show("No changes applied.");
                return;
            }

            if (MessageBox.Show($"Are you sure you want to apply changes for {ProducerViewModels.Where(e => e.WasModified() == true).Count()} object(s)?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            IConvertProducerListVmToM convertProducerListVmToM;
            IUpdateProducerCollection updateProducerCollection;
            
            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                updateProducerCollection = scope.Resolve<IUpdateProducerCollection>();
                convertProducerListVmToM = scope.Resolve<IConvertProducerListVmToM>();
            }

            if (!updateProducerCollection.Update(
                convertProducerListVmToM.Convert(
                    ProducerViewModelsFiltered.Where(e => e.WasModified() == true).ToList())))
            {
                MessageBox.Show(updateProducerCollection.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully updated.");

            ResetData();
        }
    }
}
