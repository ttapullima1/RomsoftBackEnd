using System;
using System.Collections.Generic;
using Romsoft.GESTIONCLINICA.Entidades.Core;


namespace Romsoft.GESTIONCLINICA.Entidades.ADM_GENERO
{
    public class ADM_GENERO : EntityAuditable
    {
        public int id_genero { get; set; }
		public string c_codigo { get; set; }
		public string t_descripcion { get; set; }

    }
}
