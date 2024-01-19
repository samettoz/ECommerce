using Dto;
using Dto.Request;
using Dto.Response;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public static class ProductDtoMapper 
    {
        public static ProductResponseDto MapToDto(Product product)
        {
            if (product == null)
                return null;

            return new ProductResponseDto
            {
                Id = product.Id,
                BrandId = product.BrandId,
                CategoryId = product.CategoryId,
                ProductName = product.ProductName,
                QuantityPerUnit = product.QuantityPerUnit,
                UnitPrice = product.UnitPrice
            };
        }
        public static Product MapToEntity(ProductRequestDto dto)
        {
            if (dto == null)
                return null;

            return new Product
            {
                BrandId = dto.BrandId,
                CategoryId = dto.CategoryId,
                ProductName = dto.ProductName,
                UnitPrice = dto.UnitPrice,
                QuantityPerUnit = dto.QuantityPerUnit,
                
            };
        }

        public static Product MapUpdateProductRequestDtoToEntity(UpdateProductRequestDto dto)
        {
            if (dto == null)
                return null;

            return new Product
            {
                Id = dto.Id,
                BrandId = dto.BrandId,
                CategoryId= dto.CategoryId,
                ProductName = dto.ProductName,
                UnitPrice = dto.UnitPrice,
                QuantityPerUnit = dto.QuantityPerUnit,
            };
        }
    }
}
