using Dto.Request;
using Dto.Response;
using Entity;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoMapper
{
    public static class BrandDtoMapper 
    {
        public static BrandResponseDto MapToDto(Brand entity)
        {
            if (entity == null)
                return null;
            
            return new BrandResponseDto
            {
                BrandName = entity.BrandName,
                Id = entity.Id
            };
        }

        public static Brand MapToEntity(BrandRequestDto dto)
        {
            if (dto == null)
                return null;

            return new Brand
            {
                BrandName = dto.BrandName
            };
        }

        public static Brand MapUpdateBrandRequestDtoToEntity(UpdateBrandRequestDto dto)
        {
            if (dto == null)
                return null;

            return new Brand
            {
                Id = dto.Id,
                BrandName = dto.BrandName
            };
        }
    }
}
