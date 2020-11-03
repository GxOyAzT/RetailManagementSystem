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

            return builder.Build();
        }
    }
}
