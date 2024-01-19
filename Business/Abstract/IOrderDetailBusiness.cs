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
    public interface IOrderDetailBusiness
    {
        Task<IResult> AddAsync(OrderDetailRequestModel model);
        Task<IResult> UpdateAsync(UpdateOrderDetailRequestModel model);
        Task<IResult> DeleteAsync(int id);
        Task<IDataResult<List<OrderDetailResponseModel>>> GetAllAsync();
        Task<IDataResult<OrderDetailResponseModel>> GetByIdAsync(int id);
    }
}
