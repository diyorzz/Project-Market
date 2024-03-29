﻿using AutoMapper;
using DiyorMarket.Domain.DTOs.Supplier;
using DiyorMarket.Domain.Entities;
namespace DiyorMarket.Domain.Mappings
{
    public class SupplierMappings : Profile
    {
        public SupplierMappings()
        {
            CreateMap<Supplier, SupplierDTO>()
                .ForCtorParam("FullName", opt => opt.MapFrom(src => string.Join(" ", src.FirstName, src.LastName)));
            CreateMap<SupplierDTO, Supplier>();
            CreateMap<SupplierForCreateDTO, Supplier>();
            CreateMap<SupplierForUpdateDTO, Supplier>();
        }
    }
}
