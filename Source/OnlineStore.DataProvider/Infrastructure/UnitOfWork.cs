using OnlineStore.DataProvider.Entities;
using OnlineStore.DataProvider.Infrastructure;
using OnlineStore.DataProvider.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private GenericRepository<Product> _productRepository;
        private GenericRepository<ProductImage> _productImageRepository;
        private GenericRepository<ProductParameter> _productParameterRepository;
        private GenericRepository<Article> _articleRepository;
        private GenericRepository<ArticleImage> _articleImageRepository;
        private GenericRepository<Category> _categoryRepository;
        private GenericRepository<Customer> _customerRepository;
        private GenericRepository<DeliveryInformation> _deliveryInformationRepository;
        private GenericRepository<DeliveryType> _deliveryTypeRepository;
        private GenericRepository<Dimension> _dimensionRepository;
        private GenericRepository<Manager> _managerRepository;
        private GenericRepository<Order> _orderRepository;
        private GenericRepository<OrderItem> _orderItemRepository;
        private GenericRepository<OrderStatus> _orderStatusRepository;
        private GenericRepository<Payment> _paymentRepository;
        private GenericRepository<PaymentMethod> _paymentMethodRepository;
        private GenericRepository<Provider> _providerRepository;
        private GenericRepository<Stock> _stockRepository;
        private GenericRepository<Storage> _storageRepository;

        public UnitOfWork()
        {
            _applicationDbContext = new ApplicationDbContext();
        }

        public IGenericRepository<Product> ProductRepository
        {
            get => _productRepository ?? (_productRepository = new GenericRepository<Product>(_applicationDbContext));
        }

        public IGenericRepository<ProductImage> ProductImageRepository
        {
            get => _productImageRepository ?? (_productImageRepository = new GenericRepository<ProductImage>(_applicationDbContext));
        }

        public IGenericRepository<Article> ArticleRepository
        {
            get => _articleRepository ?? (_articleRepository = new GenericRepository<Article>(_applicationDbContext));
        }

        public IGenericRepository<ArticleImage> ArticleImageRepository
        {
            get => _articleImageRepository ?? (_articleImageRepository = new GenericRepository<ArticleImage>(_applicationDbContext));
        }

        public IGenericRepository<Category> CategoryRepository
        {
            get => _categoryRepository ?? (_categoryRepository = new GenericRepository<Category>(_applicationDbContext));
        }

        public IGenericRepository<Customer> CustomerRepository
        {
            get => _customerRepository ?? (_customerRepository = new GenericRepository<Customer>(_applicationDbContext));
        }

        public IGenericRepository<DeliveryInformation> DeliveryInformationRepository
        {
            get => _deliveryInformationRepository ?? (_deliveryInformationRepository =
                new GenericRepository<DeliveryInformation>(_applicationDbContext));
        }

        public IGenericRepository<DeliveryType> DeliveryTypeRepository
        {
            get => _deliveryTypeRepository ?? (_deliveryTypeRepository = new GenericRepository<DeliveryType>(_applicationDbContext));
        }

        public IGenericRepository<Dimension> DimensionRepository
        {
            get => _dimensionRepository ?? (_dimensionRepository = new GenericRepository<Dimension>(_applicationDbContext));
        }

        public IGenericRepository<Manager> ManagerRepository
        {
            get => _managerRepository ?? (_managerRepository = new GenericRepository<Manager>(_applicationDbContext));
        }

        public IGenericRepository<Order> OrderRepository
        {
            get => _orderRepository ?? (_orderRepository = new GenericRepository<Order>(_applicationDbContext));
        }

        public IGenericRepository<OrderItem> OrderItemRepository
        {
            get => _orderItemRepository ?? (_orderItemRepository = new GenericRepository<OrderItem>(_applicationDbContext));
        }

        public IGenericRepository<OrderStatus> OrderStatusRepository
        {
            get => _orderStatusRepository ?? (_orderStatusRepository = new GenericRepository<OrderStatus>(_applicationDbContext));
        }

        public IGenericRepository<Payment> PaymentRepository
        {
            get => _paymentRepository ?? (_paymentRepository = new GenericRepository<Payment>(_applicationDbContext));
        }

        public IGenericRepository<PaymentMethod> PaymentMethodRepository
        {
            get => _paymentMethodRepository ?? (_paymentMethodRepository = new GenericRepository<PaymentMethod>(_applicationDbContext));
        }

        public IGenericRepository<ProductParameter> ProductParameterRepository
        {
            get => _productParameterRepository ?? (_productParameterRepository = new GenericRepository<ProductParameter>(_applicationDbContext));
        }

        public IGenericRepository<Provider> ProviderRepository
        {
            get => _providerRepository ?? (_providerRepository = new GenericRepository<Provider>(_applicationDbContext));
        }

        public IGenericRepository<Stock> StockRepository
        {
            get => _stockRepository ?? (_stockRepository = new GenericRepository<Stock>(_applicationDbContext));
        }

        public IGenericRepository<Storage> StorageRepository
        {
            get => _storageRepository ?? (_storageRepository = new GenericRepository<Storage>(_applicationDbContext));
        }

        public void Save()
        {
            _applicationDbContext.SaveChangesAsync();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _applicationDbContext.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
