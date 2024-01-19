using Dto.Request;
using Dto.Response;
using Entity;
using Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public static class OrderDtoMapper 
    {
        public static OrderResponseDto MapToDto(Order entity)
        {
            return new OrderResponseDto
            {
                Id = entity.Id,
                CustomerId = entity.CustomerId,
                OrderDate = entity.OrderDate,
                OrderStatus = entity.OrderStatus
            };
        }

        public static Order MapToEntity(OrderRequestDto dto)
        {
            return new Order
            {
                OrderStatus = dto.OrderStatus,
                OrderDate = dto.OrderDate,
                CustomerId = dto.CustomerId,
            };
        }

        public static Order MapUpdateOrderRequestDtoToEntity(UpdateOrderRequestDto dto)
        {
            if (dto == null)
                return null;

            return new Order()
            {
                Id = dto.Id,
                CustomerId= dto.CustomerId,
                OrderDate = dto.OrderDate,
                OrderStatus = dto.OrderStatus
            };
        }
    }
}
