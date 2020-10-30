using System;
using System.Windows.Forms;
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
