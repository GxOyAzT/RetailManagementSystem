using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationModule
{
    public interface IHandler
    {
        public void SetNextHandler(IHandler handler);
        public void Process(RequestData requestData);
    }
}
