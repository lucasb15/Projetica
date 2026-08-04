using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;
public class Usuario : EntidadeBase
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string SenhaHash { get; set; } = string.Empty;
    public Cargo Cargo { get; set; } = Cargo.Desenvolvedor;

    public bool EhDono { get; set; } = false; // Define se é o Administrador Master da Empresa
    public bool Ativo { get; set; } = true;

    // Relacionamento com Empresa (Tenant)
    public Empresa? Empresa { get; set; }
}