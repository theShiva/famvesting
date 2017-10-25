using AutoMapper;
using SingleFamProperties.Dtos;
using SingleFamProperties.Helpers;
using SingleFamProperties.Models;

namespace SingleFamProperties
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<PropertyDto, PropertySummaryDto>()
                    .ForMember(dest => dest.ListPrice, opt => opt.MapFrom(src => src.Financial.ListPrice))
                    .ForMember(dest => dest.MonthlyRent, opt => opt.MapFrom(src => src.Financial.MonthlyRent))
                    .ForMember(dest => dest.YearBuilt, opt => opt.MapFrom(src => src.Physical.YearBuilt))
                    .ForMember(dest => dest.FullAddress, opt => opt.ResolveUsing<FullAddressResolver>());

                config.CreateMap<PropertyForCreationDto, Property>()
                    .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.FullAddress));

                config.CreateMap<Property, PropertySummaryDto>()
                    .ForMember(dest => dest.FullAddress, opt => opt.MapFrom(src => src.Address));
            });
        }
    }
}