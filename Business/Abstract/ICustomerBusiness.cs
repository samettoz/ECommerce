using Core.Utility.Results;
using Model;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerBusiness
    {
        Task<IResult> AddAsync(CustomerRequestModel model);
        Task<IResult> UpdateAsync(UpdateCustomerRequestModel model);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<CustomerResponseModel>>> GetAllAsync();
        Task<IDataResult<CustomerResponseModel>> GetByIdAsync(int id);
    }
}
