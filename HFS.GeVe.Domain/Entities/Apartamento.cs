using HFS.GeVe.Domain.Common;

namespace HFS.GeVe.Domain.Entities
{
    public class Apartamento : BaseEntity
    {
        public int Numero { get; init; }
        public Guid ResponsavelId { get; init; }
        public string? Bloco { get; init; }
    }
}
