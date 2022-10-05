﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_post.Models;

public class Pizza
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Name { get; set; }
    [Column(TypeName = "text")]
    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Image { get; set; }
    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public decimal Price { get; set; }
}