using Autofac;
using DatabaseModule;
using SMProcessor;

namespace SupplyManagementUI
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GetAllOrdersEF>().As<IGetAllOrders>();

            builder.RegisterType<LoadConfirmedOrders>().As<ILoadConfirmedOrders>();

            builder.RegisterType<LoadOrderProductsWhereOrderId>().As<ILoadOrderProductsWhereOrderId>();

            builder.RegisterType<GetOrderProductWhereOrderIdEF>().As<IGetOrderProductWhereOrderId>();

            builder.RegisterType<GetAllTrucksEF>().As<IGetAllTrucks>();

            builder.RegisterType<LoadTrucksWithEnoughSotrage>().As<ILoadTrucksWithEnoughSotrage>();

            builder.RegisterType<GetAllSupplyForNextThirtyDaysEF>().As<IGetAllSupplyForNextThirtyDays>();

            builder.RegisterType<LoadAvaliableDeliveryDateList>().As<ILoadAvaliableDeliveryDateList>();

            return builder.Build();
        }
    }
}
