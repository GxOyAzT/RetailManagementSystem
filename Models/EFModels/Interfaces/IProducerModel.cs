using System;

namespace Models
{
    public interface IProducerModel
    {
        string City { get; set; }
        string CompanyName { get; set; }
        string Country { get; set; }
        string Street { get; set; }
    }
}