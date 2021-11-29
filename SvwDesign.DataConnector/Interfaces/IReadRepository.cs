using Ardalis.Specification;
using SvwDesign.DataConnector.Common;

namespace SvwDesign.DataConnector.Interfaces
{
    public interface IReadRepository<T, TId> : IReadRepositoryBase<T> where T : BaseEntity<TId>, IAggregateRoot
    { 
    }
}
