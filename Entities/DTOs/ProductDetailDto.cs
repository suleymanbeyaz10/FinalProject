using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Entities.DTOs
{
    public class ProductDetailDto : IDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CateogoryName { get; set; }
        public short UnitsInstock { get; set; }

    }
}
