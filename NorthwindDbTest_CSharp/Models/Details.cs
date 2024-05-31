using System;

namespace NorthwindDbTest_CSharp.Models
{
    [Serializable]
    public class Details
    {
        public int productId { get; set; }

        public int quantity { get; set; }

        public decimal unitPrice { get; set; }

        public decimal discount { get; set; }
    }
}