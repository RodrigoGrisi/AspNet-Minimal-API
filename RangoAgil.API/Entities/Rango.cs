using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entities;

public class Rango
{
    //CLASSE CRIADA COM DUAS EXCEÇÕ
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public required string Nome { get; set; }


    public ICollection<Ingrediente> Ingredientes { get; set; }

    public Rango()
    {
            
    }

    [SetsRequiredMembers]
    public Rango(int id, string nome )
    {
        Id = id; 
        Nome = nome;
    }

}

