using AutoMapper;
using OnlineStore.DataProvider.Entities;
using OnlineStore.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace OnlineStore.Website.Mappings
{
    public class DomainToModelMappingProfile : Profile
    {
        public override string ProfileName => "DomainToModelMappingProfile";

        public DomainToModelMappingProfile()
        {
            CreateMap<Language, LanguageDTO>();
        }
    }
}