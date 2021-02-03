using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PLAN_SEGURO;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_PLAN_SEGURO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class CVN_PLAN_SEGUROController : BaseController
    {
        [HttpPost]
        public JsonResponse Add(CVN_PLAN_SEGURODTO planseguroDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                int resultado = 0;
                var planseguro = MapperHelper.Map<CVN_PLAN_SEGURODTO, CVN_PLAN_SEGURO>(planseguroDTO);

                if (!CVN_PLAN_SEGUROBL.Instancia.Exists(planseguro))
                {
                    resultado = CVN_PLAN_SEGUROBL.Instancia.Add(planseguro);

                    if (resultado > 0)
                    {
                        jsonResponse.Message = Mensajes.RegistroSatisfactorio;
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
                    Usuario = planseguroDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(planseguroDTO)
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
                    Usuario = planseguroDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(planseguroDTO)
                });
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse GetAllFilters(CVN_PLAN_SEGURODTO planseguroDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var planseguro = MapperHelper.Map<CVN_PLAN_SEGURODTO, CVN_PLAN_SEGURO>(planseguroDTO);

                var planseguroList = CVN_PLAN_SEGUROBL.Instancia.GetAllFilters(planseguro);
                var planseguroDTOList = MapperHelper.Map<IEnumerable<CVN_PLAN_SEGURO>, IEnumerable<CVN_PLAN_SEGURODTO>>(planseguroList);
                jsonResponse.Data = planseguroDTOList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse Update(CVN_PLAN_SEGURODTO planseguroDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                var planseguro = MapperHelper.Map<CVN_PLAN_SEGURODTO, CVN_PLAN_SEGURO>(planseguroDTO);
                int resultado = CVN_PLAN_SEGUROBL.Instancia.Update(planseguro);

                if (resultado > 0)
                {
                    jsonResponse.Message = Mensajes.ActualizacionSatisfactoria;
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = Mensajes.ActualizacionFallida;
                }

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Update,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = resultado,
                    Mensaje = jsonResponse.Message,
                    Usuario = planseguroDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(planseguroDTO)
                });
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;

                LogBL.Instancia.Add(new Log
                {
                    Accion = Mensajes.Update,
                    Controlador = Mensajes.UsuarioController,
                    Identificador = 0,
                    Mensaje = ex.Message,
                    Usuario = planseguroDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(planseguroDTO)
                });
            }

            return jsonResponse;
        }


        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                //var tarifario = MapperHelper.Map<CVN_TARIFARIO_SEGUSDTO, CVN_TARIFARIO_SEGUS>(listatarifarioDTO);

                var planseguroList = CVN_PLAN_SEGUROBL.Instancia.GetAllActives();
                var planDTOList = MapperHelper.Map<IEnumerable<CVN_PLAN_SEGURO>, IEnumerable<CVN_PLAN_SEGURODTO>>(planseguroList);
                jsonResponse.Data = planDTOList;
            }
            catch (Exception ex)
            {
                LogError(ex);
                jsonResponse.Success = false;
                jsonResponse.Message = Mensajes.IntenteloMasTarde;
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse GetById(CVN_PLAN_SEGURODTO planseguroDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var planseguro = MapperHelper.Map<CVN_PLAN_SEGURODTO, CVN_PLAN_SEGURO>(planseguroDTO);

                var planseguroList = CVN_PLAN_SEGUROBL.Instancia.GetById(planseguro);
                var planseguroDTOList = MapperHelper.Map<IEnumerable<CVN_PLAN_SEGURO>, IEnumerable<CVN_PLAN_SEGURODTO>>(planseguroList);
                jsonResponse.Data = planseguroDTOList;
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
