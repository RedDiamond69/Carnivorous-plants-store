using OnlineStore.DataProvider.Repositories;
using OnlineStore.DataProvider.Interfaces;
using OnlineStore.DataProvider.Context;
using OnlineStore.DataProvider.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using OnlineStore.DataProvider.Entities;
using System;

namespace OnlineStore.DataProvider
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        private AlbumRepository _albums;
        private AlbumImageRepository _albumImages;
        private ApplicationUserManager _users;
        private ApplicationUserRoleManager _userRoles;
        private ApplicationUserProfileRepository _applicationUserProfiles;
        private ArticleRepository _articles;
        private CategoryRepository _categories;
        private CustomerRepository _customers;
        private DeliveryInformationRepository _deliveryInformation;
        private DeliveryTypeRepository _deliveryTypes;
        private DimensionRepository _dimensions;
        private ManagerRepository _managers;
        private OrderRepository _orders;
        private OrderItemRepository _orderItems;
        private OrderStatusRepository _orderStatuses;
        private PaymentRepository _payments;
        private PaymentMethodRepository _paymentMethods;
        private ProductRepository _products;
        private ProductImageRepository _productImages;
        private ProductParameterRepository _productParameters;
        private ProviderRepository _providers;
        private StockRepository _stocks;
        private StorageRepository _storages;

        public UnitOfWork() => _context = new ApplicationDbContext();

        public IArticleRepository Articles
        {
            get => _articles ?? (_articles = new ArticleRepository(_context));
        }

        public IApplicationUserProfileRepository ApplicationUserProfiles
        {
            get => _applicationUserProfiles ?? (_applicationUserProfiles = new ApplicationUserProfileRepository(_context));
        }

        public ICategoryRepository Categories
        {
            get => _categories ?? (_categories = new CategoryRepository(_context));
        }

        public ICustomerRepository Customers
        {
            get => _customers ?? (_customers = new CustomerRepository(_context));
        }

        public IDeliveryInformationRepository DeliveryInformation
        {
            get => _deliveryInformation ?? (_deliveryInformation = new DeliveryInformationRepository(_context));
        }

        public IDeliveryTypeRepository DeliveryTypes
        {
            get => _deliveryTypes ?? (_deliveryTypes = new DeliveryTypeRepository(_context));
        }

        public IDimensionRepository Dimensions
        {
            get => _dimensions ?? (_dimensions = new DimensionRepository(_context));
        }

        public IManagerRepository Managers
        {
            get => _managers ?? (_managers = new ManagerRepository(_context));
        }

        public IOrderRepository Orders
        {
            get => _orders ?? (_orders = new OrderRepository(_context));
        }

        public IOrderItemRepository OrderItems
        {
            get => _orderItems ?? (_orderItems = new OrderItemRepository(_context));
        }

        public IOrderStatusRepository OrderStatuses
        {
            get => _orderStatuses ?? (_orderStatuses = new OrderStatusRepository(_context));
        }

        public IPaymentRepository Payments
        {
            get => _payments ?? (_payments = new PaymentRepository(_context));
        }

        public IPaymentMethodRepository PaymentMethods
        {
            get => _paymentMethods ?? (_paymentMethods = new PaymentMethodRepository(_context));
        }

        public IProductRepository Products
        {
            get => _products ?? (_products = new ProductRepository(_context));
        }

        public IProductImageRepository ProductImages
        {
            get => _productImages ?? (_productImages = new ProductImageRepository(_context));
        }

        public IProductParameterRepository ProductParameters
        {
            get => _productParameters ?? (_productParameters = new ProductParameterRepository(_context));
        }

        public IProviderRepository Providers
        {
            get => _providers ?? (_providers = new ProviderRepository(_context));
        }

        public IStockRepository Stocks
        {
            get => _stocks ?? (_stocks = new StockRepository(_context));
        }

        public IStorageRepository Storages
        {
            get => _storages ?? (_storages = new StorageRepository(_context));
        }

        public ApplicationUserManager Users
        {
            get => _users ?? (_users = new ApplicationUserManager(new UserStore<ApplicationUser>(_context)));
        }

        public ApplicationUserRoleManager UserRoles
        {
            get => _userRoles ?? (_userRoles = new ApplicationUserRoleManager(new RoleStore<ApplicationUserRole>(_context)));
        }

        public IAlbumRepository Albums
        {
            get => _albums ?? (_albums = new AlbumRepository(_context));
        }

        public IAlbumImageRepository AlbumImages
        {
            get => _albumImages ?? (_albumImages = new AlbumImageRepository(_context));
        }

        public int Complete() => _context.SaveChanges();

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
