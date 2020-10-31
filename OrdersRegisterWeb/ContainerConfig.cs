using Autofac;
using DatabaseModule;
using ORProcessor;

namespace OrdersRegisterWeb
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GetAllOrdersEF>().As<IGetAllOrders>();
            builder.RegisterType<LoadOrdersProc>().As<ILoadOrdersProc>();

            return builder.Build();
        }
    }
}
