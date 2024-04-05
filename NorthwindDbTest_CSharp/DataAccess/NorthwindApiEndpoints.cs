namespace NorthwindDbTest_CSharp.DataAccess
{
    public static class NorthwindApiEndpoints
    {
        private static readonly string _baseUrl = "https://northwind.vercel.app/api";

        /// <summary>
        /// The Northwind API endpoint that returns all products as JSON.
        /// </summary>
        public static readonly string Products = $"{_baseUrl}/products";

        /// <summary>
        /// The Northwind API endpoint that returns all orders as JSON.
        /// </summary>
        public static readonly string Orders = $"{_baseUrl}/orders";

        /// <summary>
        /// The Northwind API endpoint that returns all categories as JSON.
        /// </summary>
        public static readonly string Categories = $"{_baseUrl}/categories";

        /// <summary>
        /// The Northwind API endpoint that returns all suppliers as JSON.
        /// </summary>
        public static readonly string Suppliers = $"{_baseUrl}/suppliers";

        /// <summary>
        /// The Northwind API endpoint that returns all customers as JSON.
        /// </summary>
        public static readonly string Customers = $"{_baseUrl}/customers";
    }
}