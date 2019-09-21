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
    public class EntityToModelMappingProfile : Profile
    {
        public override string ProfileName => "EntityToModelMappingProfile";

        public EntityToModelMappingProfile()
        {
            CreateMap<Language, LanguageDTO>();
            CreateMap<ApplicationUser, ApplicationUserDTO>();
            CreateMap<ApplicationUserProfile, ApplicationUserProfileDTO>();
        }
    }
}