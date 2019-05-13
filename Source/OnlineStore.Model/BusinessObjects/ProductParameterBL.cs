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
    internal class ProductParameterBL
    {
        private string _productParameterId;
        private string _dimensionName;
        private string _dimensionDescription;
        private decimal _priceIncrease;
        private bool _availability;
        private string _productId;

        public ProductParameterBL(ProductParameter parameter)
        {
            string lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var translate = parameter.ProductParameterTranslates.Where(p => p.Language.LanguageCode == lang).SingleOrDefault();
            var dimensionTranslate = parameter.Dimension.DimensionTranslates.Where(p => p.Language.LanguageCode == lang).SingleOrDefault();

            _productParameterId = parameter.ProductParameterId;
            _dimensionName = dimensionTranslate.DimensionName;
            _dimensionDescription = dimensionTranslate.DimensionDescription;
            _priceIncrease = translate.PriceIncrease;
            _availability = parameter.Availability;
            _productId = parameter.ProductId;
        }

        public ProductParameterDTO GetDTO()
        {
            return new ProductParameterDTO()
            {
                ProductParameterId = _productParameterId,
                DimensionName = _dimensionName,
                DimensionDescription = _dimensionDescription,
                Availability = _availability,
                PriceIncrease = _priceIncrease,
                ProductId = _productId
            };
        }
    }
}
