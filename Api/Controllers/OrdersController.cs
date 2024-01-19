using Business.Abstract;
using IResult = Core.Utility.Results.IResult;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Utility.Results;
using Microsoft.Identity.Client;
using Model.Response;
using Model.Request;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        IOrderBusiness _orderBusiness;
        public OrdersController(IOrderBusiness orderBusiness)
        {
            _orderBusiness = orderBusiness;
        }

        [HttpPost]
        public async Task<IResult> Add(OrderRequestModel model)
        {
            return await _orderBusiness.AddAsync(model);
        }

        [HttpGet]
        public async Task<IDataResult<List<OrderResponseModel>>> GetAll() 
        {
            return await _orderBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<OrderResponseModel>> GetById(int id)
        {
            return await _orderBusiness.GetByIdAsync(id);
        }

        [HttpPut]
        public async Task<IResult> Update(UpdateOrderRequestModel model)
        {
            return await _orderBusiness.UpdateAsync(model);
        }

        [HttpDelete("{id}")]
        public async Task<IResult> Delete(int id)
        {
            return await _orderBusiness.DeleteAsync(id);
        }
    }
}
