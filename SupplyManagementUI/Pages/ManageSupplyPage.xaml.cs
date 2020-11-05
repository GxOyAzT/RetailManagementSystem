using Models;
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
    public partial class ManageSupplyPage : Page
    {
        private readonly Guid orderId;
        private EnumManageSupplyStep Step { get; set; }

        private ManageSupplyProductsPage ManageSupplyProductsPage { get; set; }
        private ManageSupplyTruckDate ManageSupplyTruckDate { get; set; }
        private ManageSupplySummaryPage ManageSupplySummaryPage { get; set; }

        public ManageSupplyPage(Guid orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            SetStep(EnumManageSupplyStep.Products);
            SupplyMainFrame.Content = ManageSupplyProductsPage = new ManageSupplyProductsPage(orderId);
        }

        private void SetStep(EnumManageSupplyStep step)
        {
            if (step == EnumManageSupplyStep.Products)
            {
                Step = EnumManageSupplyStep.Products;
                BtPrevStep.Visibility = Visibility.Hidden;
            }

            if (step == EnumManageSupplyStep.Details)
            {
                Step = EnumManageSupplyStep.Details;
                BtPrevStep.Visibility = Visibility.Visible;
                BtNextStep.Visibility = Visibility.Visible;
            }

            if (step == EnumManageSupplyStep.Summary)
            {
                Step = EnumManageSupplyStep.Summary;
                BtNextStep.Visibility = Visibility.Hidden;
            }
        }

        #region EventsHandling
        private void Click_PrevStep(object sender, RoutedEventArgs e)
        {
            if (Step == EnumManageSupplyStep.Products)
                return;

            if (Step == EnumManageSupplyStep.Details)
            {
                SupplyMainFrame.Content = ManageSupplyProductsPage;
                SetStep(EnumManageSupplyStep.Products);
            }

            if (Step == EnumManageSupplyStep.Summary)
            {
                SupplyMainFrame.Content = ManageSupplyTruckDate;
                SetStep(EnumManageSupplyStep.Details);
            }
        }

        private void Click_NextvStep(object sender, RoutedEventArgs e)
        {
            if (Step == EnumManageSupplyStep.Products)
            {
                if (ManageSupplyProductsPage.OrderProductVMs.Sum(e => e.AcceptedQuantity) < 1)
                {
                    MessageBox.Show("Supply list cannot be empty.");
                    return;
                }

                SupplyMainFrame.Content = ManageSupplyTruckDate = new ManageSupplyTruckDate(ManageSupplyProductsPage.OrderProductVMs.Sum(e => e.AcceptedQuantity * e.ProductBasicsModel.ProductStorageModel.QuantityInBox * e.ProductBasicsModel.ProductStorageModel.ProductWeight));

                SetStep(EnumManageSupplyStep.Details);
            }

            if (Step == EnumManageSupplyStep.Details)
            {
                if (ManageSupplyTruckDate.SelectedTruck == null || ManageSupplyTruckDate.SelectedDeliveryDate == null)
                {
                    MessageBox.Show("You have to choose truck and date of delivery first.");
                    return;
                }

                SupplyMainFrame.Content = ManageSupplySummaryPage = new ManageSupplySummaryPage();

                SetStep(EnumManageSupplyStep.Summary);
            }
        }
        #endregion
    }
}
