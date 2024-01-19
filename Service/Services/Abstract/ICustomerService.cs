

using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using Entity;

namespace Service.Services.Abstract
{
    public interface ICustomerService
    {
        Task AddAsync(CustomerRequestDto dto);
        Task UpdateAsync(UpdateCustomerRequestDto dto);
        Task DeleteAsync(int id);
        Task<List<CustomerResponseDto>> GetAllAsync();
        Task<CustomerResponseDto> GetByIdAsync(int id);

    }
}
