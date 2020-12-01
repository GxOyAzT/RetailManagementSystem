using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationModule
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;

        public BaseHandler()
        {
            _nextHandler = null;
        }

        public abstract void Process(RequestData request);

        public void SetNextHandler(IHandler handler)
        {
            _nextHandler = handler;
        }
    }
}
