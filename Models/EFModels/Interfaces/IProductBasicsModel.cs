using System;

namespace Models
{
    public interface IProductBasicsModel
    {
        string Barecode { get; set; }
        string Name { get; set; }
        string ShortName { get; set; }
    }
}