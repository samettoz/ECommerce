

using Core.Utility.Results;
using Dto.Request;
using Dto.Response;

namespace Service.Services.Abstract
{
    public interface ICategorieService
    {
        Task AddAsync(CategorieRequestDto dto);
        Task UpdateAsync(UpdateCategorieRequestDto dto);
        Task DeleteAsync(int id);
        Task<CategorieResponseDto> GetByIdAsync(int id);
        Task<List<CategorieResponseDto>> GetAllAsync();
    }
}
