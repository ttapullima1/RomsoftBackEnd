using Microsoft.Practices.EnterpriseLibrary.Data;
using Romsoft.GESTIONCLINICA.Common;
using Romsoft.GESTIONCLINICA.Common.Generics;
using Romsoft.GESTIONCLINICA.DataAccess.Core;
using Romsoft.GESTIONCLINICA.DataAccess.Interfaces.IADM_ATENCIONRepository;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;
using System;
using System.Collections.Generic;
using System.Data;

namespace Romsoft.GESTIONCLINICA.DataAccess.Tablas
{
    public class ADM_ATENCIONRepository : Singleton<ADM_ATENCIONRepository>, IADM_ATENCIONRepository<ADM_ATENCION>
    {
        #region Attributos
        private readonly Database _database = new DatabaseProviderFactory().Create(ConectionStringRepository.ConnectionStringNameSQL);

        #endregion

        public int Add(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAll(string whereFilters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllActives()
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetAllFilters(ADM_ATENCION entity)
        {
            List<ADM_ATENCION> atenciones = new List<ADM_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_PACIENTE_GetAllFilter")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, entity.id_paciente);
                _database.AddInParameter(comando, "@d_fecha_registro_1", DbType.DateTime, entity.d_fecha_registro_1);
                _database.AddInParameter(comando, "@d_fecha_registro_2", DbType.DateTime, entity.d_fecha_registro_2);



                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION
                        {
                            id_nro_interno = lector.IsDBNull(lector.GetOrdinal("id_nro_interno")) ? default(int) : lector.GetInt64(lector.GetOrdinal("id_nro_interno")),
                            d_fecha_ingreso = lector.IsDBNull(lector.GetOrdinal("d_fecha_ingreso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_ingreso")),
                            tipo_paciente = lector.IsDBNull(lector.GetOrdinal("tipo_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_paciente")),
                            tipo_atencion = lector.IsDBNull(lector.GetOrdinal("tipo_atencion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_atencion")),
                            garante = lector.IsDBNull(lector.GetOrdinal("garante")) ? default(string) : lector.GetString(lector.GetOrdinal("garante")),
                            contratante = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),

                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION> GetAllPaciente(int idPaciente)
        {
            List<ADM_ATENCION> atenciones = new List<ADM_ATENCION>();
            using (var comando = _database.GetStoredProcCommand(string.Format("{0}{1}", ConectionStringRepository.EsquemaName, "p_ADM_ATENCION_GetAll")))
            {
                _database.AddInParameter(comando, "@id_paciente", DbType.Int32, idPaciente);

                using (var lector = _database.ExecuteReader(comando))
                {
                    while (lector.Read())
                    {
                        atenciones.Add(new ADM_ATENCION
                        {
                            id_nro_interno = lector.IsDBNull(lector.GetOrdinal("id_nro_interno")) ? default(int) : lector.GetInt64(lector.GetOrdinal("id_nro_interno")),
                            d_fecha_ingreso = lector.IsDBNull(lector.GetOrdinal("d_fecha_ingreso")) ? default(DateTime) : lector.GetDateTime(lector.GetOrdinal("d_fecha_ingreso")),
                            tipo_paciente = lector.IsDBNull(lector.GetOrdinal("tipo_paciente")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_paciente")),
                            tipo_atencion = lector.IsDBNull(lector.GetOrdinal("tipo_atencion")) ? default(string) : lector.GetString(lector.GetOrdinal("tipo_atencion")),
                            garante = lector.IsDBNull(lector.GetOrdinal("garante")) ? default(string) : lector.GetString(lector.GetOrdinal("garante")),
                            contratante = lector.IsDBNull(lector.GetOrdinal("t_direccion")) ? default(string) : lector.GetString(lector.GetOrdinal("t_direccion")),
                            estado = lector.IsDBNull(lector.GetOrdinal("estado")) ? default(string) : lector.GetString(lector.GetOrdinal("estado")),
                        });
                    }
                }
            }

            return atenciones;
        }

        public IList<ADM_ATENCION> GetAllPaging(PaginationParameter paginationParameters)
        {
            throw new NotImplementedException();
        }

        public IList<ADM_ATENCION> GetById(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }

        public int Update(ADM_ATENCION entity)
        {
            throw new NotImplementedException();
        }
    }
}
