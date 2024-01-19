using Business.Abstract;
using Core.Utility.Results;
using Dto.Response;
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
    public class BrandBusiness : IBrandBusiness
    {
        IBrandService _brandService;
        public BrandBusiness(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public async Task<IResult> AddAsync(BrandRequestModel model)
        {
            var brandDto = BrandModelMapper.MapToDto(model);
            await _brandService.AddAsync(brandDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            var result = await _brandService.DeleteAsync(id);
            if (!result.Success)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

        public async Task<IDataResult<List<BrandResponseModel>>> GetAllAsync()
        {
            var brandDtos = await _brandService.GetAllAsync();
            var brandModel = brandDtos.Select(brand => BrandModelMapper.MapToModel(brand)).ToList();
            return new SuccessDataResult<List<BrandResponseModel>>(brandModel);
        }

        public async Task<IDataResult<BrandResponseModel>> GetByIdAsync(int id)
        {
            var brandDto = await _brandService.GetByIdAsync(id);
            return new SuccessDataResult<BrandResponseModel>(BrandModelMapper.MapToModel(brandDto));
        }

        public async Task<IResult> UpdateAsync(UpdateBrandRequestModel model)
        {
            var brandDto = BrandModelMapper.MapToUpdateRequestDto(model);
            await _brandService.UpdateAsync(brandDto);
            return new SuccessResult();
        }
    }
}
