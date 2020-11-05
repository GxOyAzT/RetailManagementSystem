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
    public partial class ManageSupplyProductsPage : Page
    {
        private readonly Guid orderId;
        public List<OrderProductsVM> OrderProductVMs { get; private set; }

        public ManageSupplyProductsPage(Guid orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            LoadOrderProductModels();
            InitializeLbProducts();
        }

        #region LoadAndInitializeData
        private void LoadOrderProductModels()
        {
            ILoadOrderProductsWhereOrderId loadOrderProductsWhereOrderId;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                loadOrderProductsWhereOrderId = scope.Resolve<ILoadOrderProductsWhereOrderId>();
            }

            OrderProductVMs = loadOrderProductsWhereOrderId.Load(orderId);
        }

        private void InitializeLbProducts()
        {
            if (OrderProductVMs == null)
                return;

            LbProducts.ItemsSource = OrderProductVMs;
        }
        #endregion

        #region EventsHandling
        private void Click_Decrement(object sender, RoutedEventArgs e)
        {
            if (LbProducts.SelectedIndex < 0)
                return;

            OrderProductVMs[LbProducts.SelectedIndex].DecrementAcceptedQuantity();
            LbProducts.Items.Refresh();
        }

        private void Click_Increment(object sender, RoutedEventArgs e)
        {
            if (LbProducts.SelectedIndex < 0)
                return;

            OrderProductVMs[LbProducts.SelectedIndex].IncrementAcceptedQuantity();
            LbProducts.Items.Refresh();
        }
        #endregion
    }
}
