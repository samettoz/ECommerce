using Business.Abstract;
using Core.Utility.Results;
using Dto.Response;
using Model;
using Model.Request;
using Model.Response;
using ModelMapper;
using Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerBusiness : ICustomerBusiness
    {
        ICustomerService _customerService;
        public CustomerBusiness(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public async Task<IResult> AddAsync(CustomerRequestModel model)
        {
            var customerDto = CustomerModelMapper.MapToDto(model);
            await _customerService.AddAsync(customerDto);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(int id)
        {
            await _customerService.DeleteAsync(id);
            return new SuccessResult();
        }

        public async Task<IDataResult<List<CustomerResponseModel>>> GetAllAsync()
        {
            var customerDtos = await _customerService.GetAllAsync();
            var customerModels = customerDtos.Select(customerDto => CustomerModelMapper.MapToModel(customerDto)).ToList();
            return new SuccessDataResult<List<CustomerResponseModel>>(customerModels);
        }

        public async Task<IDataResult<CustomerResponseModel>> GetByIdAsync(int id)
        {
            var customerDto = await _customerService.GetByIdAsync(id);
            return new SuccessDataResult<CustomerResponseModel>(CustomerModelMapper.MapToModel(customerDto));
        }

        public async Task<IResult> UpdateAsync(UpdateCustomerRequestModel model)
        {
            var customerDto = CustomerModelMapper.MapToUpdateRequestDto(model);
            await _customerService.UpdateAsync(customerDto);
            return new SuccessResult();
        }
    }
}
