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
    public interface IBrandBusiness
    {
        Task<IResult> AddAsync(BrandRequestModel model);
        Task<IResult> UpdateAsync(UpdateBrandRequestModel model);
        Task<IDataResult<List<BrandResponseModel>>> GetAllAsync();
        Task<IDataResult<BrandResponseModel>> GetByIdAsync(int id);
        Task<IResult> DeleteAsync(int id);
    }
}
