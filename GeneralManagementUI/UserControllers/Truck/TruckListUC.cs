using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            //var db = DatabaseConnectionFactory.DbFacTruck.GetTrucksCreateInst();
            //SortedModels = TruckModels = db.Get();
        }

        void PopulateDataGridViewWithData()
        {
            //DgvTruck.DataSource = SortedModels;
        }

        private void CbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var sorter = CollectionsManagementFactory.CollFacTruck.SortTruckListCreateInst();

            //if (CbxFilter.SelectedItem.ToString() == "No Filter")
            //{
            //    SortedModels = TruckModels;
            //    PopulateDataGridViewWithData();
            //    return;
            //}

            //if (CbxFilter.SelectedItem.ToString() == "Name")
            //{
            //    SortedModels = sorter.SortByName(TruckModels);
            //    PopulateDataGridViewWithData();
            //    return;
            //}

            //if (CbxFilter.SelectedItem.ToString() == "Max Capacity")
            //{
            //    SortedModels = sorter.SortByStorageCapacity(TruckModels);
            //    PopulateDataGridViewWithData();
            //    return;
            //}

            //if (CbxFilter.SelectedItem.ToString() == "Is Avaliable")
            //{
            //    SortedModels = sorter.SortByAvaliability(TruckModels);
            //    PopulateDataGridViewWithData();
            //    return;
            //}
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //var db = DatabaseConnectionFactory.DbFacTruck.UpdateTruckListCreateInst();
            //db.Update(SortedModels);

            //MessageBox.Show("Successfully updated.");

            //LoadModelsFromDatabase();
            //PopulateDataGridViewWithData();
        }
    }
}
