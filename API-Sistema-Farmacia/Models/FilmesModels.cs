using System.ComponentModel.DataAnnotations;

namespace API_Sistema_Farmacia.Models;

public class FilmesModels
{

    [Required]
    [Key]
    public int cod_filme { get; set; }

    [Required]
    public string nome_filme { get; set;}

    [Required]
    public string genero { get; set; }

    [Required]
    public int duracao { get; set; }

    [Required]
    public float avaliacao { get; set; }
    
    public string url_imagem { get; set; }

    public string url_video { get; set; }
    public string sinopse { get; set; }
    public string descricao { get; set; }


}

