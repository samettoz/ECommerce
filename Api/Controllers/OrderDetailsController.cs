using IResult = Core.Utility.Results.IResult;
using Business.Abstract;
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
    public class OrderDetailsController : ControllerBase
    {
        IOrderDetailBusiness _orderDetailBusiness;
        public OrderDetailsController(IOrderDetailBusiness orderDetailBusiness)
        {
            _orderDetailBusiness = orderDetailBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<OrderDetailResponseModel>>> GetAll()
        {
            return await _orderDetailBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<OrderDetailResponseModel>> GetById([FromRoute] int id)
        {
            return await _orderDetailBusiness.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task<IResult> Add(OrderDetailRequestModel model)
        {
            return await _orderDetailBusiness.AddAsync(model);
        }

        [HttpPut]
        public async Task<IResult> Update(UpdateOrderDetailRequestModel model)
        {
            return await _orderDetailBusiness.UpdateAsync(model);
        }

        [HttpDelete("{id}")]
        public Task<IResult> Delete(int id)
        {
            return _orderDetailBusiness.DeleteAsync(id);
        }

    }
}
