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
        #region Fields

        private readonly ApplicationDbContext _context;

        private AdministratorRepository _administrators;
        private AlbumRepository _albums;
        private AlbumTranslateRepository _albumTranslates;
        private AlbumImageRepository _albumImages;
        private AlbumImageTranslateRepository _albumImageTranslates;
        private ApplicationUserManager _users;
        private ApplicationUserRoleManager _userRoles;
        private ApplicationUserProfileRepository _applicationUserProfiles;
        private ArticleRepository _articles;
        private ArticleTranslateRepository _articleTranslates;
        private CategoryRepository _categories;
        private CategoryTranslateRepository _categoryTranslates;
        private CustomerRepository _customers;
        private DeliveryInformationRepository _deliveryInformation;
        private DeliveryTypeRepository _deliveryTypes;
        private DeliveryTypeTranslateRepository _deliveryTypeTranslates;
        private DimensionRepository _dimensions;
        private DimensionTranslateRepository _dimensionTranslates;
        private ExchangeRateRepository _exchangeRates;
        private LanguageRepository _languages;
        private ManagerRepository _managers;
        private OrderRepository _orders;
        private OrderItemRepository _orderItems;
        private OrderStatusRepository _orderStatuses;
        private OrderStatusTranslateRepository _orderStatusTranslates;
        private OwnerRepository _owners;
        private PaymentRepository _payments;
        private PaymentMethodRepository _paymentMethods;
        private PaymentMethodTranslateRepository _paymentMethodTranslates;
        private ProductRepository _products;
        private ProductTranslateRepository _productTranslates;
        private ProductInformationRepository _productInformation;
        private ProductInformationTranslateRepository _productInformationTranslates;
        private ProductImageRepository _productImages;
        private ProductParameterRepository _productParameters;
        private ProductParameterTranslateRepository _productParameterTranslates;
        private ProviderRepository _providers;
        private ProviderTranslateRepository _providerTranslates;
        private StockRepository _stocks;
        private StockTranslateRepository _stockTranslates;
        private StorageRepository _storages;

        #endregion

        #region Constructors

        public UnitOfWork() => _context = new ApplicationDbContext();

        #endregion

        #region Properties

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

        public IProductInformationRepository ProductInformation
        {
            get => _productInformation ?? (_productInformation = new ProductInformationRepository(_context));
        }

        public IAlbumTranslateRepository AlbumTranslates
        {
            get => _albumTranslates ?? (_albumTranslates = new AlbumTranslateRepository(_context));
        }

        public IAlbumImageTranslateRepository AlbumImageTranslates
        {
            get => _albumImageTranslates ?? (_albumImageTranslates = new AlbumImageTranslateRepository(_context));
        }

        public IAdministratorRepository Administrators
        {
            get => _administrators ?? (_administrators = new AdministratorRepository(_context));
        }

        public IArticleTranslateRepository ArticleTranslates
        {
            get => _articleTranslates ?? (_articleTranslates = new ArticleTranslateRepository(_context));
        }

        public ICategoryTranslateRepository CategoryTranslates
        {
            get => _categoryTranslates ?? (_categoryTranslates = new CategoryTranslateRepository(_context));
        }

        public IDeliveryTypeTranslateRepository DeliveryTypeTranslates
        {
            get => _deliveryTypeTranslates ?? (_deliveryTypeTranslates = new DeliveryTypeTranslateRepository(_context));
        }

        public IDimensionTranslateRepository DimensionTranslates
        {
            get => _dimensionTranslates ?? (_dimensionTranslates = new DimensionTranslateRepository(_context));
        }

        public IExchangeRateRepository ExchangeRates
        {
            get => _exchangeRates ?? (_exchangeRates = new ExchangeRateRepository(_context));
        }

        public ILanguageRepository Languages
        {
            get => _languages ?? (_languages = new LanguageRepository(_context));
        }

        public IOwnerRepository Owners
        {
            get => _owners ?? (_owners = new OwnerRepository(_context));
        }

        public IOrderStatusTranslateRepository OrderStatusTranslates
        {
            get => _orderStatusTranslates ?? (_orderStatusTranslates = new OrderStatusTranslateRepository(_context));
        }

        public IPaymentMethodTranslateRepository PaymentMethodTranslates
        {
            get => _paymentMethodTranslates ?? (_paymentMethodTranslates = new PaymentMethodTranslateRepository(_context));
        }

        public IProductTranslateRepository ProductTranslates
        {
            get => _productTranslates ?? (_productTranslates = new ProductTranslateRepository(_context));
        }

        public IProductInformationTranslateRepository ProductInformationTranslates
        {
            get => _productInformationTranslates ?? (_productInformationTranslates = new ProductInformationTranslateRepository(_context));
        }

        public IProductParameterTranslateRepository ProductParameterTranslates
        {
            get => _productParameterTranslates ?? (_productParameterTranslates = new ProductParameterTranslateRepository(_context));
        }

        public IProviderTranslateRepository ProviderTranslates
        {
            get => _providerTranslates ?? (_providerTranslates = new ProviderTranslateRepository(_context));
        }

        public IStockTranslateRepository StockTranslates
        {
            get => _stockTranslates ?? (_stockTranslates = new StockTranslateRepository(_context));
        }

        #endregion

        #region Methods

        public int Complete() => _context.SaveChanges();

        #endregion

        #region IDisposable

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

        #endregion
    }
}
