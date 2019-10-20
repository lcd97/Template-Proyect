using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XalliHotel.Models 
{
    [Table("Productos",Schema = "Inv")]
    public partial class Producto 
    {
        //CONSTRUCTOR CLASE HIJA
        public Producto() {
            //this.UnidadDeMedida = new HashSet<DetalleDeSalida>();
            this.DetallesDeEntrada = new HashSet<DetalleDeEntrada>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(5,MinimumLength = 5,ErrorMessage = "La cantidad de dígitos debe ser de 5")]
        [Display(Name = "Código")]
        public string codProd { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(80,ErrorMessage = "Límite excedido")]
        [Display(Name = "Código")]
        public string nombProd { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1, (double)decimal.MaxValue, ErrorMessage = "El precio debe ser mayor a 0")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "(0:c2)")]
        [Display(Name = "Código")]
        public double precioProd { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(5,int.MaxValue, ErrorMessage = "La cantidad de dígitos debe ser de 5")]
        [Display(Name = "Cantidad")]
        public int cantProd { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado")]
        public bool estadoProd { get; set; }

        //DEFINICION DE FOREIGN KEY
        public int unidadMedidaId { get; set; }

        public int categoriaId { get; set; }

        //RELACION HIJO
        public virtual ICollection<DetalleDeEntrada> DetallesDeEntrada { get; set; }
        //public virtual ICollection<DetalleDeSalida> DetallesDeSalida { get; set; }

        //RELACION PADRE
        public virtual UnidadDeMedida UnidadDeMedida { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}