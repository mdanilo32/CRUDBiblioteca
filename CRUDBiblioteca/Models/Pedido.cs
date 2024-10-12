using System;
using System.ComponentModel.DataAnnotations;

public class Pedido
{
    [Key]  // Asegúrate de agregar este atributo
    public int PedidoId { get; set; }

    [Required(ErrorMessage = "La Descripción es obligatoria.")]
    public string Descripcion { get; set; }

    [Required(ErrorMessage = "La Fecha del Pedido es obligatoria.")]
    [DataType(DataType.Date, ErrorMessage = "La Fecha del Pedido debe ser una fecha válida.")]
    public DateTime FechaPedido { get; set; }
}
