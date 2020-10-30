using System;
using System.Collections.Generic;

namespace DatabaseModule
{
    public interface IGetAllShopsIds
    {
        public List<Guid> Get();
    }
}
