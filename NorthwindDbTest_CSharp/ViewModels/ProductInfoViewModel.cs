using NorthwindDbTest_CSharp.Models;

namespace NorthwindDbTest_CSharp.ViewModels
{
    public class ProductInfoViewModel
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public int CategoryId { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string Name { get; set; }
        public Supplier Supplier { get; set; }
        public Category Category { get; set; }
    }
}