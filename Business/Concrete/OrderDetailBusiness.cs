using Business.Abstract;
using Core.Utility.Results;
using Dto.Response;
using Model;
using Model.Request;
using Model.Response;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OrderDetailBusiness : IOrderDetailBusiness
    {
        IOrderDetailService _orderDetailService;
        public OrderDetailBusiness(IOrderDetailService orderDetailService)
        {
            _orderDetailService = orderDetailService;   
        }

        public async Task<IResult> AddAsync(OrderDetailRequestModel model)
        {
            var orderDetailDto = OrderDetailModelMapper.MapToDto(model);
            await _orderDetailService.AddAsync(orderDetailDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _orderDetailService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<OrderDetailResponseModel>>> GetAllAsync()
        {
            var orderDetailDtos = await _orderDetailService.GetAllAsync();
            var orderDetailModels = orderDetailDtos.Select(odDtos => OrderDetailModelMapper.MapToModel(odDtos)).ToList();
            return new SuccessDataResult<List<OrderDetailResponseModel>>(orderDetailModels);
        }

        public async Task<IDataResult<OrderDetailResponseModel>> GetByIdAsync(int id)
        {
            var orderDetailDto = await _orderDetailService.GetByIdAsync(id);
            return new SuccessDataResult<OrderDetailResponseModel>(OrderDetailModelMapper.MapToModel(orderDetailDto));
        }

        public async Task<IResult> UpdateAsync(UpdateOrderDetailRequestModel model)
        {
            var orderDetailDto = OrderDetailModelMapper.MapToUpdateRequestDto(model);
            await _orderDetailService.UpdateAsync(orderDetailDto);
            return new SuccessResult();
        }
    }
}
