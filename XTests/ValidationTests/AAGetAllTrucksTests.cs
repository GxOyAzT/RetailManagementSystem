using DatabaseModule;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace XTests
{
    public class AAGetAllTrucksTests : IGetAllTrucks
    {
        public List<TruckModel> Get()
        {
            return new List<TruckModel>()
            {
                new TruckModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "B1023",
                    IsAvaliable = true
                },
                new TruckModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "C0050",
                    IsAvaliable = false
                },
                new TruckModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "D77D8",
                    IsAvaliable = true
                },
                new TruckModel()
                {
                    Id = Guid.NewGuid(),
                    Name = "AAAAA",
                    IsAvaliable = false
                }
            };
        }
    }
}
