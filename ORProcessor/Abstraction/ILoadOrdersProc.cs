using Models;
using System.Collections.Generic;

namespace ORProcessor
{
    public interface ILoadOrdersProc
    {
        List<OrderModel> Load();
    }
}