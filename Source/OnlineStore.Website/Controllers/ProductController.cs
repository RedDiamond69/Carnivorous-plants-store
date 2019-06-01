using AutoMapper;
using OnlineStore.Logic.Interfaces;
using OnlineStore.Website.ViewModels;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineStore.Website.Controllers
{
    public class ProductController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IProductService _productService;
        private readonly ILanguageService _languageService;
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, ILanguageService languageService, 
            IContactService contactService, ICategoryService categoryService, IMapper mapper)
        {
            _productService = productService;
            _languageService = languageService;
            _contactService = contactService;
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var categories = _categoryService.GetAll().Select(c => _mapper.Map<CategoryViewModel>(c)).OrderBy(c => c.CategoryName).ToList();
            var products = _productService.GetAll().Select(p => _mapper.Map<ProductViewModel>(p)).ToList();
            var contacts = _contactService.GetAll().Select(c => _mapper.Map<ShopContactViewModel>(c)).FirstOrDefault();
            var languages = _languageService.GetAll().Select(l => _mapper.Map<LanguageViewModel>(l)).ToList();
            ViewBag.AllProductsCount = products.Count;
            return View(new CatalogPageViewModel() {
                Categories = categories,
                Products = products.ToPagedList(1, 10),
                Languages = languages,
                Contacts = contacts
            });
        }

        [HttpGet]
        public ActionResult Category(string id = "",
                                     string search = "",
                                     string sortOrder = "",
                                     int page = 1,
                                     int pageSize = 10)
        {
            ViewBag.CurrentSearchString = search.ToLower();
            ViewBag.CurrentSortOrder = sortOrder;
            ViewBag.PageSize = pageSize;
            ViewBag.CategoryId = id;
            var products = _productService.GetAll().Select(p => _mapper.Map<ProductViewModel>(p)).ToList();
            ViewBag.AllProductsCount = products.Count;
            if (!string.IsNullOrEmpty(id))
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
            if (!string.IsNullOrEmpty(search))
            {
                page = 1;
                products = products.Where(p => p.ProductName.ToLower().Contains(search.ToLower())).ToList();
            }
            switch (sortOrder)
            {
                case "nameAsc":
                    {
                        products = products.OrderBy(p => p.ProductName).ToList();
                        break;
                    }
                case "nameDesc":
                    {
                        products = products.OrderByDescending(p => p.ProductName).ToList();
                        break;
                    }
                case "priceAsc":
                    {
                        products = products.OrderBy(p => p.Price).ToList();
                        break;
                    }
                case "priceDesc":
                    {
                        products = products.OrderByDescending(p => p.Price).ToList();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            var categories = _categoryService.GetAll().Select(c => _mapper.Map<CategoryViewModel>(c)).OrderBy(c => c.CategoryName).ToList();
            var contacts = _contactService.GetAll().Select(c => _mapper.Map<ShopContactViewModel>(c)).FirstOrDefault();
            var languages = _languageService.GetAll().Select(l => _mapper.Map<LanguageViewModel>(l)).ToList();
            return View("Index", new CatalogPageViewModel() {
                Categories = categories,
                Products = products.ToPagedList(page, pageSize),
                Languages = languages,
                Contacts = contacts
            });
        }

        [HttpGet]
        public ActionResult Details(string id = "")
        {
            var contacts = _contactService.GetAll().Select(c => _mapper.Map<ShopContactViewModel>(c)).FirstOrDefault();
            var languages = _languageService.GetAll().Select(l => _mapper.Map<LanguageViewModel>(l)).ToList();
            return View(new ProductDetailViewModel() { Contacts = contacts, Languages = languages });
        }
    }
}