namespace Domain.Common;
public interface ITenantComum
{
    // TenantId é o Id da Empresa dona do dado
    public Guid TenantId { get; set; }
}