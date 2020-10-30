using Models;
using System.Data.SqlClient;

namespace DatabaseModule
{
    public class InsertPriceChangesModelADO : IInsertPriceChangesModel
    {
        public void Insert(PriceChangesModel model)
        {
            using(var conn = new SqlConnection(ConnectionStringADO.Conn))
            {
                string command = $"exec sp_InsertRowToPriceChanges '{model.ProductId}', {model.NewPrice.ToString().Replace(',', '.')}";
                SqlCommand sqlCommand = new SqlCommand(command, conn);
                conn.Open();
                sqlCommand.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
