using AutoMapper;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Website.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, ILanguageService languageService, IContactService contactService, IMapper mapper)
        {
            _productService = productService;
            _languageService = languageService;
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var products = _productService.GetAll().Select(p => _mapper.Map<ProductViewModel>(p)).ToList();
            var contacts = _contactService.GetAll().Select(c => _mapper.Map<ShopContactViewModel>(c)).FirstOrDefault();
            var languages = _languageService.GetAll().Select(l => _mapper.Map<LanguageViewModel>(l)).ToList();
            return View(new CatalogPageViewModel() { Products = products, Languages = languages, Contacts = contacts });
        }
    }
}