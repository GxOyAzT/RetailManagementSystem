using Autofac;
using ORProcessor;
using DatabaseModule;

namespace OrdersRegisterWeb
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GetInformationByToken>().As<IGetInformationByToken>();

            builder.RegisterType<GetTokenModelByToken>().As<IGetTokenModelByToken>();

            builder.RegisterType<GetActiveShops>().As<IGetActiveShops>();

            builder.RegisterType<GetAllShopsEF>().As<IGetAllShops>();

            builder.RegisterType<GetShopWhereId>().As<IGetShopWhereId>();

            builder.RegisterType<GetAllOrdersEF>().As<IGetAllOrders>();

            builder.RegisterType<GetAllOrdersProcess>().As<IGetAllOrdersProcess>();

            builder.RegisterType<GetOrderDetailsVM>().As<IGetOrderedDetailsVM>();

            builder.RegisterType<GetOrderProductWhereOrderIdEF>().As<IGetOrderProductWhereOrderId>();

            builder.RegisterType<UpdateOrderAsConfByIdEF>().As<IUpdateOrderAsConfById>();

            builder.RegisterType<SetOrderStatusAsConfirmed>().As<ISetOrderStatusAsConfirmed>();

            builder.RegisterType<GetAllProductsEF>().As<IGetAllProducts>();

            builder.RegisterType<LoadDataToManageOrderProd>().As<ILoadDataToManageOrderProd>();

            builder.RegisterType<RemoveOrderProdAndInsertNewEF>().As<IRemoveOrderProdAndInsertNew>();

            builder.RegisterType<ProcessManageOrderProducts>().As<IProcessManageOrderProducts>();

            builder.RegisterType<GetAllSupplyWhereShopIdAndNotConfEF>().As<IGetAllSupplyWhereShopIdAndNotConf>();

            return builder.Build();
        }
    }
}
