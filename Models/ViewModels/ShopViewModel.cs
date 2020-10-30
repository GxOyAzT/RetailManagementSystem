using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ShopViewModel
    {
        public ShopViewModel(ShopModel model)
        {
            _id = model.Id;
            _city = model.City;
            _street = model.Street;
            _storageCapacity = model.StorageCapacity;
            IsModified = false;
        }

        private Guid _id { get; set; }
        private string _city { get; set; }
        private string _street { get; set; }
        private int _storageCapacity { get; set; }

        public Guid Id { get { return Id; } set { _id = value; IsModified = true; } }
        public string City { get { return _city; } set { _city = value; IsModified = true; } }
        public string Street { get { return _street; } set { _street = value; IsModified = true; } }
        public int StorageCapacity { get { return _storageCapacity; } set { _storageCapacity = value; IsModified = true; } }
        public bool IsModified { get; set; } = false;
    }
}
