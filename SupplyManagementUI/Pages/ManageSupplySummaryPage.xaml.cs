using Autofac;
using DatabaseModule;
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
    public partial class ManageSupplySummaryPage : Page
    {
        private readonly SupplyModel _supplyModel;
        private readonly List<SupplyProductModel> _supplyProductModels;

        private TruckModel TruckModel { get; set; }
        private OrderModel OrderModel { get; set; }

        public ManageSupplySummaryPage(SupplyModel supplyModel, List<SupplyProductModel> supplyProductModels)
        {
            InitializeComponent();

            _supplyModel = supplyModel;
            _supplyProductModels = supplyProductModels;

            InitializeControllers();
        }

        private void InitializeControllers()
        {
            IGetTruckWhereId getTruckWhereId;
            IGetOrderWhereId getOrderWhereId;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                getTruckWhereId = scope.Resolve<IGetTruckWhereId>();
                getOrderWhereId = scope.Resolve<IGetOrderWhereId>();
            }

            TruckModel = getTruckWhereId.Get(_supplyModel.TruckId);
            OrderModel = getOrderWhereId.Get(_supplyModel.OrderId);

            TbSupplyName.Text = $"Supply name: {_supplyModel.SupplyUqName}";
            TbTruckName.Text = $"Truck name: {TruckModel.Name}";
            TbOrderName.Text = $"Order name: {OrderModel.OrderUqName}";
            TbDateOfDelivery.Text = $"Delivery date: {_supplyModel.DateOfDelivery.ToString("dd-MM-yyyy")}";

            LbProducts.ItemsSource = _supplyProductModels;
        }

        #region EventsHandling
        private void Click_Confirm(object sender, RoutedEventArgs e)
        {
            IInsertSupplyProcess insertSupplyProcess;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                insertSupplyProcess = scope.Resolve<IInsertSupplyProcess>();
            }

            insertSupplyProcess.Insert(_supplyModel, _supplyProductModels);

            MessageBox.Show("Supply create successfully.");

            MainFrameInstance.MainFrame.Content = null;
        }
        #endregion
    }
}
