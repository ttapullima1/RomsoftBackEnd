using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romsoft.GESTIONCLINICA.Presentacion.Core
{
    public class ComunFilter
    {
        // Para realizar fitros
        //-- Usuarios
        public static int f_usuario_IdTipoUsers { get; set; }
        public static string f_usuario_LoginName { get; set; }      //Correo
        public static string f_usuario_Apellidos { get; set; }
        public static string f_usuario_Estado { get; set; }
        public static string f_usuario_DNI { get; set; }


        //-- Ocupación
        public static int ocupacion_id { get; set; }
        public static string ocupacion_c_codigo { get; set; }
        public static string ocupacion_t_descripcion { get; set; }
	    public static int ocupacion_f_estado { get; set; }

        //.. Filtro Lista Tarida
        public static string ValorRequest { get; set; }

        //-- Id Seguros
        public static int f_id_tarifario_segus { get; set; }
        //-- Filtro Participantes Tarifario
        public static int id_tarifario_segus_participante { get; set; }
        public static string codParticipante { get; set; }
        public static string nomParticipante { get; set; }
        public static int id_tarifario_segus { get; set; }
        //--Filtro Tarifario
        public static int id_categoria_pago_precio { get; set; }

        public static int cp_id_tarifario_segus { get; set; } //-- Padre de la tabla CVN_TARIFARIO_SEGUS
        public static int cp_id_categoria_pago { get; set; }
        public static string cp_c_codigo { get; set; }
        public static string cp_t_descripcion { get; set; }
        public static decimal cp_n_precio_sol { get; set; }
        public static decimal cp_n_precio_usd { get; set; }
        //Ctategoria Papgo
        
    }
}
