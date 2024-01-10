
using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using System.Linq.Expressions;


namespace Service.Services.Abstract
{
    public interface IBrandService
    {
        Task AddAsync(BrandRequestDto dto);
        Task UpdateAsync(UpdateBrandRequestDto dto);
        Task<IResult> DeleteAsync(int id);
        Task<List<BrandResponseDto>> GetAllAsync();
        Task<BrandResponseDto> GetByIdAsync(int id);
    }
}
