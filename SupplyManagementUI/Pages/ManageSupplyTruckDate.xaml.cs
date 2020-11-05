using Autofac;
using Models;
using SMProcessor;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SupplyManagementUI.Pages
{
    public partial class ManageSupplyTruckDate : Page
    {
        private readonly int totalWeight;
        private List<TruckModel> TruckModels { get; set; }
        public TruckModel SelectedTruck { get; private set; }
        private List<DateTime> AvaliableDeliveryDates { get; set; }
        public DateTime? SelectedDeliveryDate { get; private set; }

        public ManageSupplyTruckDate(int totalWeight)
        {
            InitializeComponent();
            this.totalWeight = totalWeight;
            LoadTruckModels();
            InitializeLbTrucks();
        }

        #region LoadAndInitializeData
        private void LoadTruckModels()
        {
            ILoadTrucksWithEnoughSotrage loadTrucksWithEnoughSotrage;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadTrucksWithEnoughSotrage = scope.Resolve<ILoadTrucksWithEnoughSotrage>();
            }

            TruckModels = loadTrucksWithEnoughSotrage.Load(totalWeight);
        }

        private void InitializeLbTrucks()
        {
            LbTrucks.ItemsSource = TruckModels;
        }

        private void LoadAvaliableDeliveryDates()
        {
            if (SelectedTruck == null)
                return;

            ILoadAvaliableDeliveryDateList loadAvaliableDeliveryDateList;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadAvaliableDeliveryDateList = scope.Resolve<ILoadAvaliableDeliveryDateList>();
            }

            AvaliableDeliveryDates = loadAvaliableDeliveryDateList.Load(SelectedTruck.Id);
        }

        private void InitializeLbAvaliableDeliveryDates()
        {
            LbDates.ItemsSource = AvaliableDeliveryDates;
        }

        #endregion

        #region EventsHandling
        private void DoubleClick_LbTrucks(object sender, MouseButtonEventArgs e)
        {
            if (LbTrucks.SelectedIndex < 0)
                return;

            SelectedDeliveryDate = null;

            SelectedTruck = TruckModels[LbTrucks.SelectedIndex];

            LoadAvaliableDeliveryDates();
            InitializeLbAvaliableDeliveryDates();

            TbTruckName.Text = SelectedTruck.Name;
        }

        private void DoubleClick_LbDates(object sender, MouseButtonEventArgs e)
        {
            if (LbDates.SelectedIndex < 0)
                return;

            SelectedDeliveryDate = AvaliableDeliveryDates[LbDates.SelectedIndex];

            TbDate.Text = SelectedDeliveryDate.Value.ToString("dd-MM-yyyy");
        }
        #endregion
    }
}
