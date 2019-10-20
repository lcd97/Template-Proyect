using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XalliHotel.Models 
{
    [Table("Categorias", Schema = "Inv")]
    public partial class Categoria 
    {
        //CONSTRUCTOR CLASE HIJO
        public Categoria() {
            this.Productos = new HashSet<Producto>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(5,MinimumLength = 5,ErrorMessage = "La cantidad de dígitos debe ser de 5")]
        [Display(Name = "Código")]
        public string codCat { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50,ErrorMessage = "Límite excedido")]
        [Display(Name = "Descripción")]
        public string descCat { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado")]
        public bool estadoCat { get; set; }

        //RELACION HIJA
        public virtual ICollection<Producto> Productos { get; set; }
    }
}