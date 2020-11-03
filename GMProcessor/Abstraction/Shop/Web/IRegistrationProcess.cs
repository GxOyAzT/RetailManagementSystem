using System;
using System.Threading.Tasks;

namespace GMProcessor
{
    public interface IRegistrationProcess
    {
        bool Register(Guid shopId);
    }
}