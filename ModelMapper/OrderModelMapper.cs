using Dto.Request;
using Dto.Response;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public static class OrderModelMapper 
    {
        public static OrderRequestDto MapToDto(OrderRequestModel model)
        {
            if (model == null)
                return null;

            
            return new OrderRequestDto
            {
                CustomerId = model.CustomerId,
                OrderDate = model.OrderDate,
                OrderStatus = model.OrderStatus
            };
        }

        public static OrderResponseModel MapToModel(OrderResponseDto dto)
        {
            if (dto == null)
                return null;

            return new OrderResponseModel
            {
                Id = dto.Id,
                OrderStatus = dto.OrderStatus,
                OrderDate = dto.OrderDate,
                CustomerId = dto.CustomerId,
            };
        }

        public static UpdateOrderRequestDto MapToUpdateRequestDto(UpdateOrderRequestModel model)
        {
            if (model == null)
                return null;

            return new UpdateOrderRequestDto()
            {
                Id = model.Id,
                CustomerId= model.CustomerId,  
                OrderDate = model.OrderDate,
                OrderStatus = model.OrderStatus
            };
        }
    }
}
