using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationModule
{
    public class RequestData
    {
        public object Data { get; private set; }
        public List<string> MessageErrors { get; set; }

        public RequestData(object data)
        {
            MessageErrors = new List<string>();
            Data = data;
        }
    }
}
