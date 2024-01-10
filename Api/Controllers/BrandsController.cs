using IResult = Core.Utility.Results.IResult;
using Business.Abstract;
using Core.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Response;
using Model.Request;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        IBrandBusiness _brandBusiness;
        public BrandsController(IBrandBusiness brandBusiness)
        {
            _brandBusiness = brandBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<BrandResponseModel>>> GetAll()
        {
            return await _brandBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<BrandResponseModel>> GetById(int id) 
        {
            return await _brandBusiness.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(BrandRequestModel model)
        {
            return await _brandBusiness.AddAsync(model);
        }

        [HttpPut]
        public async Task<IResult> Update(UpdateBrandRequestModel model) 
        {
            return await _brandBusiness.UpdateAsync(model);
        }
        
        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _brandBusiness.DeleteAsync(id);
        }


    }
}
