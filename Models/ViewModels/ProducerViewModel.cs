using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ProducerViewModel
    {
        public ProducerViewModel(ProducerModel model)
        {
            Id = model.Id;
            CompanyName = model.CompanyName;
            Country = model.Country;
            City = model.City;
            Street = model.Street;
            IsModified = false;
        }

        string _companyName { get; set; }
        string _country { get; set; }
        string _city { get; set; }
        string _street { get; set; }

        public Guid Id { get; }
        public string CompanyName { get { return _companyName; } set { _companyName = value; IsModified = true; } }
        public string Country { get { return _country; } set { _country = value;  IsModified = true; } }
        public string City { get { return _city; } set { _city = value; IsModified = true; } }
        public string Street { get { return _street; } set { _street = value; IsModified = true; } }
        private bool IsModified { get; set; }

        public bool WasModified()
        {
            return IsModified;
        }
    }
}
