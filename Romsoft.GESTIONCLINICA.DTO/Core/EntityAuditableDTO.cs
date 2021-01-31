using System;

namespace Romsoft.GESTIONCLINICA.DTO.Core
{
    public class EntityAuditableDTO
    {
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public string UsuarioModificacion { get; set; }

        public int IdUsuarioActual { get; set; }
    }
}
