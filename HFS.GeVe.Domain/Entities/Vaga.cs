using HFS.GeVe.Domain.Common;

namespace HFS.GeVe.Domain.Entities;

public class Vaga : BaseEntity
{
    public Guid ApartamentoId { get; init; }
    public decimal? ValorHora { get; init; }
}
