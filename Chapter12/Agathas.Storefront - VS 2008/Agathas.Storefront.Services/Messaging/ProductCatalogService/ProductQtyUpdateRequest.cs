﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agathas.Storefront.Services.Messaging.ProductCatalogService
{
    public class ProductQtyUpdateRequest
    {
        public int ProductId { get; set; }
        public int NewQty { get; set; }
    }

}
