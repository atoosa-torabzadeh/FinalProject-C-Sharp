using ApplicationService.Dtos;
using Model.DomainModels;
using Model.ServiceModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationService.Services
{
    public class ProductApplicationService
    {
        #region -SellectAll()-
        public List<GetProductDto> SellectAll()
        {
            var productServiceModel = new ProductServiceModel();
            var products = productServiceModel.SellectAll();
            var productDtos = new List<GetProductDto>();
            foreach (var item in products)
            {
                var dto = new GetProductDto()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Quantity = item.Quantity,
                };
                productDtos.Add(dto);
            }
            return productDtos;
        }
   
        #endregion
        
       #region -Insert()-
		 public void Insert(PostProductDto postProductDto)
        {
            var product = new Product
            {
                Code = postProductDto.Code,
                Title = postProductDto.Title,
                Quantity = postProductDto.Quantity,
                UnitPrice = postProductDto.UnitPrice,
            };
            var productServiceModel = new ProductServiceModel();
            productServiceModel.Insert(product);
        }
        #endregion

        #region -Update()-
        public void Update(UpdateProductDto updateProductDto)
        {
            var product = new Product
            {
                Code = updateProductDto.Code,
                Title = updateProductDto.Title,
                Quantity = updateProductDto.Quantity,
                UnitPrice = updateProductDto.UnitPrice,
                Id = updateProductDto.Id,
            };
            var productServiceModel = new ProductServiceModel();
            productServiceModel.Update(product);

        } 
        #endregion

    }
}
