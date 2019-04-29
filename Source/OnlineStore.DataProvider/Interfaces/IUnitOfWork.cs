using OnlineStore.DataProvider.Identity;
using System;

namespace OnlineStore.DataProvider.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository Albums { get; }
        IAlbumTranslateRepository AlbumTranslates { get; }
        IAlbumImageRepository AlbumImages { get; }
        IAlbumImageTranslateRepository AlbumImageTranslates { get; }
        IAdministratorRepository Administrators { get; }
        IApplicationUserProfileRepository ApplicationUserProfiles { get; }
        ApplicationUserManager Users { get; }
        ApplicationUserRoleManager UserRoles { get; }
        IArticleRepository Articles { get; }
        IArticleTranslateRepository ArticleTranslates { get; }
        ICategoryRepository Categories{ get; }
        ICategoryTranslateRepository CategoryTranslates { get; }
        ICustomerRepository Customers { get; }
        IDeliveryInformationRepository DeliveryInformation { get; }
        IDeliveryTypeRepository DeliveryTypes { get; }
        IDeliveryTypeTranslateRepository DeliveryTypeTranslates { get; }
        IDimensionRepository Dimensions { get; }
        IDimensionTranslateRepository DimensionTranslates { get; }
        IExchangeRateRepository ExchangeRates { get; }
        ILanguageRepository Languages { get; }
        IManagerRepository Managers { get; }
        IOwnerRepository Owners { get; }
        IOrderRepository Orders { get; }
        IOrderItemRepository OrderItems { get; }
        IOrderStatusRepository OrderStatuses { get; }
        IOrderStatusTranslateRepository OrderStatusTranslates { get; }
        IPaymentRepository Payments { get; }
        IPaymentMethodRepository PaymentMethods { get; }
        IPaymentMethodTranslateRepository PaymentMethodTranslates { get; }
        IProductRepository Products { get; }
        IProductTranslateRepository ProductTranslates { get; }
        IProductInformationRepository ProductInformation { get; }
        IProductInformationTranslateRepository ProductInformationTranslates { get; }
        IProductImageRepository ProductImages { get; }
        IProductParameterRepository ProductParameters { get; }
        IProductParameterTranslateRepository ProductParameterTranslates { get; }
        IProviderRepository Providers { get; }
        IProviderTranslateRepository ProviderTranslates { get; }
        IStockRepository Stocks { get; }
        IStockTranslateRepository StockTranslates { get; }
        IStorageRepository Storages { get; }

        int Complete();
    }
}
