using OnlineStore.DataProvider.Identity;
using System;

namespace OnlineStore.DataProvider.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAlbumRepository Albums { get; }
        IAlbumImageRepository AlbumImages { get; }
        IApplicationUserProfileRepository ApplicationUserProfiles { get; }
        ApplicationUserManager Users { get; }
        ApplicationUserRoleManager UserRoles { get; }
        IArticleRepository Articles { get; }
        ICategoryRepository Categories{ get; }
        ICustomerRepository Customers { get; }
        IDeliveryInformationRepository DeliveryInformation { get; }
        IDeliveryTypeRepository DeliveryTypes { get; }
        IDimensionRepository Dimensions { get; }
        IManagerRepository Managers { get; }
        IOrderRepository Orders { get; }
        IOrderItemRepository OrderItems { get; }
        IOrderStatusRepository OrderStatuses { get; }
        IPaymentRepository Payments { get; }
        IPaymentMethodRepository PaymentMethods { get; }
        IProductRepository Products { get; }
        IProductImageRepository ProductImages { get; }
        IProductParameterRepository ProductParameters { get; }
        IProviderRepository Providers { get; }
        IStockRepository Stocks { get; }
        IStorageRepository Storages { get; }

        int Complete();
    }
}
