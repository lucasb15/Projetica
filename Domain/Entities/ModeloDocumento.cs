using Domain.Common;
using Domain.Enums;

namespace Domain.Entities;

public class ModeloDocumento : EntidadeBase
{
    public string Titulo { get; set; } = string.Empty; // ex: "Modelo Padrão - Termo de Aceite de Fase"
    public string Descricao { get; set; } = string.Empty;
    public TipoDocumento Tipo { get; set; } = TipoDocumento.EntregaFase;
    public string Versao { get; set; } = "1.0"; // ex: "1.0", "2.0"

    // Conteúdo HTML do modelo contendo os placeholders (ex: {{NomeCliente}}, {{NomeProjeto}}, {{ValorTotal}})
    public string ConteudoHtmlModelo { get; set; } = string.Empty;

    public bool Ativo { get; set; } = true;
}
