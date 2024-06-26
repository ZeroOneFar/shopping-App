﻿using System.Collections.Generic;

namespace ACM.BL
{
    public class Product : EntityBase
    {
        public int ProductId { get; private set;}
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }
        public Product()
        {
            
        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public override string ToString() => ProductName;

        public override bool Validate()
        {
            var isValid = !(string.IsNullOrWhiteSpace(ProductName) || ProductId == 0);
            return isValid;
        }
    }
}