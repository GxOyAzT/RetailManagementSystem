using System;
using System.Windows.Forms;
using Autofac;
using GMProcessor;
using Models;

namespace GeneralManagementUI.UserControllers.Truck
{
    public partial class CreateTruckUC : UserControl
    {
        public CreateTruckUC()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            TruckModel model = new TruckModel()
            {
                Id = Guid.NewGuid(),
                Name = TxbName.Text,
                MaxCapacity = (int)NudMaxCapacity.Value,
                IsAvaliable = CkbIsAvaliable.Checked
            };

            IInsertTruckProcessor insertTruckProcessor;

            using (var scope = ContainerConfig.Configure().BeginLifetimeScope())
            {
                insertTruckProcessor = scope.Resolve<IInsertTruckProcessor>();
            }

            if (!insertTruckProcessor.Insert(model))
            {
                MessageBox.Show(insertTruckProcessor.ErrorMessage);
                return;
            }

            MessageBox.Show("Successfully added.");
            ClearControllers();
        }

        void ClearControllers()
        {
            TxbName.Text = string.Empty;
            NudMaxCapacity.Value = 0;
            CkbIsAvaliable.Checked = false;
        }
    }
}
