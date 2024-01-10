﻿using Business.Abstract;
using IResult = Core.Utility.Results.IResult;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Core.Utility.Results;
using Model.Response;
using Model.Request;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategorieBusiness _categorieBusiness;
        public CategoriesController(ICategorieBusiness categorieBusiness)
        {
            _categorieBusiness = categorieBusiness;
        }

        [HttpGet]
        public async Task<IDataResult<List<CategorieResponseModel>>> GetAll()
        {
            return await _categorieBusiness.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<IDataResult<CategorieResponseModel>> GetById(int id)
        {
            return await _categorieBusiness.GetById(id);
        }

        [HttpPost]
        public async Task<IResult> AddAsync(CategorieRequestModel model)
        {
            return await _categorieBusiness.AddAsync(model);
        }

        [HttpDelete]
        public async Task<IResult> Delete(int id)
        {
            return await _categorieBusiness.DeleteAsync(id);
        }

        [HttpPut]
        public async Task<IResult> Update(UpdateCategorieRequestModel model)
        {
            return await _categorieBusiness.UpdateAsync(model);
        }
    }
}
