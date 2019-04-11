using OnlineStore.DataProvider.Entities;
using OnlineStore.DataProvider.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Product> ProductRepository { get; }
        IGenericRepository<ProductImage> ProductImageRepository { get; }
        IGenericRepository<ProductParameter> ProductParameterRepository { get; }
        IGenericRepository<Article> ArticleRepository { get; }
        IGenericRepository<ArticleImage> ArticleImageRepository { get; }
        IGenericRepository<Category> CategoryRepository { get; }
        IGenericRepository<Customer> CustomerRepository { get; }
        IGenericRepository<DeliveryInformation> DeliveryInformationRepository { get; }
        IGenericRepository<DeliveryType> DeliveryTypeRepository { get; }
        IGenericRepository<Dimension> DimensionRepository { get; }
        IGenericRepository<Manager> ManagerRepository { get; }
        IGenericRepository<Order> OrderRepository { get; }
        IGenericRepository<OrderItem> OrderItemRepository { get; }
        IGenericRepository<OrderStatus> OrderStatusRepository { get; }
        IGenericRepository<Payment> PaymentRepository { get; }
        IGenericRepository<PaymentMethod> PaymentMethodRepository { get; }
        IGenericRepository<Provider> ProviderRepository { get; }
        IGenericRepository<Stock> StockRepository { get; }
        IGenericRepository<Storage> StorageRepository { get; }

        void Save();
    }
}
