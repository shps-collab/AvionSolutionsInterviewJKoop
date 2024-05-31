using NorthwindDbTest_CSharp.Models;
using NorthwindDbTest_CSharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NorthwindDbTest_CSharp.Services
{
    public class ProductInfoViewModelService : IViewModelService<ProductInfoViewModel, Product>
    {
        public ProductInfoViewModelService()
        {

        }

        /// <summary>
        /// Creates a <see cref="ProductInfo"/> from a provided <see cref="Product"/> model.
        /// </summary>
        /// <param name="source">The <see cref="Product"/> model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public ProductInfoViewModel CreateViewModel(Product source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }

            return new ProductInfoViewModel()
            {
                 Id = source.Id,
                 SupplierId = source.SupplierId,
                 CategoryId = source.CategoryId,
                 QuantityPerUnit = source.QuantityPerUnit,
                 UnitPrice = source.UnitPrice,
                 UnitsInStock = source.UnitsInStock,
                 UnitsOnOrder = source.UnitsOnOrder,
                 ReorderLevel = source.ReorderLevel,
                 Discontinued = source.Discontinued,
                 Name = source.Name,
                 Supplier = source.Supplier,
                 Category = source.Category
            };
        }

        /// <summary>
        /// Creates a collection of <see cref="ProductViewModel"/> from a provided collection of <see cref="Product"/> models.
        /// </summary>
        /// <param name="source">The collection of <see cref="Product"/> models.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IEnumerable<ProductInfoViewModel> CreateViewModel(IEnumerable<Product> source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }

            return source.Select(prod => CreateViewModel(prod));
        }
    }
}