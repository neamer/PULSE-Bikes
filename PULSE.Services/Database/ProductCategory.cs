using System;
using System.Collections.Generic;

namespace PULSE.Services.Database
{
    public partial class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Discriminator { get; set; }
    }
}
