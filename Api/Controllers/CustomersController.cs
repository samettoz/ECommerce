using Business.Abstract;
using IResult = Core.Utility.Results.IResult;
using Core.Utility.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Response;
using Model.Request;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        ICustomerBusiness _customerBusiness;
        public CustomersController(ICustomerBusiness customerBusiness)
        {
            _customerBusiness = customerBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<CustomerResponseModel>>> GetAll()
        {
            return await _customerBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<CustomerResponseModel>> GetById(int id)
        {
            return await _customerBusiness.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(CustomerRequestModel model)
        {
            return await _customerBusiness.AddAsync(model);
        }

        [HttpPut]
        public async Task<IResult> Update(UpdateCustomerRequestModel model)
        {
            return await _customerBusiness.UpdateAsync(model);
        }

        [HttpDelete]
        public async Task<IResult> Delete(int id)
        {
            return await _customerBusiness.DeleteAsync(id);
        }

    }
}
