using System;
using System.Collections.Generic;
using System.Text;

namespace EntregableEF.Modelos
{
   public interface IEntity
    {
        DateTime Created { get; set; }

        DateTime? Updated { get; set; }

        DateTime? Deleted { get; set; }
    }
}
