using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace NorthwindDbTest_CSharp.Models
{
    [Serializable]
    public class Order
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
        public List<Details> Details { get; set; }
    }
}