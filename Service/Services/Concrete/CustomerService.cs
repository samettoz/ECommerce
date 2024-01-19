

using Core.Repository;
using Core.Utility.Results;
using Dto.Request;
using Dto.Response;
using DtoMapper;
using Entity;
using Service.Services.Abstract;

namespace Service.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        IEntityRepositoryBase<Customer> _customerRepository;
        public CustomerService(IEntityRepositoryBase<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task AddAsync(CustomerRequestDto dto)
        {
            var customer = CustomerDtoMapper.MapToEntity(dto);
            _customerRepository.AddAsync(customer);
        }

        public async Task DeleteAsync(int id)
        {
            await _customerRepository.DeleteAsync(id);
        }

        public async Task<List<CustomerResponseDto>> GetAllAsync()
        {
            var customers = await _customerRepository.GetAllAsync();
            return customers.Select(customer => CustomerDtoMapper.MapToDto(customer)).ToList();
        }

        public async Task<CustomerResponseDto> GetByIdAsync(int id)
        {
            var customer = await _customerRepository.GetAsync(c => c.Id == id);
            return CustomerDtoMapper.MapToDto(customer);
        }

        public async Task UpdateAsync(UpdateCustomerRequestDto dto)
        {
            var customer = CustomerDtoMapper.MapUpdateCustomerRequestDtoToEntity(dto);
            await _customerRepository.UpdateAsync(customer);
        }
    }
}
