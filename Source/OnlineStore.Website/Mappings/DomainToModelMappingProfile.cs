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
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            CreateMap<Category, CategoryDTO>()
                .ForMember(c => c.CategoryName, opt
                    => opt.MapFrom(source
                        => source.CategoryTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().CategoryName))
                .ForMember(c => c.CategoryDescription, opt
                    => opt.MapFrom(source
                        => source.CategoryTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().CategoryDescription))
                .ForMember(c => c.PageKeywords, opt
                    => opt.MapFrom(source
                        => source.CategoryTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().PageKeywords))
                .ForMember(c => c.PageDescription, opt
                    => opt.MapFrom(source
                        => source.CategoryTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().PageDescription));

            CreateMap<Product, ProductDTO>()
                .ForMember(p => p.ProductName, opt
                    => opt.MapFrom(source
                        => source.ProductTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().ProductName))
                .ForMember(p => p.ProductDescription, opt
                    => opt.MapFrom(source
                        => source.ProductTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().ProductDescription))
                .ForMember(p => p.PageKeywords, opt
                    => opt.MapFrom(source
                        => source.ProductTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().PageKeywords))
                .ForMember(p => p.PageDescription, opt
                    => opt.MapFrom(source
                        => source.ProductTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().PageDescription))
                .ForMember(p => p.Price, opt
                    => opt.MapFrom(source
                        => source.Stock == null ?
                            (source.Category.Stock == null ? source.Price : (1 - source.Category.Stock.Discount / 100) * source.Price)
                            : ((1 - source.Stock.Discount / 100) * source.Price)));

            CreateMap<Article, ArticleDTO>()
                .ForMember(a => a.ArticleTitle, opt
                    => opt.MapFrom(source
                        => source.ArticleTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().ArticleTitle))
                .ForMember(a => a.ArticleText, opt
                    => opt.MapFrom(source
                        => source.ArticleTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().ArticleText))
                .ForMember(a => a.PageDescription, opt
                    => opt.MapFrom(source
                        => source.ArticleTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().PageDescription))
                .ForMember(a => a.PageKeywords, opt
                    => opt.MapFrom(source
                        => source.ArticleTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().PageKeywords));

            CreateMap<Provider, ProviderDTO>()
                .ForMember(pr => pr.ProviderName, opt
                    => opt.MapFrom(source
                        => source.ProviderTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().ProviderName))
                .ForMember(pr => pr.ProviderDescription, opt
                    => opt.MapFrom(source
                        => source.ProviderTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault().ProviderDescription));

            CreateMap<Language, LanguageDTO>();
        }
    }
}