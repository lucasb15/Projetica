using Domain.Common;

namespace Domain.Entities;

public class Cliente : EntidadeBase
{
    // Dados Obrigatórios
    public string RazaoNome { get; set; } = string.Empty;
    public string FantasiaApelido { get; set; } = string.Empty;
    public bool IsPessoaFisica { get; set; } = true; // true = Pessoa Física, false = Pessoa Jurídica
    public string CNPJCPF { get; set; } = string.Empty; // CNPJ ou CPF

    // Dados de Contato
    public string EmailPrincipal { get; set; } = string.Empty;
    public string NumeroTelefone { get; set; } = string.Empty;

    // Dados Gerente Cliente
    public string NomeGerente { get; set; } = string.Empty;
    public string CPFGerente { get; set; } = string.Empty;
    public string EmailGerente { get; set; } = string.Empty;
    public string TelefoneGerente { get; set; } = string.Empty;
}