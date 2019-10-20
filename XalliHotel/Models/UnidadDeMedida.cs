using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XalliHotel.Models 
{ 
    [Table("UnidadesDeMedida", Schema = "Inv")]
    public partial class UnidadDeMedida 
    {
        //CONSTRUCTOR CLASE HIJA
        public UnidadDeMedida() {
            this.Producto = new HashSet<Producto>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(5,MinimumLength = 5,ErrorMessage = "La cantidad de dígitos debe ser de 5")]
        [Display(Name = "Código")]
        public string codUM { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50,ErrorMessage = "Límite excedido")]
        [Display(Name = "Descripción")]
        public string descUM { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1,int.MaxValue,ErrorMessage = "La cantidad debe ser mayor a 0")]
        [Display(Name = "Cantidad Unidad de Medida")]
        public int cantUM { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1,int.MaxValue,ErrorMessage = "La cantidad debe ser mayor a 0")]
        [Display(Name = "Cantidad Unidad")]
        public int cantUnidad { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50,ErrorMessage = "Límite excedido")]
        [Display(Name = "Presentación")]
        public string presentacion { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado")]
        public bool estadoUM { get; set; }

        //REELACION HIJA
        public virtual ICollection<Producto> Producto { get; set; }
    }
}