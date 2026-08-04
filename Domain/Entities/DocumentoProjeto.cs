using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class DocumentoProjeto : EntidadeBase
{
    public string Titulo { get; set; } = string.Empty; // ex: "Termo de Entrega Fase 1 - Redesign Web"


    // Minuta final gerada em HTML com todas as tags dinâmicas preenchidas
    public string ConteudoHtmlFinal { get; set; } = string.Empty;

    public TipoDocumento Tipo { get; set; } = TipoDocumento.EntregaFase;
    public StatusDocumento Status { get; set; } = StatusDocumento.Rascunho;
    public int Versao { get; set; } = 1;

    // Relacionamento com o Projeto
    public Guid ProjetoId { get; set; }
    public Projeto? Projeto { get; set; }

    // Relacionamento com o Modelo de Origem (opcional, para rastrear de qual template nasceu)
    public Guid? ModeloDocumentoId { get; set; }
    public ModeloDocumento? ModeloDocumento { get; set; }

    // ----- HISTÓRICO E AUDITORIA DE ENVIO E ACEITE -----
    public DateTime? EnviadoEm { get; set; }
    public string? EnviadoParaEmail { get; set; } // E-mail do cliente para o qual foi enviado

    // Token GUID público gerado para o link seguro de aceite (ex: /validar-termo?token=abc-123)
    public string? TokenAceitePublico { get; set; }
    public DateTime? TokenValidoAte { get; set; }

    // Dados de quem assinou / aceitou
    public DateTime? AssinadoEm { get; set; }
    public string? NomeAssinante { get; set; }
    public string? EmailAssinante { get; set; }
    public string? CpfAssinante { get; set; } // CPF ou CNPJ do cliente que assinou
    public string? IpAssinatura { get; set; } // Endereço IP registrado no aceite (auditoria)

    // Lista de Anexos (PDF original gerado + PDF assinado no Drive)
    public ICollection<AnexoDocumento> Anexos { get; set; } = new List<AnexoDocumento>();
}