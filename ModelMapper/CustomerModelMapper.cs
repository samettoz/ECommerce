using Dto.Request;
using Dto.Response;
using Model;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public static class CustomerModelMapper 
    {
        public static CustomerRequestDto MapToDto(CustomerRequestModel model)
        {
            if (model == null)
                return null;

            return new CustomerRequestDto
            {
                Adress = model.Adress,
                City = model.City,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.Password,
                Phone = model.Phone,
                UserName = model.UserName
            }; 
        }

        public static CustomerResponseModel MapToModel(CustomerResponseDto dto)
        {
            if (dto == null)
                return null;

            return new CustomerResponseModel
            {
                UserName = dto.UserName,
                Phone = dto.Phone,
                Password = dto.Password,
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Adress = dto.Adress,
                City = dto.City
            };
        }

        public static UpdateCustomerRequestDto MapToUpdateRequestDto(UpdateCustomerRequestModel model)
        {
            if (model == null)
                return null;

            return new UpdateCustomerRequestDto
            {
                Id = model.Id,
                Adress = model.Adress,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Password = model.Password,
                Phone = model.Phone,
                UserName = model.UserName
            };
        }
    }
}
