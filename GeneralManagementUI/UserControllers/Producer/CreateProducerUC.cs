using System;
using System.Windows.Forms;
using Autofac;
using GeneralManagementUI;
using GMProcessor;
using Models;

namespace ProductManageUI.UserControllers
{
    public partial class CreateProducerUC : UserControl
    {
        public CreateProducerUC()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var newModel = new ProducerModel()
            {
                Id = Guid.NewGuid(),
                CompanyName = TxbCompanyName.Text,
                Country = TxbCountry.Text,
                City = TbxCity.Text,
                Street = TxbStreet.Text
            };

            IProducerInsertProcessing producerInsertProcessing;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                producerInsertProcessing = scope.Resolve<IProducerInsertProcessing>();
            }

            if (!producerInsertProcessing.ProcessInsertion(newModel))
            {
                MessageBox.Show(producerInsertProcessing.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully added.");
            ResetInputControllers();
        }

        private void ResetInputControllers()
        {
            TxbCompanyName.Text = string.Empty;
            TxbCountry.Text = string.Empty;
            TbxCity.Text = string.Empty;
            TxbStreet.Text = string.Empty;
        }
    }
}
