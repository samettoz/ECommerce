using Core.Utility.Results;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderBusiness
    {
        Task<IResult> AddAsync(OrderRequestModel model);
        Task<IResult> UpdateAsync(UpdateOrderRequestModel model);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<OrderResponseModel>>> GetAllAsync();
        Task<IDataResult<OrderResponseModel>> GetByIdAsync(int id);
    }
}
