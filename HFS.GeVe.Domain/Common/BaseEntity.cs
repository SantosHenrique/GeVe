
namespace HFS.GeVe.Domain.Common
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }

        protected Guid Id { get; init; }
        public bool Ativo { get; init; }
    }
}
