using System;

namespace DatabaseModule
{
    public interface IInsertBlankOrder
    {
        void Insert(Guid shopId, string orderUqName);
    }
}