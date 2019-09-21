using AutoMapper;
using OnlineStore.Model.DTO;
using OnlineStore.Website.Areas.Account.ViewModels;
using OnlineStore.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Website.Mappings
{
    public class ViewModelToModelMappingProfile : Profile
    {
        public override string ProfileName => "ViewModelToModelMappingProfile";

        public ViewModelToModelMappingProfile()
        {
            CreateMap<CategoryViewModel, CategoryDTO>();
            CreateMap<ProductViewModel, ProductDTO>();
            CreateMap<ArticleViewModel, ArticleDTO>();
            CreateMap<ProviderViewModel, ProviderDTO>();
            CreateMap<LanguageViewModel, LanguageDTO>();
            CreateMap<ShopContactViewModel, ShopContactDTO>();
            CreateMap<StockViewModel, StockDTO> ();
            CreateMap<SignInViewModel, ApplicationUserDTO>();
            CreateMap<SignUpViewModel, ApplicationUserDTO>();
            CreateMap<SignUpViewModel, ApplicationUserProfileDTO>();
        }
    }
}