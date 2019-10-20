using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XalliHotel.Models
{
    [Table("Entradas",Schema = "Inv")]
    public partial class Entrada
    {
        //CONSTRUCTOR CLASE HIJO
        public Entrada() {
            this.DetallesDeEntrada = new HashSet<DetalleDeEntrada>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "La cantidad de dígitos debe ser de 5")]
        [Display(Name = "Código")]
        public string codEnt { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [DataType(DataType.DateTime)]
        public DateTime fechaEnt { get; set; }        

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado")]
        public bool estadoEnt { get; set; }

        //DEFINICION DE FOREIGN KEY
        public int proveedorId { get; set; }

        public int tipoEntradaId { get; set; }

        //RELACION HIJA
        public virtual ICollection<DetalleDeEntrada> DetallesDeEntrada { get; set; }

        //RELACION PADRE
        public virtual Proveedor Proveedor { get; set; }
        public virtual TipoDeEntrada TipoDeEntrada { get; set; }
    }
}