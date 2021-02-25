using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_DOCUMENTO_AUTORIZACIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;


namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_DOCUMENTO_AUTORIZACIONRepository : Singleton<ADM_DOCUMENTO_AUTORIZACIONRepository>, IADM_DOCUMENTO_AUTORIZACIONRepository<ADM_DOCUMENTO_AUTORIZACION>
    {
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringACCESS);
        public int Add(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            int id;

            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_DOCUMENTO_AUTORIZACION_Insert")))
            {
                _database.AddInParameter(comando, "@c_cod_autorizacion", DbType.String, entity.c_cod_autorizacion);
                _database.AddInParameter(comando, "@c_cod_asegurado", DbType.String, entity.c_cod_asegurado);
                _database.AddInParameter(comando, "@c_nro_autorizacion", DbType.String, entity.c_nro_autorizacion);
                _database.AddInParameter(comando, "@c_fecha_autorizacion", DbType.String, entity.c_fecha_autorizacion);
                _database.AddInParameter(comando, "@c_fecha_i_vigencia", DbType.String, entity.c_fecha_i_vigencia);
                _database.AddInParameter(comando, "@c_fecha_nacimiento", DbType.String, entity.c_fecha_nacimiento);
                _database.AddInParameter(comando, "@c_tipo_afiliacion", DbType.String, entity.c_tipo_afiliacion);
                _database.AddInParameter(comando, "@t_p_apellido_paterno", DbType.String, entity.t_p_apellido_paterno);
                _database.AddInParameter(comando, "@t_p_apellido_materno", DbType.String, entity.t_p_apellido_materno);
                _database.AddInParameter(comando, "@t_p_nombre_completo", DbType.String, entity.t_p_nombre_completo);
                _database.AddInParameter(comando, "@t_t_apellido_paterno", DbType.String, entity.t_t_apellido_paterno);
                _database.AddInParameter(comando, "@t_t_apellido_materno", DbType.String, entity.t_t_apellido_materno);
                _database.AddInParameter(comando, "@t_t_nombre_completo", DbType.String, entity.t_t_nombre_completo);
                _database.AddInParameter(comando, "@c_parentesco", DbType.String, entity.c_parentesco);
                _database.AddInParameter(comando, "@c_producto_plan", DbType.String, entity.c_producto_plan);
                _database.AddInParameter(comando, "@c_cod_beneficio", DbType.String, entity.c_cod_beneficio);
                _database.AddInParameter(comando, "@c_nro_contrato", DbType.String, entity.c_nro_contrato);
                _database.AddInParameter(comando, "@c_ruc_iafa", DbType.String, entity.c_ruc_iafa);
                _database.AddInParameter(comando, "@c_cod_iafa", DbType.String, entity.c_cod_iafa);
                _database.AddInParameter(comando, "@c_cod_contrantate", DbType.String, entity.c_cod_contrantate);
                _database.AddInParameter(comando, "@t_contratante", DbType.String, entity.t_contratante);
                _database.AddInParameter(comando, "@n_copago_fijo", DbType.Decimal, entity.n_copago_fijo);
                _database.AddInParameter(comando, "@n_copago_variable", DbType.Decimal, entity.n_copago_variable);
                _database.AddInParameter(comando, "@n_copago_variable_far", DbType.Decimal, entity.n_copago_variable_far);
                _database.AddInParameter(comando, "@f_estado", DbType.Int32, entity.f_estado);
                _database.AddInParameter(comando, "@d_fecha_registro", DbType.DateTime, DateTime.Now);
                _database.AddInParameter(comando, "@id_user_registro", DbType.Int32, entity.id_usuarioCreacion);
                _database.AddOutParameter(comando, "@Response", DbType.Int32, 11);
                _database.ExecuteNonQuery(comando);
                id = Convert.ToInt32(_database.GetParameterValue(comando, "@Response"));
            }

            return id;
        }

        public int Delete(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllFilters(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            string SQL = "SELECT TOP 10 Dg.CO_IAFASCODE, Dg.CO_ASEGCODE, Dg.CO_AUTOCODE, Dg.FE_AUTODATE, Dg.CO_IPRESSCODE, Dg.DE_IPRESSRUC, Dg.AP_ASEGAPAT, Dg.AP_ASEGAMAT, Dg.NO_ASEGNAME, Dg.AP_TITUAPAT, Dg.AP_TITUAMAT,";
            SQL = SQL + "Dg.NO_TITUNAME, Dg.FE_NACMDATE, Dg.NU_EDADNUM, Dg.CO_TITUCODE, Dg.CO_TIPOPLAN, Dg.DE_CNTRRUC, Dg.DE_CNTRNAME, Dg.FE_INIVIGDATE, Dg.FE_FINVIGDATE, Dg.FE_INCLDATE, Dg.CO_FILIACODE, ";
            SQL = SQL + "SSTM_TIPO_FILIACION.NO_NAMEFILIACION, Dg.NU_CNTRNUMB, Dg.CO_MONECODE, Dg.DE_CARNNUMB, Dg.NO_DNINAME, Dg.CO_RENIPRESS, Co.CO_COBERCODE, Co.CO_SUBTIPOCOBER, Co.NO_SUBTIPOCOBER, ";
            SQL = SQL + "Co.NU_COPGFIJO, Co.CO_CALIFSERVCODE, Co.NU_COPGVARI, Co.DE_BENEFICIOMAX, Co.FE_FECARDATE, Co.DE_IPSSHOST, SSTD_CONDICIONESMEDICAS.CO_DXPREEXT, SSTD_CONDICIONESMEDICAS.NO_DXPREEXT, ";
            SQL = SQL + "SSTD_CONDICIONESMEDICAS.DE_OBSPREEXT, SSTD_PROCEDIMIENTOS.CO_ITEM, SSTD_PROCEDIMIENTOS.CO_TIPOPROCINT, SSTD_PROCEDIMIENTOS.NO_TIPOPROCNAME, Dg.NU_POLIZA, Co.CO_PRODCODE,";
            SQL = SQL + "Dg.DE_AUTOTIME, Dg.NU_ASEGPLAN, Co.CO_INDIPROCODE, Dg.CO_AFICODE,SSTM_TIPO_AFILIACION.NO_AFINAME, Dg.CO_GECODE, Co.CO_ACCIDENTES, Co.CO_TIDECLARACION, Co.FE_ACCIDENTES ";
            SQL = SQL + "FROM (((((SSTC_DATOSGENERALES Dg INNER JOIN SSTD_COBERTURA_ACRED Co ON Dg.CO_AUTOCODE = Co.CO_AUTOCODE AND Dg.CO_ASEGCODE = Co.CO_ASEGCODE AND Dg.CO_IAFASCODE = Co.CO_IAFASCODE) ";
            SQL = SQL + "LEFT OUTER JOIN SSTD_CONDICIONESMEDICAS ON Co.CO_AUTOCODE = SSTD_CONDICIONESMEDICAS.CO_AUTOCODE AND Co.CO_ASEGCODE = SSTD_CONDICIONESMEDICAS.CO_ASEGCODE AND Co.CO_IAFASCODE = SSTD_CONDICIONESMEDICAS.CO_IAFASCODE) ";
            SQL = SQL + "LEFT OUTER JOIN SSTD_PROCEDIMIENTOS ON Co.CO_AUTOCODE = SSTD_PROCEDIMIENTOS.CO_AUTOCODE AND Co.CO_ASEGCODE = SSTD_PROCEDIMIENTOS.CO_ASEGCODE AND Co.CO_IAFASCODE = SSTD_PROCEDIMIENTOS.CO_IAFASCODE) ";
            SQL = SQL + "LEFT OUTER JOIN SSTM_TIPO_FILIACION ON Dg.CO_FILIACODE = SSTM_TIPO_FILIACION.CO_FILIACIONCODE) ";
            SQL = SQL + "LEFT OUTER JOIN SSTM_TIPO_AFILIACION ON Dg.CO_AFICODE = SSTM_TIPO_AFILIACION.CO_AFICODE) ";
            SQL = SQL + "WHERE(LEFT(Dg.DE_FOTORUTA, 3) <> 'REV') AND(Dg.CO_IAFASCODE IS NOT NULL) AND(Dg.CO_ASEGCODE IS NOT NULL) AND (Dg.CO_AUTOCODE IS NOT NULL) AND Dg.CO_AUTOCODE='";
            //SQL = SQL + "WHERE LEFT(Dg.De_FotoRuta,3) <> 'REV' AND(dg.CO_IAFASCODE IS NOT NULL) AND(dg.CO_ASEGCODE IS NOT NULL) AND(dg.CO_AUTOCODE IS NOT NULL) AND Dg.CO_AUTOCODE='";
            SQL = SQL + entity.valor + "'";
            List<ADM_DOCUMENTO_AUTORIZACION> siteds = new List<ADM_DOCUMENTO_AUTORIZACION>();
            OleDbConnection conexion;
            conexion = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\\SUSALUD\\SITEDS 10.0 (Rev. 5.4)\\IPRESSLOG.mdb");
            conexion.Open();
            OleDbCommand comando = new OleDbCommand(SQL, conexion);
            OleDbDataReader lectorDatos;
            lectorDatos = comando.ExecuteReader();
            Boolean existeRegistre = lectorDatos.HasRows;
            while (lectorDatos.Read())
            {
                siteds.Add(new ADM_DOCUMENTO_AUTORIZACION
                {
                    c_cod_autorizacion = "01",//lectorDatos.IsDBNull(lectorDatos.GetOrdinal("CO_AUTOCODE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("CO_AUTOCODE")),
                    c_cod_asegurado = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("CO_ASEGCODE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("CO_ASEGCODE")),
                    ///Validar campo c_nro_autorizacion
                    c_nro_autorizacion = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("CO_AUTOCODE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("CO_AUTOCODE")),
                    c_fecha_autorizacion = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FE_AUTODATE")) ? default(string) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FE_AUTODATE")).ToString(),
                    c_fecha_i_vigencia = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FE_AUTODATE")) ? default(string) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FE_AUTODATE")).ToString(),
                    c_fecha_nacimiento = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("FE_NACMDATE")) ? default(string) : lectorDatos.GetDateTime(lectorDatos.GetOrdinal("FE_NACMDATE")).ToString(),
                    c_tipo_afiliacion = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NO_AFINAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NO_AFINAME")),
                    t_p_apellido_paterno = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("AP_ASEGAPAT")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("AP_ASEGAPAT")),
                    t_p_apellido_materno = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("AP_ASEGAMAT")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("AP_ASEGAMAT")),
                    t_p_nombre_completo = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NO_ASEGNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NO_ASEGNAME")),
                    t_t_apellido_paterno = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("AP_TITUAPAT")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("AP_TITUAPAT")),
                    t_t_apellido_materno = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("AP_TITUAMAT")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("AP_TITUAMAT")),
                    t_t_nombre_completo = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NO_TITUNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NO_TITUNAME")),
                    c_parentesco = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NO_NAMEFILIACION")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NO_NAMEFILIACION")),
                    c_producto_plan = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NO_TIPOPROCNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NO_TIPOPROCNAME")),
                    c_cod_beneficio = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NO_SUBTIPOCOBER")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NO_SUBTIPOCOBER")),
                    c_nro_contrato = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NU_CNTRNUMB")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("NU_CNTRNUMB")),
                    ///Validar campo c_ruc_iafa
                    c_ruc_iafa = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_IPRESSRUC")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_IPRESSRUC")),
                    c_cod_iafa = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("CO_IAFASCODE")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("CO_IAFASCODE")),
                    c_cod_contrantate = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRRUC")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRRUC")),
                    t_contratante = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    n_copago_fijo = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NU_COPGFIJO")) ? default(decimal) : lectorDatos.GetDecimal(lectorDatos.GetOrdinal("NU_COPGFIJO")),
                    n_copago_variable = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NU_COPGVARI")) ? default(decimal) : Convert.ToDecimal(lectorDatos.GetDouble(lectorDatos.GetOrdinal("NU_COPGVARI"))),
                    ///Validar campo n_copago_variable_far
                    n_copago_variable_far = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("NU_COPGVARI")) ? default(decimal) : Convert.ToDecimal(lectorDatos.GetDouble(lectorDatos.GetOrdinal("NU_COPGVARI")))

                    //f_estado = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //d_fecha_registro = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //d_fecha_modifica = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //id_user_registro = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                    //id_user_modifica = lectorDatos.IsDBNull(lectorDatos.GetOrdinal("DE_CNTRNAME")) ? default(string) : lectorDatos.GetString(lectorDatos.GetOrdinal("DE_CNTRNAME")),
                }); ;
            }
            conexion.Close();
            return siteds;
            //_database.AddInParameter(comando, "@valor", DbType.String, entity.valor);

            //using (var lector = _database.ExecuteReader(SQL))
            //    {
            //        while (lector.Read())
            //        {
            //            siteds.Add(new ADM_DOCUMENTO_AUTORIZACION
            //            {
            //                c_cod_autorizacion = lector.IsDBNull(lector.GetOrdinal("CO_AUTOCODE")) ? default(string) : lector.GetString(lector.GetOrdinal("CO_AUTOCODE")),
            //                t_p_apellido_paterno = lector.IsDBNull(lector.GetOrdinal("AP_ASEGAPAT")) ? default(string) : lector.GetString(lector.GetOrdinal("AP_ASEGAPAT")),
            //                t_p_apellido_materno = lector.IsDBNull(lector.GetOrdinal("AP_ASEGAMAT")) ? default(string) : lector.GetString(lector.GetOrdinal("AP_ASEGAMAT")),
            //                t_p_nombre_completo = lector.IsDBNull(lector.GetOrdinal("NO_ASEGNAME")) ? default(string) : lector.GetString(lector.GetOrdinal("NO_ASEGNAME")),
            //                t_t_apellido_paterno = lector.IsDBNull(lector.GetOrdinal("AP_TITUAPAT")) ? default(string) : lector.GetString(lector.GetOrdinal("AP_TITUAPAT")),
            //                t_t_apellido_materno = lector.IsDBNull(lector.GetOrdinal("AP_TITUAMAT")) ? default(string) : lector.GetString(lector.GetOrdinal("AP_TITUAMAT")),
            //                t_t_nombre_completo = lector.IsDBNull(lector.GetOrdinal("NO_TITUNAME")) ? default(string) : lector.GetString(lector.GetOrdinal("NO_TITUNAME")),
            //                //c_parentesco = lector.IsDBNull(lector.GetOrdinal("telefono")) ? default(string) : lector.GetString(lector.GetOrdinal("telefono")),
            //                c_producto_plan = lector.IsDBNull(lector.GetOrdinal("NU_ASEGPLAN")) ? default(string) : lector.GetString(lector.GetOrdinal("NU_ASEGPLAN")),
            //                c_cod_beneficio = lector.IsDBNull(lector.GetOrdinal("NO_SUBTIPOCOBER")) ? default(string) : lector.GetString(lector.GetOrdinal("NO_SUBTIPOCOBER")),
            //                c_cod_contrantate = lector.IsDBNull(lector.GetOrdinal("DE_CNTRNAME")) ? default(string) : lector.GetString(lector.GetOrdinal("DE_CNTRNAME")),

            //            });
            //        }
            //   // }
            //}
            //return siteds;
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public ADM_DOCUMENTO_AUTORIZACION GetByEstado(string estadoNombre)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_DOCUMENTO_AUTORIZACION> GetById(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_DOCUMENTO_AUTORIZACION entity)
        {
            throw new NotImplementedException();
        }
    }
}
