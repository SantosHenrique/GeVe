using MediatR;

namespace HFS.Geve.Application.Commands.Apartamento
{
    public sealed record CreateApartamentoCommand : IRequest<CreateApartamentoCommand>
    {
        public int Numero { get; init; }
        public Guid ResponsavelId { get; init; }
        public string? Bloco { get; init; }
    }
}
