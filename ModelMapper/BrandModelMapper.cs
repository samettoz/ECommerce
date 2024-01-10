using Dto.Request;
using Dto.Response;
using Model.Request;
using Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMapper
{
    public static class BrandModelMapper 
    {
        public static BrandRequestDto MapToDto(BrandRequestModel model)
        {
            if (model == null)
                return null;

            return new BrandRequestDto
            {
                BrandName = model.BrandName,
            };
        }

        public static BrandResponseModel MapToModel(BrandResponseDto dto)
        {
            if (dto == null)
                return null;

            return new BrandResponseModel
            {
                Id = dto.Id,
                BrandName = dto.BrandName,
            };
        }

        public static UpdateBrandRequestDto MapToUpdateRequestDto(UpdateBrandRequestModel model)
        {
            if (model == null)
                return null;

            return new UpdateBrandRequestDto
            {
                Id = model.Id,
                BrandName = model.BrandName
            };
        }
    }
}
