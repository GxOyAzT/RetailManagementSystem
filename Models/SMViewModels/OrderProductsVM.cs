using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Models
{
    public class OrderProductsVM : OrderProductModel
    {
        public string BoxPrice { get => $"{ProductBasicsModel.ProductPriceModel.Price} x {ProductBasicsModel.ProductStorageModel.QuantityInBox} = {(ProductBasicsModel.ProductPriceModel.Price * ProductBasicsModel.ProductStorageModel.QuantityInBox)}"; }

        public string OrderQuantity { get => $"{(ProductBasicsModel.ProductPriceModel.Price * ProductBasicsModel.ProductStorageModel.QuantityInBox)} x {Quantity} = {(ProductBasicsModel.ProductPriceModel.Price * ProductBasicsModel.ProductStorageModel.QuantityInBox * Quantity)}"; }

        public string OrderedQuantityString { get => $"Ordered: {Quantity}"; }

        public string AcceptedQuantityString { get => $"Accepted: {AcceptedQuantity}"; }

        public int AcceptedQuantity { get; private set; } = 0;

        public void IncrementAcceptedQuantity()
        {
            if (AcceptedQuantity + 1 > Quantity)
                return;

            AcceptedQuantity++;
        }

        public void DecrementAcceptedQuantity()
        {
            if (AcceptedQuantity - 1 < 0)
                return;

            AcceptedQuantity--;
        }
    }
}
