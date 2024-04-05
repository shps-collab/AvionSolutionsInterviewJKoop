using System;

namespace NorthwindDbTest_CSharp.Models
{
    [Serializable]
    public class Supplier
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public Address Address { get; set; }
    }
}