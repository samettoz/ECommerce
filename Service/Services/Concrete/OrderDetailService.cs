

using Core.Repository;
using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using DtoMapper;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class OrderDetailService : IOrderDetailService
    {
        IEntityRepositoryBase<OrderDetail> _orderDetailRepository;
        public OrderDetailService(IEntityRepositoryBase<OrderDetail> orderDetailRepository)
        {
            _orderDetailRepository = orderDetailRepository;
        }


        public async Task AddAsync(OrderDetailRequestDto dto)
        {
            var orderDetail = OrderDetailDtoMapper.MapToEntity(dto);
            await _orderDetailRepository.AddAsync(orderDetail);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderDetailRepository.DeleteAsync(id);
        }


        public async Task<OrderDetailResponseDto> GetByIdAsync(int id)
        {
            var orderDetail = await _orderDetailRepository.GetAsync(od => od.Id == id);
            return OrderDetailDtoMapper.MapToDto(orderDetail);
        }




        public async Task UpdateAsync(UpdateOrderDetailRequestDto dto)
        {
            var orderDetail = OrderDetailDtoMapper.MapUpdateOrderDetailRequestDtoToEntity(dto);
            await _orderDetailRepository.UpdateAsync(orderDetail);
        }

        public async Task<List<OrderDetailResponseDto>> GetAllAsync()
        {
            var orderDetails = await _orderDetailRepository.GetAllAsync();
            return orderDetails.Select(od => OrderDetailDtoMapper.MapToDto(od)).ToList();
        }

    }
}
