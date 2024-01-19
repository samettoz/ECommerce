using Dto.Request;
using Dto.Response;
using Microsoft.Extensions.Logging.Abstractions;
using Model;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public static class OrderDetailModelMapper 
    {
        public static OrderDetailRequestDto MapToDto(OrderDetailRequestModel model)
        {
            if (model == null)
                return null;

            return new OrderDetailRequestDto
            {
                OrderId = model.OrderId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                UnitPrice = model.UnitPrice
            };
        }

        public static OrderDetailResponseModel MapToModel(OrderDetailResponseDto dto)
        {
            if (dto == null)
                return null;

            return new OrderDetailResponseModel
            {
                Id = dto.Id,
                OrderId = dto.OrderId,
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                UnitPrice = dto.UnitPrice
            };
        }

        public static UpdateOrderDetailRequestDto MapToUpdateRequestDto(UpdateOrderDetailRequestModel model)
        {
            if (model == null)
                return null;

            return new UpdateOrderDetailRequestDto()
            {
                Id = model.Id,
                OrderId = model.OrderId,
                ProductId = model.ProductId,
                Quantity = model.Quantity,
                UnitPrice = model.UnitPrice
            };
        }
    }
}
