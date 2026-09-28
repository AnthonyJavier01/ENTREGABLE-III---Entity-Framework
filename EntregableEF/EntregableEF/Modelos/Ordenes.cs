using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntregableEF.Modelos
{
    public class Ordenes: IEntity
    {

        [Key]
        public int OrdenId { get; set; }

        public int ClienteId { get; set; }

        public DateTime FechaOrden { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Total { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Updated { get; set; }

        public DateTime? Deleted { get; set; }
  
}
}
