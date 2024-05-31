using Microsoft.AspNetCore.Mvc;
using NorthwindDbTest_CSharp.DataAccess;
using NorthwindDbTest_CSharp.Models;
using NorthwindDbTest_CSharp.Services;
using NorthwindDbTest_CSharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NorthwindDbTest_CSharp
{
    public partial class Details : System.Web.UI.Page
    {
        int currentId = 0;
        Supplier supplier;
        Category category;

        protected void Page_Load(object sender, EventArgs e)
        {

            // Obtain a reference to the Request.Params
            // collection.
            NameValueCollection pColl = Request.Params;

            int id = 0;
            try
            {
                id = Int32.Parse(pColl.GetValues(0)[0]);
            }
            catch
            {
                id = 0;
            }
            if (!Page.IsPostBack)
            {   
                LoadProductDetails(id);
                LoadOrders(id);
                if(supplier != null)
                {
                    LoadSupplier(supplier);
                    supplierLabel.Text = "Supplier info for this product";
                }
                else
                {
                    LoadSupplier(new Supplier());
                    supplierLabel.Text = "Supplier info not found";

                }
                if (category != null)
                {
                    LoadCategory(category);
                    categoryLabel.Text = "Category info for this product";
                }
                else
                {
                    LoadCategory(new Category());
                    categoryLabel.Text = "Category info not found";
                }
            }
            // Set a Label's Text property to the values
            // contained in the string variable.
            //paramVal.Text = pColl.GetKey(0) + "\t\t" + id;

        }

        /// <summary>
        /// Load all Products into the grid.
        /// </summary>
        private void LoadProductDetails(int id)
        {
            using (ProductsRepository productRepo = new ProductsRepository())
            {
                ProductInfoViewModelService productInfoViewModelService = new ProductInfoViewModelService();
                Product product = productRepo.GetById(id);
                List<Product> productList = new List<Product> { product };
                if (productList != null)
                {
                    supplier = product.Supplier;
                    category = product.Category;
                    gvProductInfo.DataSource = productInfoViewModelService.CreateViewModel(productList);
                    paramVal.Text = product.Name;
                    gvProductInfo.DataBind();
                    paramVal.Text = product.Name;
                }
            }            
        }

        private void LoadSupplier(Supplier supplier)
        {
            using (ProductsRepository productRepo = new ProductsRepository())
            {
                SupplierViewModelService supplierViewModelService = new SupplierViewModelService();
                List<Supplier> supplierList = new List<Supplier> { supplier };
                gvSupplier.DataSource = supplierViewModelService.CreateViewModel(supplierList);
                gvSupplier.DataBind();                
            }
        }

        private void LoadCategory(Category category)
        {
            using (ProductsRepository productRepo = new ProductsRepository())
            {
                CategoryViewModelService categoryViewModelService = new CategoryViewModelService();
                List<Category> categoryList = new List<Category> { category };
                gvCategory.DataSource = categoryViewModelService.CreateViewModel(categoryList);
                gvCategory.DataBind();
            }
        }

        private void LoadOrders(int id)
        {
            using (OrdersRepository ordersRepo = new OrdersRepository())
            {
                OrderViewModelService orderViewModelService = new OrderViewModelService();
                IEnumerable<Order> orders = ordersRepo
                    .GetAll()
                        .Where(x => x.Details
                            .Any(current => current.productId == id))
                        .OrderBy(current => current.Id);
                if (orders != null)
                {
                    gvProductOrders.DataSource = orderViewModelService.CreateViewModel(orders);
                    gvProductOrders.DataBind();
                }
            }
        }
    }
}