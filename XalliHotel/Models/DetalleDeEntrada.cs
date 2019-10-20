using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XalliHotel.Models 
{
    [Table("DetallesDeEntrada", Schema = "Inv")]
    public partial class DetalleDeEntrada 
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1,int.MaxValue,ErrorMessage = "La cantidad debe ser mayor a 0")]
        [Display(Name = "Cantidad")]
        public int cantDE { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1, (double)decimal.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "(0:c2)")]
        [Display(Name = "Precio")]
        public double precioDE { get; set; }

        //DEFINICION DE FOREIGN KEY
        public int entradaId { get; set; }

        public int productoId { get; set; }

        //RELACION PADRE
        public virtual Entrada Entrada { get; set; }
        public virtual Producto Producto { get; set; }
    }
}