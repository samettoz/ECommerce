using Core.Repository;
using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using DtoMapper;
using Entity;

using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class BrandService : IBrandService
    {
        IEntityRepositoryBase<Brand> _brandRepository; 
        public BrandService(IEntityRepositoryBase<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task AddAsync(BrandRequestDto dto)
        {
            var brand = BrandDtoMapper.MapToEntity(dto);
            await _brandRepository.AddAsync(brand);
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var brand = await _brandRepository.GetAsync(b => b.Id == id);
            if (brand == null)
                return new ErrorResult();
            await _brandRepository.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<List<BrandResponseDto>> GetAllAsync()
        {
            var brands = await _brandRepository.GetAllAsync();
            return brands.Select(brand => BrandDtoMapper.MapToDto(brand)).ToList();
        }

        public async Task<BrandResponseDto> GetByIdAsync(int id)
        {
            var brand = await _brandRepository.GetAsync(b => b.Id == id);
            return BrandDtoMapper.MapToDto(brand);
            
        }

        public async Task UpdateAsync(UpdateBrandRequestDto dto)
        {
            var brand = BrandDtoMapper.MapUpdateBrandRequestDtoToEntity(dto);
            await _brandRepository.UpdateAsync(brand);
        }
    }
}
