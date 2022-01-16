using Ardalis.Specification;

namespace CleanArchitectureTemplate.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
