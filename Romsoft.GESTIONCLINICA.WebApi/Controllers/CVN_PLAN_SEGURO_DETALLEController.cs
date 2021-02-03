using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PLAN_SEGURO_DETALLE;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_PLAN_SEGURO_DETALLE;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class CVN_PLAN_SEGURO_DETALLEController : BaseController
    {
        [HttpPost]
        public JsonResponse Add(CVN_PLAN_SEGURO_DETALLEDTO segurodetalleDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                int resultado = 0;
                var segurodetalle = MapperHelper.Map<CVN_PLAN_SEGURO_DETALLEDTO, CVN_PLAN_SEGURO_DETALLE>(segurodetalleDTO);

                if (!CVN_PLAN_SEGURO_DETALLEBL.Instancia.Exists(segurodetalle))
                {
                    resultado = CVN_PLAN_SEGURO_DETALLEBL.Instancia.Add(segurodetalle);

                    if (resultado > 0)
                    {
                        jsonResponse.Message = Mensajes.RegistroSatisfactorio;
                        jsonResponse.Data = resultado;
                    }
                    else
                    {
                        jsonResponse.Warning = true;
                        jsonResponse.Message = Mensajes.RegistroFallido;
                    }
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = Mensajes.YaExisteRegistro;
                }

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = resultado,
                    Mensaje = jsonResponse.Message,
                    Usuario = segurodetalleDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(segurodetalleDTO)
                });
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Add,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = 0,
                    Mensaje = ex.Message,
                    Usuario = segurodetalleDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(segurodetalleDTO)
                });
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse Delete(CVN_PLAN_SEGURO_DETALLEDTO segurodetalleDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                var segurodetalle = MapperHelper.Map<CVN_PLAN_SEGURO_DETALLEDTO, CVN_PLAN_SEGURO_DETALLE>(segurodetalleDTO);
                int resultado = CVN_PLAN_SEGURO_DETALLEBL.Instancia.Delete(segurodetalle);

                if (resultado > 0)
                {
                    jsonResponse.Message = Mensajes.EliminacionSatisfactoria;
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = Mensajes.EliminacionFallida;
                }
                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Delete,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = resultado,
                    Mensaje = jsonResponse.Message,
                    Usuario = segurodetalleDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(segurodetalleDTO)
                });

            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Delete,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = 0,
                    Mensaje = ex.Message,
                    Usuario = segurodetalleDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(segurodetalleDTO)
                });
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse GetAllActivesFilters(CVN_PLAN_SEGURO_DETALLEDTO segurodetalleDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var segurodetalle = MapperHelper.Map<CVN_PLAN_SEGURO_DETALLEDTO, CVN_PLAN_SEGURO_DETALLE>(segurodetalleDTO);

                var segurodetalleList = CVN_PLAN_SEGURO_DETALLEBL.Instancia.GetAllActivesFilters(segurodetalle);
                var segurodetalleListListDTOList = MapperHelper.Map<IEnumerable<CVN_PLAN_SEGURO_DETALLE>, IEnumerable<CVN_PLAN_SEGURO_DETALLEDTO>>(segurodetalleList);
                jsonResponse.Data = segurodetalleListListDTOList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }

    }
}
