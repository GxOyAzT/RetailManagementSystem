using Models;
using System.Collections.Generic;

namespace ORProcessor
{
    public interface ILoadDataToManageOrderProd
    {
        string ErrorMessage { get; set; }

        List<ManageOrderProdVM> Load(string orderId);
    }
}