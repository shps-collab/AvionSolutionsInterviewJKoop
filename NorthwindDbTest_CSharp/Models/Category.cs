using System;

namespace NorthwindDbTest_CSharp.Models
{
    [Serializable]
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}