using Ardalis.Specification;
using SvwDesign.DataConnector.Common;

namespace SvwDesign.DataConnector.Interfaces
{
    public interface IRepository<TEntity, TId>: IRepositoryBase<TEntity> where TEntity : BaseEntity<TId>, IAggregateRoot
    {
    }
} 