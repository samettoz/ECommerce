

using Core.Repository;
using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using DtoMapper;
using Entity;
using Model.Request;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class OrderService : IOrderService
    {
        IEntityRepositoryBase<Order> _orderRepository;
        public OrderService(IEntityRepositoryBase<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task AddAsync(OrderRequestDto dto)
        {
            var order = OrderDtoMapper.MapToEntity(dto);
            await _orderRepository.AddAsync(order);
        }

        public async Task DeleteAsync(int id)
        {
            await _orderRepository.DeleteAsync(id);
        }

        public async Task<List<OrderResponseDto>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            return orders.Select(order => OrderDtoMapper.MapToDto(order)).ToList();
        }

        public async Task<OrderResponseDto> GetByIdAsync(int id)
        {
            var order = await _orderRepository.GetAsync(o => o.Id == id);
            return OrderDtoMapper.MapToDto(order);
        }

        public async Task UpdateAsync(UpdateOrderRequestDto dto)
        {
            var order = OrderDtoMapper.MapUpdateOrderRequestDtoToEntity(dto);
            await _orderRepository.UpdateAsync(order);
        }
    }
}
