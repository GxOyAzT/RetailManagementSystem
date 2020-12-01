using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using ValidationModule;
using Xunit;

namespace XTests
{
    public class ValidateTrucks1
    {
        [Fact]
        public void ValidateTruckv1_validateName_A()
        {
            IValidateTruckName validateTruckName = new ValidateTruckName();

            TruckModel truck = new TruckModel()
            {
                Name = "A0001"
            };

            Assert.True(validateTruckName.Validate(truck.Name));
        }
        
        [Fact]
        public void ValidateTruckv1_validateName_B()
        {
            IValidateTruckName validateTruckName = new ValidateTruckName();

            TruckModel truck = new TruckModel()
            {
                Name = "LRA556"
            };

            Assert.False(validateTruckName.Validate(truck.Name));
        }

        [Fact]
        public void ValidateTruckv1_validateName_C()
        {
            IValidateTruckName validateTruckName = new ValidateTruckName();

            TruckModel truck = new TruckModel()
            {
                Name = "LRA.6"
            };

            Assert.False(validateTruckName.Validate(truck.Name));
        }

        [Fact]
        public void ValidateTruckv1_validateNameUq_A()
        {
            IValidateTruckNameUniqueness validateTruckNameUniqueness = new ValidateTruckNameUniqueness(new AAGetAllTrucksTests());

            TruckModel truck = new TruckModel()
            {
                Name = "A0001"
            };

            Assert.True(validateTruckNameUniqueness.IsUnique(truck.Name));
        }

        [Fact]
        public void ValidateTruckv1_validateNameUq_B()
        {
            IValidateTruckNameUniqueness validateTruckNameUniqueness = new ValidateTruckNameUniqueness(new AAGetAllTrucksTests());

            TruckModel truck = new TruckModel()
            {
                Name = "AAAAA"
            };

            Assert.False(validateTruckNameUniqueness.IsUnique(truck.Name));
        }

        
    }
}
