using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class Projeto : EntidadeBase
{
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;
    public decimal ValorTotalEstimado { get; set; } // ex: 200000.00
    public decimal HorasEstimadas { get; set; } // ex: 150.00
    public StatusProjeto StatusProjeto { get; set; } = StatusProjeto.Novo;

    // Datas do projeto
    public DateTime DataInicio { get; set; } = DateTime.UtcNow;
    public DateTime? PrevisaoTermino { get; set; }

    // Relacionamento com Cliente
    public Guid ClienteId { get; set; }
    public Cliente? Cliente { get; set; }

    // Documentos/Termos vinculados a este projeto
    public ICollection<DocumentoProjeto> Documentos { get; set; } = new List<DocumentoProjeto>();
}