
using Business.Abstract;
using Core.Utility.Results;
using Dto;
using Entity;
using Model.Request;
using Model.Response;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductBusiness : IProductBusiness
    {
        IProductService _productService;

        public ProductBusiness(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IResult> AddAsync(ProductRequestModel model)
        {
            var dto = ProductModelMapper.MapToDto(model);
            await _productService.AddAsync(dto);
            return new SuccessResult(); 
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _productService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<ProductResponseModel>>> GetAllAsync()
        {
            var productDtos = await _productService.GetAllAsync();
            var productModels = productDtos.Select(pd => ProductModelMapper.MapToModel(pd)).ToList();
            return new SuccessDataResult<List<ProductResponseModel>>(productModels);
        }

        public async Task<IDataResult<ProductResponseModel>> GetByIdAsync(int id)
        {
            var productDto = await _productService.GetByIdAsync(id);
            return new SuccessDataResult<ProductResponseModel>(ProductModelMapper.MapToModel(productDto));
        }

        public async Task<IResult> UpdateAsync(UpdateProductRequestModel model)
        {
            var productDto = ProductModelMapper.MaptoUpdateRequestDto(model);
            await _productService.UpdateAsync(productDto);
            return new SuccessResult();
        }
    }
}
