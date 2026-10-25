using Microsoft.EntityFrameworkCore;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ServiceModels
{
    public class ProductServiceModel
    {
        #region -SellectAll()-
        public List<Product> SellectAll()
        {
            using (var context = new ProjectDbContext())
            {
                return context.Products.ToList();
            }
        }
        #endregion

        #region -Insert()-
        public void Insert(Product product)
        {
            using (var context = new ProjectDbContext())
            {
                context.Products.Add(product);
                context.SaveChanges();

            }

        }
    
    #endregion

        #region - Update()-
		  public void Update(Product product)
        {
            using (var context = new ProjectDbContext())
            {
                var existingProduct = context.Products.FirstOrDefault(p => p.Id == product.Id);
                if (existingProduct != null)
                {
                    existingProduct.UnitPrice = product.UnitPrice;
                    existingProduct.Quantity = product.Quantity;
                    existingProduct.Code = product.Code;
                    context.SaveChanges();
                }
            }

        }
    } 
    #endregion
}