using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        private readonly string categoryId;

        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1,ProductName="bardak",UnitPrice=15,UnitInStock=15},
                new Product{ProductId=1,ProductName="kamera",UnitPrice=500,UnitInStock=3},
                new Product{ProductId=1,ProductName="telefon",UnitPrice=1500,UnitInStock=2},
                new Product{ProductId=1,ProductName="klavye",UnitPrice=150,UnitInStock=65},
                new Product{ProductId=1,ProductName="fare",UnitPrice=85,UnitInStock=1}

            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }



        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //gönderdiğin ürün ıd'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock = product.UnitInStock;
        }
        public List<Product> GetAllByCategory(int CategoryId)
        {
            return _products.Where(p => p.CategoryId ==categoryId)
                .ToList();
        }
    }
}

    


