using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationModule;
using Xunit;

namespace XTests.ValidationTests
{
    public class ValidateTrucksv2
    {
        [Fact]
        public void ValidateTruckv1_validateName_A()
        {
            var item = new ValidateTruckNameHandler(new ValidateTruckName());

            IValidateTruckNameHandler validateTruckNameHandler = item;

            TruckModel truck = new TruckModel()
            {
                Name = "A0001"
            };

            RequestData requestData = new RequestData(truck);

            validateTruckNameHandler.Process(requestData);

            Assert.Empty(requestData.MessageErrors);
        }

        [Fact]
        public void ValidateTruckv1_validateName_B()
        {
            var item = new ValidateTruckNameHandler(new ValidateTruckName());

            IValidateTruckNameHandler validateTruckNameHandler = item;

            TruckModel truck = new TruckModel()
            {
                Name = "A0.01"
            };

            RequestData requestData = new RequestData(truck);

            validateTruckNameHandler.Process(requestData);

            Assert.NotEmpty(requestData.MessageErrors);
            Assert.Contains("Truck name is in incorrect format.", requestData.MessageErrors);
        }

        [Fact]
        public void ValidateTruckv1_validateName_C()
        {
            var item = new ValidateTruckNameHandler(new ValidateTruckName());

            IValidateTruckNameHandler validateTruckNameHandler = item;

            TruckModel truck = new TruckModel()
            {
                Name = "A0001A"
            };

            RequestData requestData = new RequestData(truck);

            validateTruckNameHandler.Process(requestData);

            Assert.NotEmpty(requestData.MessageErrors);
            Assert.Contains("Truck name is in incorrect format.", requestData.MessageErrors);
        }

        [Fact]
        public void ValidateTruckv1_validateNameUq_A()
        {
            var item = new ValidateTruckNameUqHandler(new ValidateTruckNameUniqueness(new AAGetAllTrucksTests()));

            IValidateTruckNameUqHandler validateTruckNameUqHandler = item;

            TruckModel truck = new TruckModel()
            {
                Name = "A0001"
            };

            RequestData requestData = new RequestData(truck);

            validateTruckNameUqHandler.Process(requestData);

            Assert.Empty(requestData.MessageErrors);
        }

        [Fact]
        public void ValidateTruckv1_validateNameUq_B()
        {
            var item = new ValidateTruckNameUqHandler(new ValidateTruckNameUniqueness(new AAGetAllTrucksTests()));

            IValidateTruckNameUqHandler validateTruckNameUqHandler = item;

            TruckModel truck = new TruckModel()
            {
                Name = "AAAAA"
            };

            RequestData requestData = new RequestData(truck);

            validateTruckNameUqHandler.Process(requestData);

            Assert.NotEmpty(requestData.MessageErrors);
            Assert.Contains("Truck name already exists in databse.", requestData.MessageErrors);
        }

        [Fact]
        public void ValidateTruckv1_FullValidation_A()
        {
            var item = new ValidateTruckNameHandler(new ValidateTruckName());

            item.SetNextHandler(new ValidateTruckNameUqHandler(new ValidateTruckNameUniqueness(new AAGetAllTrucksTests())));

            IValidateTruckNameHandler validateTruckNameUqHandler = item;

            TruckModel truck = new TruckModel()
            {
                Name = "A0000"
            };

            RequestData requestData = new RequestData(truck);

            validateTruckNameUqHandler.Process(requestData);

            Assert.Empty(requestData.MessageErrors);
        }

        [Fact]
        public void ValidateTruckv1_FullValidation_B()
        {
            var item = new ValidateTruckNameHandler(new ValidateTruckName());

            item.SetNextHandler(new ValidateTruckNameUqHandler(new ValidateTruckNameUniqueness(new AAGetAllTrucksTests())));

            IValidateTruckNameHandler validateTruckNameUqHandler = item;

            TruckModel truck = new TruckModel()
            {
                Name = "AA.AA"
            };

            RequestData requestData = new RequestData(truck);

            validateTruckNameUqHandler.Process(requestData);

            Assert.NotEmpty(requestData.MessageErrors);
            Assert.Contains("Truck name is in incorrect format.", requestData.MessageErrors);
        }
        
    }
}
