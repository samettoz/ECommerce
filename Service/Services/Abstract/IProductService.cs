
using Dto;
using Entity;
using Core.Utility.Results;
using Dto.Request;
using Dto.Response;

namespace Service.Services.Abstract
{
    public interface IProductService 
    {
        Task AddAsync(ProductRequestDto dto);
        Task DeleteAsync(int id);
        Task UpdateAsync(UpdateProductRequestDto Dto);
        Task<ProductResponseDto> GetByIdAsync(int id);
        Task<List<ProductResponseDto>> GetAllAsync();
        
       
    }
}
