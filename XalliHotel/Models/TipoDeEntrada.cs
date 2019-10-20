using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XalliHotel.Models 
{
    [Table("TiposDeEntrada", Schema = "Inv")]
    public partial class TipoDeEntrada 
    {
        //CONSTRUCTOR CLASE TIPO DE ENTRADA
        public TipoDeEntrada() {
            this.Entrada = new HashSet<Entrada>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(5,MinimumLength = 5,ErrorMessage = "La cantidad de dígitos debe ser de 5")]
        [Display(Name = "Código")]
        public string codTE { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "Límite excedido")]
        [Display(Name = "Descripción")]
        public string descTE { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado")]
        public bool estadoTE { get; set; }

        //RELACION HIJA
        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}