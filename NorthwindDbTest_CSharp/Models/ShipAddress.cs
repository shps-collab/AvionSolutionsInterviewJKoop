using System;

namespace NorthwindDbTest_CSharp.Models
{
    [Serializable]
    public class ShipAddress
    {
        public string street { get; set; }

        public string city { get; set; }

        public string region { get; set; }

        public string postalCode { get; set; }

        public string country { get; set; }   
      
    }
}