using Autofac;
using GeneralManagementUI;
using GMProcessor;
using Models;
using System;
using System.Windows.Forms;

namespace ProductManageUI.UserControllers.Shop
{
    public partial class CreateShopUC : UserControl
    {
        public CreateShopUC()
        {
            InitializeComponent();
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            var shopModel = new ShopModel()
            {
                Id = Guid.NewGuid(),
                City = TxbCity.Text,
                Street = TxbStreet.Text
            };

            IInsertShopProcessor insertShopProcessor;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                insertShopProcessor = scope.Resolve<IInsertShopProcessor>();
            }

            if (!insertShopProcessor.Insert(shopModel))
            {
                MessageBox.Show(insertShopProcessor.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully added.");
        }

        private void BtnDiscard_Click(object sender, EventArgs e)
        {
            ResetControllers();
        }

        void ResetControllers()
        {
            TxbCity.Text = string.Empty;
            TxbStreet.Text = string.Empty;
        }
    }
}
