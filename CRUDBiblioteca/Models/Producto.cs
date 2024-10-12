using System.ComponentModel.DataAnnotations;

public class Producto
{
    [Key]  // Asegúrate de agregar este atributo
    public int ProductId { get; set; }

    [Required]
    [StringLength(100)]
    public string Nombre { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser positivo.")]
    public decimal Precio { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor o igual a 0.")]
    public int Cantidad { get; set; }
}
