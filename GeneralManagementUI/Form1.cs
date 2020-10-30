using System.Windows.Forms;
using GeneralManagementUI.UserControllers.Truck;
using Models;
using ProductManageUI.UserControllers;
using ProductManageUI.UserControllers.Producer;
using ProductManageUI.UserControllers.Product;
using ProductManageUI.UserControllers.Shop;

namespace ProductManage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddNewProducer_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateProducerUC());
        }

        private void BtnProducers_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ProducerListUC());
        }

        private void BtnCreateNewProduct_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateProductUC());
        }

        private void BtnAllProducts_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ProductListUC(this.MainPanel));
        }

        private void BtnNewShop_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateShopUC());
        }

        private void BtnAllShops_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new ShopListUC());
        }

        private void BtnAddTruck_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new CreateTruckUC());
        }

        private void BtnTrucks_Click(object sender, System.EventArgs e)
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(new TruckListUC());
        }
    }
}
