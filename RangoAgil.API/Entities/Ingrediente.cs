﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace RangoAgil.API.Entities;

public class Ingrediente
{
    //Classe criada com duas exeções
    //Decorador
    [Key]
    public int Id { get; set; }


    [Required]
    [MaxLength(100)]
    public required string Nome { get; set; }


    public ICollection<Rango> Rangos { get; set; } = [];


    public Ingrediente()
    {
            
    }

    [SetsRequiredMembers]
    public Ingrediente(int id, string nome )
    {
        Id = id; 
        Nome = nome;
    }

    }

