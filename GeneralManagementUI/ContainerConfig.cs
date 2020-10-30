using Autofac;
using DatabaseModule;

namespace GeneralManagementUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<GetAllProducersEF>().As<IGetAllProducers>();

            return builder.Build();
        }
    }
}
