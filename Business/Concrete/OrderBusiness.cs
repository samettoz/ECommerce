using Business.Abstract;
using Core.Utility.Results;
using Dto.Response;
using Model.Request;
using Model.Response;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderBusiness : IOrderBusiness
    {
        IOrderService _orderService;

        public OrderBusiness(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public async Task<IResult> AddAsync(OrderRequestModel model)
        {
            var orderDto = OrderModelMapper.MapToDto(model);
            await _orderService.AddAsync(orderDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _orderService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<OrderResponseModel>>> GetAllAsync()
        {
            var orderDtos = await _orderService.GetAllAsync();
            var orderModels = orderDtos.Select(orderDto => OrderModelMapper.MapToModel(orderDto)).ToList();
            return new SuccessDataResult<List<OrderResponseModel>>(orderModels);   
        }

        public async Task<IDataResult<OrderResponseModel>> GetByIdAsync(int id)
        {
            var orderDto = await _orderService.GetByIdAsync(id);
            return new SuccessDataResult<OrderResponseModel>(OrderModelMapper.MapToModel(orderDto));
        }

        public async Task<IResult> UpdateAsync(UpdateOrderRequestModel model)
        {
            var orderDto = OrderModelMapper.MapToUpdateRequestDto(model);
            await _orderService.UpdateAsync(orderDto);
            return new SuccessResult();
        }
    }
}
