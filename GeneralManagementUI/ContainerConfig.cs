﻿using Autofac;
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

            builder.RegisterType<GetProductFullInfoByIdEF>().As<IGetProductFullInfoById>();

            builder.RegisterType<ProducerInsertProcessing>().As<IProducerInsertProcessing>();
            builder.RegisterType<LoadDataForProducerController>().As<ILoadDataForProducerController>();
            builder.RegisterType<FilterProducerViewModels>().As<IFilterProducerViewModels>();
            builder.RegisterType<UpdateProducerCollection>().As<IUpdateProducerCollection>();
            builder.RegisterType<ConvertProducerListVmToM>().As<IConvertProducerListVmToM>();

            builder.RegisterType<LoadProducersForComboBox>().As<ILoadProducersForComboBox>();

            builder.RegisterType<InsertProductProcessor>().As<IInsertProductProcessor>();

            builder.RegisterType<LoadProductDataForProductListUC>().As<ILoadProductDataForProductListUC>();

            builder.RegisterType<FilterProductsForProductListUC>().As<IFilterProductsForProductListUC>();

            builder.RegisterType<LoadModelForUpdateProductUC>().As<ILoadModelForUpdateProductUC>();

            builder.RegisterType<UpdateProductBasic>().As<IUpdateProductBasic>();

            builder.RegisterType<UpdateProductDataEF>().As<IUpdateProductData>();

            builder.RegisterType<UpdateProductPrice>().As<IUpdateProductPrice>();

            builder.RegisterType<UpdateProductStorage>().As<IUpdateProductStorage>();

            builder.RegisterType<UpdateProductAvaliability>().As<IUpdateProductAvaliability>();

            builder.RegisterType<InsertShopProcessor>().As<IInsertShopProcessor>();

            builder.RegisterType<InsertNewShopEF>().As<IInsertNewShop>();

            builder.RegisterType<ValidateCity>().As<IValidateCity>();

            builder.RegisterType<ValidateAddressStreet>().As<IValidateAddressStreet>();

            builder.RegisterType<GetAllShopsEF>().As<IGetAllShops>();

            builder.RegisterType<LoadShopModels>().As<ILoadShopModels>();

            builder.RegisterType<UpdateShopProcessor>().As<IUpdateShopProcessor>();

            builder.RegisterType<UpdateShopEF>().As<IUpdateShop>();

            builder.RegisterType<InsertTruckEF>().As<IInsertTruck>();

            builder.RegisterType<ValidateTruckName>().As<IValidateTruckName>();

            builder.RegisterType<ValidateTruckNameUniqueness>().As<IValidateTruckNameUniqueness>();

            builder.RegisterType<InsertTruckProcessor>().As<IInsertTruckProcessor>();

            builder.RegisterType<GetAllTrucksEF>().As<IGetAllTrucks>();

            builder.RegisterType<LoadTrucks>().As<ILoadTrucks>();

            builder.RegisterType<UpdateTruckListEF>().As<IUpdateTruckList>();

            builder.RegisterType<UpdateTruckListProcessor>().As<IUpdateTruckListProcessor>();

            builder.RegisterType<UpdateTruckEF>().As<IUpdateTruck>();

            builder.RegisterType<GenerateToken>().As<IGenerateToken>();

            builder.RegisterType<InsertTokenProcess>().As<IInsertTokenProcess>();

            builder.RegisterType<RegistrationProcess>().As<IRegistrationProcess>();

            builder.RegisterType<InsertTokenEF>().As<IInsertToken>();

            return builder.Build();
        }
    }
}
