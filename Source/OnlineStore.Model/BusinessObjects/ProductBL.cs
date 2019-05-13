using OnlineStore.DataProvider.Entities;
using OnlineStore.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineStore.Model.BusinessObjects
{
    public class ProductBL
    {
        private string _productId;
        private string _vendorCode;
        private DateTime _modifiedDate;
        private decimal _price;
        private string _productImageFilename;
        private string _categoryId;
        private string _providerId;
        private string _stockId;
        private string _productName;
        private string _productDescription;
        private string _pageKeywords;
        private string _pageDescription;

        public ProductBL(Product product)
        {
            string lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            _productId = product.ProductId;
            _vendorCode = product.VendorCode;
            _modifiedDate = product.ModifiedDate;
            _price = product.Stock is null ?
                (product.Category.Stock is null ? product.Price : (1 - product.Category.Stock.Discount / 100) * product.Price) :
                ((1 - product.Stock.Discount / 100) * product.Price); 
            _productImageFilename = product.ProductImageFilename;
            _categoryId = product.CategoryId;
            var translate = product.ProductTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault();
            _stockId = product.StockId;
            _providerId = product.ProviderId;
            _productName = translate.ProductName;
            _productDescription = translate.ProductDescription;
            _pageKeywords = translate.PageKeywords;
            _pageDescription = translate.PageDescription;
        }

        public ProductDTO GetDTO()
        {
            return new ProductDTO()
            {
                ProductId = _productId,
                CategoryId = _categoryId,
                ProviderId = _providerId,
                ModifiedDate = _modifiedDate,
                PageDescription = _pageDescription,
                PageKeywords = _pageKeywords,
                Price = _price,
                ProductDescription = _productDescription,
                ProductImageFilename = _productImageFilename,
                ProductName = _productName,
                StockId = _stockId,
                VendorCode = _vendorCode
            };
        }
    }
}
