using Dto;
using Entity;
using Service.Services.Abstract;
using DtoMapper;
using Core.Utility.Results;
using Core.Repository;
using Dto.Request;
using Dto.Response;

namespace Service.Services.Concrete
{
    public class ProductService : IProductService
    {
        IEntityRepositoryBase<Product> _productRepository;
        
        public ProductService(IEntityRepositoryBase<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddAsync(ProductRequestDto dto)
        {
            var entity = ProductDtoMapper.MapToEntity(dto);
            await _productRepository.AddAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
           await _productRepository.DeleteAsync(id);
        }

        public async Task<List<ProductResponseDto>> GetAllAsync()
        {
            var products = await _productRepository.GetAllAsync();
            return products.Select(product => ProductDtoMapper.MapToDto(product)).ToList();

        }

        public async Task<ProductResponseDto> GetByIdAsync(int id)
        {
            var product = await _productRepository.GetAsync(p => p.Id == id);
            return ProductDtoMapper.MapToDto(product); 
        }

        public async Task UpdateAsync(UpdateProductRequestDto dto)
        {
            var updatedEntity = ProductDtoMapper.MapUpdateProductRequestDtoToEntity(dto);
            await _productRepository.UpdateAsync(updatedEntity);
        }
    }
}
