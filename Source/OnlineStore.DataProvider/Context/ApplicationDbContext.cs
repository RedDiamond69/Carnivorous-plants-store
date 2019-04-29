using Microsoft.AspNet.Identity.EntityFramework;
using OnlineStore.DataProvider.Configuration;
using OnlineStore.DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        static ApplicationDbContext() => Database.SetInitializer(new DbInitializer());

        public DbSet<Administrator> Administrators { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumTranslate> AlbumTranslates { get; set; }
        public DbSet<AlbumImage> AlbumImages { get; set; }
        public DbSet<AlbumImageTranslate> AlbumImageTranslates { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTranslate> ProductTranslates { get; set; }
        public DbSet<ProductInformation> ProductInformation { get; set; }
        public DbSet<ProductInformationTranslate> ProductInformationTranslates { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryTranslate> CategoryTranslates { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<ProviderTranslate> ProviderTranslates { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<DimensionTranslate> DimensionTranslates { get; set; }
        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductParameter> ProductParameters { get; set; }
        public DbSet<ProductParameterTranslate> ProductParameterTranslates { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockTranslate> StockTranslates { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<DeliveryInformation> DeliveryInformation { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<DeliveryType> DeliveryTypes { get; set; }
        public DbSet<DeliveryTypeTranslate> DeliveryTypeTranslates { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<OrderStatusTranslate> OrderStatusTranslates { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentMethodTranslate> PaymentMethodTranslates { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleTranslate> ArticleTranslates { get; set; }
        public DbSet<ApplicationUserProfile> ApplicationUserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
