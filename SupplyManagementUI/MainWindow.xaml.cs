using SupplyManagementUI.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SupplyManagementUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrameInstance.MainFrame = MainFrame;
        }

        public void SetBlankMainFrame()
        {
            MainFrame.Content = null;
        }

        private void Click_Orders(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new OrdersListPage(this.MainFrame);
        }

        private void Click_Exit(object sender, RoutedEventArgs e)
        {

        }

        private void Click_Minimise(object sender, RoutedEventArgs e)
        {

        }

        private void Click_RestDown(object sender, RoutedEventArgs e)
        {

        }
    }
}
