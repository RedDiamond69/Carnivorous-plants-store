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
    public class ArticleBL
    {
        private string _articleId;
        private string _articleTitle;
        private string _articleText;
        private string _pageDescription;
        private string _pageKeywords;
        private string _imageFilename;
        private DateTime _modifiedDate;
        private string _categoryId;

        public ArticleBL(Article article)
        {
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var translate = article.ArticleTranslates.Where(a => a.Language.LanguageCode == lang).SingleOrDefault();

            _articleId = article.ArticleId;
            _articleTitle = translate.ArticleTitle;
            _articleText = translate.ArticleText;
            _pageDescription = translate.PageDescription;
            _pageKeywords = translate.PageKeywords;
            _imageFilename = article.ImageFilename;
            _modifiedDate = article.ModifiedDate;
            _categoryId = article.CategoryId;
        }

        public ArticleDTO GetDTO()
        {
            return new ArticleDTO()
            {
                ArticleId = _articleId,
                ArticleText = _articleText,
                ArticleTitle = _articleTitle,
                ImageFilename = _imageFilename,
                ModifiedDate = _modifiedDate,
                CategoryId = _categoryId,
                PageKeywords = _pageKeywords,
                PageDescription = _pageDescription
            };
        }
    }
}
