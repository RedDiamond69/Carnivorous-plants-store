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
    public class StockBL
    {
        private string _stockId;
        private int _discount;
        private bool _isActive;
        private string _stockTitle;
        private string _stockDescription;
        private string _imageFilename;
        private DateTime _startDate;
        private DateTime _finishDate;

        public StockBL(Stock stock)
        {
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var translate = stock.StockTranslates.Where(t => t.Language.LanguageCode == lang).FirstOrDefault();

            _stockId = stock.StockId;
            _discount = stock.Discount;
            _isActive = stock.IsActive;
            _stockTitle = translate.StockTitle;
            _stockDescription = translate.StockDescription;
            _imageFilename = translate.ImageFilename;
            _startDate = stock.StartDate;
            _finishDate = stock.FinishDate;
        }

        public StockDTO GetDTO()
        {
            return new StockDTO()
            {
                StockId = _stockId,
                StockTitle = _stockTitle,
                StockDescription = _stockDescription,
                Discount = _discount,
                StartDate = _startDate,
                FinishDate = _finishDate,
                ImageFilename = _imageFilename,
                IsActive = _isActive
            };
        }
    }
}
