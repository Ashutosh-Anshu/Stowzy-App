using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using user_gateway.BLL.Application.Services.Account.DTOs;
using user_gateway.Domain.Entities.Account;

namespace user_gateway.BLL.Application.Mappings
{
    public class OwnerMappingProfile : Profile
    {
        public OwnerMappingProfile()
        {


            CreateMap<RegisterOwnerDTO, RegisterOwnerModel>()
                   .ForMember(dest => dest.OwnerDocument, opt => opt.MapFrom(src => src.LockerDocument));

            CreateMap<LockerDocumentDTO, OwnerDocument>();

            CreateMap<OwnerDTO, Owner>();

            CreateMap<OwnerLoginDTO, OwnerLogin>();

            CreateMap<LockerDTO, Locker>()
                .ForMember(dest => dest.LockerImages, opt => opt.MapFrom(src => src.LockerImages));

            CreateMap<LockerImageDTO, LockerImage>();

        }


    }


}
