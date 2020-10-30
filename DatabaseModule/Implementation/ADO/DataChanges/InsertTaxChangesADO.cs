using Models;
using System.Data.SqlClient;

namespace DatabaseModule
{
    public class InsertTaxChangesADO : IInsertTaxChanges
    {
        public void Insert(TaxChangesModel model)
        {
            using (var conn = new SqlConnection(ConnectionStringADO.Conn))
            {
                string command = $"exec sp_InsertRowToTaxChanges '{model.ProductId}', {model.NewTax}";
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
