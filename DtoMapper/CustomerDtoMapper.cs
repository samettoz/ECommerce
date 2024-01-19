using Dto.Request;
using Dto.Response;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public static class CustomerDtoMapper 
    {
        public static CustomerResponseDto MapToDto(Customer entity)
        {
            if (entity == null)
                return null;

            return new CustomerResponseDto
            {
                Id = entity.Id,
                Adress = entity.Adress,
                City = entity.City,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Password = entity.Password,
                Phone = entity.Phone,
                UserName = entity.UserName,
            };
        }

        public static Customer MapToEntity(CustomerRequestDto dto)
        {
            if (dto == null)
                return null;

            return new Customer
            {
                Adress = dto.Adress,
                City = dto.City,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Password = dto.Password,
                Phone = dto.Phone,
                UserName = dto.UserName
            };
        }

        public static Customer MapUpdateCustomerRequestDtoToEntity(UpdateCustomerRequestDto dto)
        {
            if (dto == null)
                return null;

            return new Customer()
            {
                Id = dto.Id,
                Adress = dto.Adress,
                City = dto.City,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Password = dto.Password,
                Phone = dto.Phone,
                UserName = dto.UserName
            };
        }
    }
}
