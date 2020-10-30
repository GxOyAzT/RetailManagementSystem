using System;
using System.Windows.Forms;
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
            //var validator = DataValidationFactory.ValFacTruck.TruckValCreateInst();

            //if (!validator.FullValidation(TxbName.Text))
            //{
            //    MessageBox.Show("Truck name is in incorrect format or exists in database.");
            //    return;
            //}

            //TruckModel model = new TruckModel()
            //{
            //    Id = Guid.NewGuid(),
            //    Name = TxbName.Text,
            //    MaxCapacity = (int)NudMaxCapacity.Value,
            //    IsAvaliable = CkbIsAvaliable.Checked
            //};

            //var db = DatabaseConnectionFactory.DbFacTruck.InsertTruckCreateInst();

            //db.Insert(model);

            //MessageBox.Show("Successfully added.");
            //ClearControllers();
        }

        void ClearControllers()
        {
            TxbName.Text = string.Empty;
            NudMaxCapacity.Value = 0;
            CkbIsAvaliable.Checked = false;
        }
    }
}
