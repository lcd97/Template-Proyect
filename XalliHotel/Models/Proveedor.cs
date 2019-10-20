using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XalliHotel.Models
{
    [Table ("Proveedores", Schema = "Inv")]
    public partial class Proveedor
    {
        //CONSTRUCTOR CLASE HIJA
        public Proveedor() {
            this.Entrada = new HashSet<Entrada>();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(5,MinimumLength = 5,ErrorMessage = "La cantidad de dígitos debe ser de 5")]
        [Display(Name = "Código")]
        public string codProv { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El RUC debe ser mayor a 0")]
        [Display(Name = "Número RUC")]
        public int RUC { get; set; }

        [StringLength(80, ErrorMessage = "Límite excedido")]
        [Display(Name = "Nombre Comercial")]
        public string nombComercial { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [StringLength(12, ErrorMessage = "Límite excedido")]
        [Display(Name = "Teléfono")]
        public string telProv { get; set; }

        [StringLength(50, ErrorMessage = "Límite excedido")]
        [Display(Name = "Nombres")]
        public string nomProv { get; set; }

        [StringLength(50, ErrorMessage = "Límite excedido")]
        [Display(Name = "Apellidos")]
        public string apeProv { get; set; }

        [StringLength(16, ErrorMessage = "Límite excedido")]
        [Display(Name = "Cedula")]
        public  string cedProv { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "Estado")]
        public bool estadoProv { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "¿Retención IR?")]
        public bool Retencion { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        [Display(Name = "¿Proveedor Local?")]
        public bool LocalProv { get; set; }

        //RELACION HIJA
        public virtual ICollection<Entrada> Entrada { get; set; }
    }
}