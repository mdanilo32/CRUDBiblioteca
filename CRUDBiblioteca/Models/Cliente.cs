using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]  // Asegúrate de agregar este atributo
    public int ClienteId { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "El Nombre debe tener entre 3 y 100 caracteres.")]
    public string Nombre { get; set; }

    [Required]
    [EmailAddress]
    public string CorreoElectronico { get; set; }

    [Required]
    [StringLength(8, MinimumLength = 8)]
    public string Telefono { get; set; }
}
