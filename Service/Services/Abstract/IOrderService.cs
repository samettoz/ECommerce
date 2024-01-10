

using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using Entity;
using Model.Request;

namespace Service.Services.Abstract
{
    public interface IOrderService
    {
        Task AddAsync(OrderRequestDto dto);
        Task UpdateAsync(UpdateOrderRequestDto dto);
        Task DeleteAsync(int id);
        Task<List<OrderResponseDto>> GetAllAsync();
        Task<OrderResponseDto> GetByIdAsync(int id);
    }
}
