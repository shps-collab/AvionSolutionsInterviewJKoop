using NorthwindDbTest_CSharp.Models;
using NorthwindDbTest_CSharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace NorthwindDbTest_CSharp.Services
{
    public class CategoryViewModelService : IViewModelService<CategoryViewModel, Category>
    {
        public CategoryViewModelService()
        {

        }

        /// <summary>
        /// Creates a <see cref="CategoryViewModelService"/> from a provided <see cref="Category"/> model.
        /// </summary>
        /// <param name="source">The <see cref="Category"/> model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public CategoryViewModel CreateViewModel(Category source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }
            try
            {
                return new CategoryViewModel()
                {
                    Id = Convert.ToString(source.Id),
                    Description = source.Description,
                    Name = source.Name,
                };
            }
            catch (Exception ex)
            {
                return new CategoryViewModel()
                {
                    Id = "See Product for Category Id",
                    Description = "Not Found",
                    Name = "Not Found",
                };
            }
        }

        /// <summary>
        /// Creates a collection of <see cref="SupplierViewModel"/> from a provided collection of <see cref="Category"/> models.
        /// </summary>
        /// <param name="source">The collection of <see cref="Category"/> models.</param>
        /// <returns></returns>
        /// <exception cref="SupplierViewModel"></exception>
        public IEnumerable<CategoryViewModel> CreateViewModel(IEnumerable<Category> source)
        {
            if (source == null) { throw new ArgumentNullException(nameof(source)); }

            return source.Select(category => CreateViewModel(category));
        }
    }
}