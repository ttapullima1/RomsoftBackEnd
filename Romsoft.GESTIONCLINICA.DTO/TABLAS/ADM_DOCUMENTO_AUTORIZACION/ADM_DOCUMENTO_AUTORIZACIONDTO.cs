using Romsoft.GESTIONCLINICA.DTO.Core;
using System;

namespace Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_DOCUMENTO_AUTORIZACION
{
    public class ADM_DOCUMENTO_AUTORIZACIONDTO : EntityAuditableDTO
    {
        public int id_documento_identidad { get; set; }
        public string c_cod_autorizacion { get; set; }
        public string c_cod_asegurado { get; set; }
        public string c_nro_autorizacion { get; set; }
        public string c_fecha_autorizacion { get; set; }
        public string c_fecha_i_vigencia { get; set; }
        public string c_fecha_nacimiento { get; set; }
        public string c_tipo_afiliacion { get; set; }
        public string t_p_apellido_paterno { get; set; }
        public string t_p_apellido_materno { get; set; }
        public string t_p_nombre_completo { get; set; }
        public string t_t_apellido_paterno { get; set; }
        public string t_t_apellido_materno { get; set; }
        public string t_t_nombre_completo { get; set; }
        public string c_parentesco { get; set; }
        public string c_producto_plan { get; set; }
        public string c_cod_beneficio { get; set; }
        public string c_nro_contrato { get; set; }
        public string c_ruc_iafa { get; set; }
        public string c_cod_iafa { get; set; }
        public string c_cod_contrantate { get; set; }
        public string t_contratante { get; set; }
        public decimal n_copago_fijo { get; set; }
        public decimal n_copago_variable { get; set; }
        public decimal n_copago_variable_far { get; set; }
        public int f_estado { get; set; }
        //public DateTime d_fecha_registro { get; set; }
        //public DateTime d_fecha_modifica { get; set; }
        //public int id_user_registro { get; set; }
        //public int id_user_modifica { get; set; }
        public string valor { get; set; }
    }
}