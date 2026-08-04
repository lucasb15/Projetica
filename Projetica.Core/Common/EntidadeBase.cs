namespace Domain.Common;
public abstract class EntidadeBase : ITenantComum
{
    public Guid Id { get; set; } = Guid.NewGuid();

    // Identificador da Empresa proprietária
    public Guid TenantId { get; set; }

    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;
    public DateTime? AtualizadoEm { get; set; }
}