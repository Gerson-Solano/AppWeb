using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace AppWebPractica.Models
{
    //Modificado
    public class Empleados
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre completo por favor")]
        [StringLength(100)]
        [DisplayName("Nombre Completo")]
        public String NombreCompleto { get; set; }
        [Required(ErrorMessage = "debe ingresar el correo electronico")]
        [StringLength(30)]
        [DisplayName("Email")]
        public String Correo { get; set; }
        [Required(ErrorMessage = "No se permite el teléfono en valida")]
        [StringLength(20)]
        [DisplayName("Teléfono")]
        public String Telefono { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        [DisplayName("Fecha Registro")]
        [DataType(DataType.Date)]
        public DateTime FechaRegistro { get; set; }
        public char Estado { get; set; }
    }
}
