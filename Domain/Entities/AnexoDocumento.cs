using Domain.Common;

namespace Domain.Entities;

public class AnexoDocumento : EntidadeBase
{
    public string NomeArquivo { get; set; } = string.Empty; // ex: "Termo_Fase1_Assinado.pdf"

    // ID retornado pela API do Google Drive ao salvar o arquivo
    public string IdDriveExterno { get; set; } = string.Empty;

    // Caminho da pasta no Drive (ex: "/Clientes/Padaria/Projetos/Site/Assinados/")
    public string CaminhoPastaDrive { get; set; } = string.Empty;

    // Define se é a minuta inicial em PDF ou o documento com assinatura digital/manual re-enviado
    public bool EhVersaoAssinada { get; set; } = false;

    public string TipoMime { get; set; } = "application/pdf";
    public long TamanhoEmBytes { get; set; }

    // Relacionamento com o Documento
    public Guid DocumentoProjetoId { get; set; }
    public DocumentoProjeto? DocumentoProjeto { get; set; }
}