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
    public class ShopContactBL
    {
        private string _shopContactId;
        private string _mobilePhone;
        private string _email;
        private string _workTime;
        private DateTime _modifiedDate;
        private string _location;
        private string _registration;

        public ShopContactBL(ShopContact contact)
        {
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            _shopContactId = contact.ShopContactId;
            _mobilePhone = contact.MobilePhone;
            _email = contact.Email;
            _workTime = contact.WorkTime;
            _modifiedDate = contact.ModifiedDate;

            var translate = contact.ShopContactTranslates.Select(t => t).Where(t => t.Language.LanguageCode == lang).FirstOrDefault();
            _location = translate.Location;
            _registration = translate.Registration;
        }

        public ShopContactDTO GetDTO()
        {
            return new ShopContactDTO()
            {
                ShopContactId = _shopContactId,
                Email = _email,
                Location = _location,
                MobilePhone = _mobilePhone,
                ModifiedDate = _modifiedDate,
                Registration = _registration,
                WorkTime = _workTime
            };
        }
    }
}
