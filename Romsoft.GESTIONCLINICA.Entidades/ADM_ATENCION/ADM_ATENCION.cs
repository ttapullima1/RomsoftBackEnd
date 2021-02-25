using Romsoft.GESTIONCLINICA.Entidades.Core;
using System;
namespace Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION
{
    public class ADM_ATENCION : EntityAuditable
    {
        public long id_nro_interno {get;set;}
        public int id_paciente { get; set; }
        public int id_calificacion { get; set; }
        public int id_tipo_paciente { get; set; }
        public int id_tipo_atencion { get; set; }
        public DateTime d_fecha_ingreso { get; set; }
        public string c_hora_ingreso { get; set; }
        public int id_plan_seguro { get; set; }
        public int id_beneficio { get; set; }
        public int id_atencion_autoriza { get; set; }
        public string t_nombre_titular { get; set; }
        public int id_parentesco { get; set; }
        public int id_atencion_diagnostico { get; set; }
        public int id_atencion_cita { get; set; }
        public int id_medico { get; set; }
        public int id_atencion_hospitaliza { get; set; }
        public int id_tipo_egreso { get; set; }
        public DateTime d_fecha_egreso { get; set; }
        public string c_hora_egreso { get; set; }
        public DateTime d_fecha_cierre { get; set; }
        public string c_hora_cierre { get; set; }
        public string t_observacion { get; set; }
        public decimal n_a_no_gravado { get; set; }
        public decimal n_a_gravado { get; set; }
        public decimal n_a_impuesto { get; set; }
        public decimal n_a_total { get; set; }
        public decimal n_p_no_gravado { get; set; }
        public decimal n_p_gravado { get; set; }
        public decimal n_p_impuesto { get; set; }
        public decimal n_p_total { get; set; }
        public decimal n_g_no_gravado { get; set; }
        public decimal n_g_gravado { get; set; }
        public decimal n_g_impuesto { get; set; }
        public decimal n_g_total { get; set; }
        public int f_estado { get; set; }

        //Request
        public DateTime d_fecha_registro_1 { get; set; }
        public DateTime d_fecha_registro_2 { get; set; }
        //Response
        public string  tipo_paciente { get; set; }
        public string tipo_atencion { get; set; }
        public string garante { get; set; }
        public string contratante { get; set; }
        public string estado { get; set; }
    }
}
