using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntregableEF.Modelos
{
    public class Productos: IEntity
    {

        [Key]
        public int ProductoId { get; set; }

        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public int CategoriaId { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        public DateTime? Deleted { get; set; }

    }
}
