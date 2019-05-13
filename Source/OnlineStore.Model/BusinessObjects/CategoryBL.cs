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
    public class CategoryBL
    {
        private string _categoryId;
        private string _categoryName;
        private string _categoryDescription;
        private string _pageDescription;
        private string _pageKeywords;
        private string _categoryImageFilename;
        private DateTime _modifiedDate;
        private string _stockId;
        private int _productsCount;
        private int _articlesCount;

        public CategoryBL(Category category)
        {
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var translate = category.CategoryTranslates.Where(t => t.Language.LanguageCode == lang).SingleOrDefault();

            _categoryId = category.CategoryId;
            _categoryName = translate.CategoryName;
            _categoryDescription = translate.CategoryDescription;
            _pageDescription = translate.PageDescription;
            _pageKeywords = translate.PageKeywords;
            _categoryImageFilename = category.CategoryImageFilename;
            _modifiedDate = category.ModifiedDate;
            _stockId = category.StockId;
            _productsCount = category.ProductsCount;
            _articlesCount = category.ArticlesCount;
        }

        public CategoryDTO GetDTO()
        {
            return new CategoryDTO()
            {
                CategoryId = _categoryId,
                CategoryName = _categoryName,
                CategoryDescription = _categoryDescription,
                CategoryImageFilename = _categoryImageFilename,
                ModifiedDate = _modifiedDate,
                PageKeywords = _pageKeywords,
                PageDescription = _pageDescription,
                StockId = _stockId,
                ArticlesCount = _articlesCount,
                ProductsCount = _productsCount
            };
        }
    }
}
