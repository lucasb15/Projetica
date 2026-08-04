using Domain.Enums;

namespace Domain.Entities;
public class Empresa
{
    public Guid Id { get; set; } = Guid.NewGuid(); // Identificador único da empresa

    // Dados da Empresa/Freelancer
    public string RazaoNome { get; set; } = string.Empty;
    public string FantasiaApelido { get; set; } = string.Empty;
    public string CNPJCPF { get; set; } = string.Empty; // CNPJ ou CPF
    public TipoPlano TipoPlano { get; set; } = TipoPlano.Freelancer; // TipoPlano.Freelancer ou TipoPlano.Empresa

    // E-mail Institucional para envio de termos e documentos
    public string NomeRemetenteEmail { get; set; } = string.Empty; // ex: "Projetica - Notificações" ou "Nome do Freelancer"
    public string EmailInstitucional { get; set; } = string.Empty;
    public string? SenhaEmailInstitucional { get; set; } // Senha do e-mail institucional | Salvar de forma segura (criptografada) no banco de dados
    public string? ServidorSMTP { get; set; } // Servidor SMTP do e-mail institucional
    public int? PortaSMTP { get; set; } // Porta SMTP do e-mail institucional

    // Configurações de integração com o Google Drive
    public string? IdPastaRaizDrive { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.UtcNow;

    // Uma Empresa possui vários Usuários (Funcionários/Parceiros) e vários Clientes
    public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
    public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
}