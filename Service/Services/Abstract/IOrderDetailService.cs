

using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using Entity;

namespace Service.Services.Abstract
{
    public interface IOrderDetailService
    {
        Task AddAsync(OrderDetailRequestDto dto);
        Task UpdateAsync(UpdateOrderDetailRequestDto dto);
        Task DeleteAsync(int id);
        Task<List<OrderDetailResponseDto>> GetAllAsync();
        Task<OrderDetailResponseDto> GetByIdAsync(int id);
    }
}
