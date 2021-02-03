using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ProductName = "Cup",
                    UnitPrice = 15,
                    UnitsInStock = 15
                },
                new Product
                {
                    ProductID = 2,
                    CategoryID = 2,
                    ProductName = "Camera",
                    UnitPrice = 500,
                    UnitsInStock = 3
                },
                new Product
                {
                    ProductID = 3,
                    CategoryID = 2,
                    ProductName = "Mobile Phone",
                    UnitPrice = 1500,
                    UnitsInStock = 2
                },
                new Product
                {
                    ProductID = 4,
                    CategoryID = 3,
                    ProductName = "Keyboard",
                    UnitPrice = 150,
                    UnitsInStock = 65
                },
                new Product
                {
                    ProductID = 5,
                    CategoryID = 3,
                    ProductName = "Mouse",
                    UnitPrice = 85,
                    UnitsInStock = 1
                }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Languuage Integrated Query
            //Lambda
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryID)
        {
            return _products.Where(p => p.CategoryID == categoryID).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductID = product.ProductID;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}