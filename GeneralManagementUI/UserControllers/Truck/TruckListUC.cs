using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Autofac;
using GMProcessor;
using Models;

namespace GeneralManagementUI.UserControllers.Truck
{
    public partial class TruckListUC : UserControl
    {
        List<TruckModel> TruckModels { get; set; }
        List<TruckModel> SortedModels { get; set; }
        public TruckListUC()
        {
            InitializeComponent();
            DgvTruck.AutoGenerateColumns = false;

            LoadModelsFromDatabase();
            PopulateDataGridViewWithData();
        }

        void LoadModelsFromDatabase()
        {
            ILoadTrucks loadTrucks;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadTrucks = scope.Resolve<ILoadTrucks>();
            }

            TruckModels = loadTrucks.Load();

            SortedModels = TruckModels.ToList();
        }

        void PopulateDataGridViewWithData()
        {
            DgvTruck.DataSource = SortedModels;
        }

        private void CbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxFilter.SelectedItem.ToString() == "No Filter")
            {
                SortedModels = TruckModels.ToList();
                PopulateDataGridViewWithData();
                return;
            }

            if (CbxFilter.SelectedItem.ToString() == "Name")
            {
                SortedModels = TruckModels.OrderBy(e => e.Name).ToList();
                PopulateDataGridViewWithData();
                return;
            }

            if (CbxFilter.SelectedItem.ToString() == "Max Capacity")
            {
                SortedModels = TruckModels.OrderBy(e => e.MaxCapacity).ToList();
                PopulateDataGridViewWithData();
                return;
            }

            if (CbxFilter.SelectedItem.ToString() == "Is Avaliable")
            {
                SortedModels = TruckModels.OrderBy(e => e.IsAvaliable).ToList();
                PopulateDataGridViewWithData();
                return;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            IUpdateTruckListProcessor updateTruckListProcessor;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                updateTruckListProcessor = scope.Resolve<IUpdateTruckListProcessor>();
            }

            updateTruckListProcessor.Update(SortedModels);

            MessageBox.Show("Successfully updated.");

            LoadModelsFromDatabase();
            PopulateDataGridViewWithData();
        }
    }
}
