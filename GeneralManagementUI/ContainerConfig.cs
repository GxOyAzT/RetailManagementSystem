using Autofac;
using DatabaseModule;
using GMProcessor;
using ValidationModule;

namespace GeneralManagementUI
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ValidateCompanyName>().As<IValidateCompanyName>();
            builder.RegisterType<ValidateCountry>().As<IValidateCountry>();
            builder.RegisterType<ValidateCity>().As<IValidateCity>();
            builder.RegisterType<ValidateAddressStreet>().As<IValidateAddressStreet>();

            builder.RegisterType<ValidateBasicProductData>().As<IValidateBasicProductData>();
            builder.RegisterType<ValidatePriceData>().As<IValidatePriceData>();

            builder.RegisterType<UpdateProducerEF>().As<IUpdateProducerData>();
            builder.RegisterType<GetAllProducersEF>().As<IGetAllProducers>();
            builder.RegisterType<ValidateFullProducer>().As<IFullProducerValidation>();
            builder.RegisterType<InsertNewProducerEF>().As<IInsertNewProducer>();

            builder.RegisterType<InsertDistinctProductDataEF>().As<IInsertDistinctProductData>();
            builder.RegisterType<InsertFullProductDataEF>().As<IInsertFullProductData>();

            builder.RegisterType<GetFullProductBasicProducerDataADO>().As<IGetFullProductBasicProducerData>();

            builder.RegisterType<ProducerInsertProcessing>().As<IProducerInsertProcessing>();
            builder.RegisterType<LoadDataForProducerController>().As<ILoadDataForProducerController>();
            builder.RegisterType<FilterProducerViewModels>().As<IFilterProducerViewModels>();
            builder.RegisterType<UpdateProducerCollection>().As<IUpdateProducerCollection>();
            builder.RegisterType<ConvertProducerListVmToM>().As<IConvertProducerListVmToM>();

            builder.RegisterType<LoadProducersForComboBox>().As<ILoadProducersForComboBox>();

            builder.RegisterType<InsertProductProcessor>().As<IInsertProductProcessor>();

            builder.RegisterType<LoadProductDataForProductListUC>().As<ILoadProductDataForProductListUC>();

            builder.RegisterType<FilterProductsForProductListUC>().As<IFilterProductsForProductListUC>();


            return builder.Build();
        }
    }
}
