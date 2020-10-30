using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Models;

namespace DatabaseModule
{
    public class GetFullProductBasicProducerDataADO : IGetFullProductBasicProducerDataADO
    {
        
        public List<FullProductDataModelBasicCompany> GetFullProductModel()
        {
            List<FullProductDataModelBasicCompany> output = new List<FullProductDataModelBasicCompany>();

            using (SqlConnection conn = new SqlConnection(ConnectionStringADO.Conn))
            {
                conn.Open();

                var command = new SqlCommand("select * from view_FullProductDataWithBasicProducer", conn);

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    output.Add(new FullProductDataModelBasicCompany()
                    {
                        Id = (Guid)reader["ProductId"],
                        Name = (string)reader["ProductName"],
                        ShortName = (string)reader["ProductShortName"],
                        Barecode = (string)reader["ProductBarecode"],
                        Price = (decimal)reader["ProductPrice"],
                        Tax = (int)reader["ProductTax"],
                        AvailabilityAtProducer = (bool)reader["ProductIsAvaliableAtProducer"],
                        IsInSale = (bool)reader["ProductIsInSale"],
                        AimInWarehouse = (int)reader["ProductAimInWarehouse"],
                        AimInEachShop = (int)reader["ProductAimInEachShop"],
                        ProductWeight = (int)reader["ProductWeight"],
                        QuantityInBox = (int)reader["ProductQuantityInBox"],
                        ProducerId = (Guid)reader["ProducerId"],
                        CompanyName = (string)reader["ProducerCompanyName"]
                    });
                }

                conn.Close();
            }

            return output;
        }
    }
}
