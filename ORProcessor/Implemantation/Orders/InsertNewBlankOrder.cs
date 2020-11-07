using DatabaseModule;
using System;
using System.Collections.Generic;
using System.Text;

namespace ORProcessor
{
    public class InsertNewBlankOrder : IInsertNewBlankOrder
    {
        private readonly IGenerateRandomOrderName generateRandomOrderName;
        private readonly IInsertBlankOrder insertBlankOrder;

        public InsertNewBlankOrder(IGenerateRandomOrderName generateRandomOrderName, IInsertBlankOrder insertBlankOrder)
        {
            this.generateRandomOrderName = generateRandomOrderName;
            this.insertBlankOrder = insertBlankOrder;
        }

        public void Insert(Guid shopId)
        {
            insertBlankOrder.Insert(shopId, generateRandomOrderName.Generate());
        }
    }
}
