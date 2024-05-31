using NorthwindDbTest_CSharp.Models;
using System.Collections;

namespace NorthwindDbTest_CSharp.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public string OrderDate { get; set; }
        public string RequiredDate { get; set; }
        public string ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public double Freight { get; set; }
        public string ShipName { get; set; }
        public ShipAddress ShipAddress { get; set; }
        public ArrayList Details { get; set; }
    }
}