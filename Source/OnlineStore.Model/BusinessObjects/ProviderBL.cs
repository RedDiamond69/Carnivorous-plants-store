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
    internal class ProviderBL
    {
        private string _providerId;
        private string _providerName;
        private string _imageFilename;
        private string _providerDescription;

        public ProviderBL(Provider provider)
        {
            string lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var translate = provider.ProviderTranslates.Where(p => p.Language.LanguageCode == lang).SingleOrDefault();

            _providerId = provider.ProviderId;
            _providerName = translate.ProviderName;
            _providerDescription = translate.ProviderDescription;
            _imageFilename = provider.ImageFilename;
        }

        public ProviderDTO GetDTO()
        {
            return new ProviderDTO()
            {
                ProviderId = _providerId,
                ProviderName = _providerName,
                ProviderDescription = _providerDescription,
                ImageFilename = _imageFilename
            };
        }
    }
}
