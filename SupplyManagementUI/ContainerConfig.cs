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

            builder.RegisterType<GetAllSupplyNamesWhereNotConfirmedEF>().As<IGetAllSupplyNamesWhereNotConfirmed>();

            builder.RegisterType<ReturnUqSupplyName>().As<IReturnUqSupplyName>();

            builder.RegisterType<GenerateSupplyUqName>().As<IGenerateSupplyUqName>();

            builder.RegisterType<CreateSupplyModelInstance>().As<ICreateSupplyModelInstance>();

            builder.RegisterType<GetTruckWhereIdEF>().As<IGetTruckWhereId>();

            builder.RegisterType<GetOrderWhereIdEF>().As<IGetOrderWhereId>();

            builder.RegisterType<ConvertOrderProductListToSupplyProductList>().As<IConvertOrderProductListToSupplyProductList>();

            builder.RegisterType<InsertSupplyEF>().As<IInsertSupply>();

            builder.RegisterType<InsertSupplyProductListEF>().As<IInsertSupplyProductList>();

            builder.RegisterType<InsertSupplyProcess>().As<IInsertSupplyProcess>();

            builder.RegisterType<UpdateOrderSupplyAsConfirmedEF>().As<IUpdateOrderSupplyAsConfirmed>();

            return builder.Build();
        }
    }
}
