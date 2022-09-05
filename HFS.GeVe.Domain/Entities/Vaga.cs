using HFS.GeVe.Domain.Common;

namespace HFS.GeVe.Domain.Entities;

public class Vaga : BaseEntity
{
    public string Codigo { get; init; } = string.Empty;
    public Guid AndarId { get; init; }
    public decimal? ValorHora { get; init; }
}
