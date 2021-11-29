using Ardalis.Specification;

namespace SvwDesign.DataConnector.Interfaces
{
    public interface IRepository<TEntity, TId>: IRepositoryBase<TEntity> where TEntity : BaseEntity<TId>, IAggregateRoot
    {
    }
} 