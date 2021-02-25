using Romsoft.GESTIONCLINICA.Entidades.Core;
using System;

namespace Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_IDENTIDAD
{
    public class ADM_DOCUMENTO_IDENTIDAD : EntityAuditable
    {
        public int id_documento_identidad { get; set; }
		public string c_codigo { get; set; }
		public string t_descripcion { get; set; }
    }
}
