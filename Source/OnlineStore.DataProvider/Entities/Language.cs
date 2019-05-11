using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class Language
    {
        [Key]
        public string LanguageId { get; set; }

        [Required(ErrorMessage = "Language code is required."), MaxLength(2, ErrorMessage = "Code length cannot be more than 2.")]
        public string LanguageCode { get; set; }

        [Required(ErrorMessage = "Language name is required."), MaxLength(50, ErrorMessage = "Name length cannot be more than 50.")]
        public string LanguageName { get; set; }

        [Required(ErrorMessage = "Image filename is required."), MaxLength(250, ErrorMessage = "Filename length cannot be more than 250.")]
        public string ImageFilename { get; set; }

        public virtual ICollection<ArticleTranslate> ArticleTranslates { get; set; }
        public virtual ICollection<AlbumTranslate> AlbumTranslates { get; set; }
        public virtual ICollection<AlbumImageTranslate> AlbumImageTranslates { get; set; }
        public virtual ICollection<CategoryTranslate> CategoryTranslates { get; set; }
        public virtual ICollection<DeliveryTypeTranslate> DeliveryTypeTranslates { get; set; }
        public virtual ICollection<DimensionTranslate> DimensionTranslates { get; set; }
        public virtual ICollection<OrderStatusTranslate> OrderStatusTranslates { get; set; }
        public virtual ICollection<PaymentMethodTranslate> PaymentMethodTranslates { get; set; }
        public virtual ICollection<ProductTranslate> ProductTranslates { get; set; }
        public virtual ICollection<ProductParameterTranslate> ProductParameterTranslates { get; set; }
        public virtual ICollection<ProviderTranslate> ProviderTranslates { get; set; }
        public virtual ICollection<StockTranslate> StockTranslates { get; set; }

        public Language()
        {
            LanguageId = Guid.NewGuid().ToString();
            ArticleTranslates = new List<ArticleTranslate>();
            AlbumTranslates = new List<AlbumTranslate>();
            AlbumImageTranslates = new List<AlbumImageTranslate>();
            CategoryTranslates = new List<CategoryTranslate>();
            DeliveryTypeTranslates = new List<DeliveryTypeTranslate>();
            DimensionTranslates = new List<DimensionTranslate>();
            OrderStatusTranslates = new List<OrderStatusTranslate>();
            PaymentMethodTranslates = new List<PaymentMethodTranslate>();
            ProductTranslates = new List<ProductTranslate>();
            ProductParameterTranslates = new List<ProductParameterTranslate>();
            ProviderTranslates = new List<ProviderTranslate>();
            StockTranslates = new List<StockTranslate>();
        }
    }
}
