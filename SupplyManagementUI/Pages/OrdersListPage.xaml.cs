using Autofac;
using Models;
using SMProcessor;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class OrdersListPage : Page
    {
        private List<OrderModel> OrderModels { get; set; }
        private List<OrderProductsVM> OrderProductVMs { get; set; }
        private Frame MainFrame { get; }

        public OrdersListPage(Frame mainFrame)
        {
            InitializeComponent();
            LoadOrderModels();
            InitializeLbOrders();
            MainFrame = mainFrame;
        }

        #region ListBoxesLoadDataAndInitialize
        private void LoadOrderModels()
        {
            ILoadConfirmedOrders loadConfirmedOrders;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadConfirmedOrders = scope.Resolve<ILoadConfirmedOrders>();
            }

            OrderModels = loadConfirmedOrders.Load().Where(e => !e.IsSupplyConfirmed).ToList();
        }

        private void LoadOrderProductModels()
        {
            if (LbOrders.SelectedIndex < 0)
            {
                MessageBox.Show("Select order first.");
                return;
            }

            ILoadOrderProductsWhereOrderId loadOrderProductsWhereOrderId;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadOrderProductsWhereOrderId = scope.Resolve<ILoadOrderProductsWhereOrderId>();
            }

            OrderProductVMs = loadOrderProductsWhereOrderId.Load(OrderModels[LbOrders.SelectedIndex].Id);
        }

        private void InitializeLbOrders()
        {
            if (OrderModels == null)
                return;

            LbOrders.ItemsSource = OrderModels;
        }

        private void InitializeLbProducts()
        {
            if (OrderProductVMs == null)
                return;
            
            LbProducts.ItemsSource = OrderProductVMs;
        }
        #endregion

         #region EventsHandling
        private void Click_LbOrders(object sender, MouseButtonEventArgs e)
        {
            LoadOrderProductModels();
            InitializeLbProducts();
        }
        
        private void Click_ManageOrder(object sender, RoutedEventArgs e)
        {
            if (LbOrders.SelectedIndex < 0)
            {
                MessageBox.Show("Select order first.");
                return;
            }

            MainFrame.Content = new ManageSupplyPage(OrderModels[LbOrders.SelectedIndex].Id);
        }
        #endregion
    }
}