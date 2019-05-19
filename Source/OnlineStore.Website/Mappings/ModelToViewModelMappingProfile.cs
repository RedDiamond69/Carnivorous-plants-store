using AutoMapper;
using OnlineStore.Model.DTO;
using OnlineStore.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.Mappings
{
    public class ModelToViewModelMappingProfile : Profile
    {
        public override string ProfileName => "ModelToViewModelMappingProfile";

        public ModelToViewModelMappingProfile()
        {
            CreateMap<CategoryDTO, CategoryViewModel>();
            CreateMap<ProductDTO, ProductViewModel>();
            CreateMap<ArticleDTO, ArticleViewModel>();
            CreateMap<ProviderDTO, ProductViewModel>();
            CreateMap<LanguageDTO, LanguageViewModel>();
        }
    }
}