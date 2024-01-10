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
    public static class OrderDetailDtoMapper 
    {
        public static OrderDetailResponseDto MapToDto(OrderDetail entity)
        {
            return new OrderDetailResponseDto
            {
                OrderId = entity.OrderId,
                Id = entity.Id,
                ProductId = entity.ProductId,
                Quantity = entity.Quantity,
                UnitPrice = entity.UnitPrice
            };
        }

        public static OrderDetail MapToEntity(OrderDetailRequestDto dto)
        {
            return new OrderDetail
            {
                OrderId = dto.OrderId,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice
            };
        }

        public static OrderDetail MapUpdateOrderDetailRequestDtoToEntity(UpdateOrderDetailRequestDto dto)
        {
            if (dto == null)
                return null;

            return new OrderDetail()
            {
                Id = dto.Id,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice,
                OrderId = dto.OrderId
            };
        }
    }
}
