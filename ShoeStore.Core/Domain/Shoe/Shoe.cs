using System;
using System.Collections.Generic;
using System.Text;

namespace ShoeStore.Core.Domain
{
    public class Shoe
    {
        public int ShoeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUri { get; set; }
        public decimal Size { get; set; }
        public int WidthId { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public PersonGroup PersonGroup { get; set; }
    
    }
}
