namespace NorthwindDbTest_CSharp.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public decimal TotalUnitValue { get; set; }
        public bool IsAvailable { get; set; }
    }
}