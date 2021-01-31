using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CON_CONTACTO;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CON_CONTACTO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class CON_CONTACTOController : BaseController
    {
        [HttpPost]
        public JsonResponse Add(CON_CONTACTODTO concontactoDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                int resultado = 0;
                var concontacto = MapperHelper.Map<CON_CONTACTODTO, CON_CONTACTO>(concontactoDTO);

                if (!CON_CONTACTOBL.Instancia.Exists(concontacto))
                {
                    resultado = CON_CONTACTOBL.Instancia.Add(concontacto);

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
                    Usuario = concontactoDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(concontactoDTO)
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
                    Usuario = concontactoDTO.UsuarioCreacion,
                    Objeto = JsonConvert.SerializeObject(concontactoDTO)
                });
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse Delete(CON_CONTACTODTO concontactoDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };
            try
            {
                var concontacto = MapperHelper.Map<CON_CONTACTODTO, CON_CONTACTO>(concontactoDTO);
                int resultado = CON_CONTACTOBL.Instancia.Delete(concontacto);

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
                    Usuario = concontactoDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(concontactoDTO)
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
                    Usuario = concontactoDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(concontactoDTO)
                });
            }

            return jsonResponse;
        }

        [HttpPost]
        public JsonResponse GetById(CON_CONTACTODTO concontactoDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var concontacto = MapperHelper.Map<CON_CONTACTODTO, CON_CONTACTO>(concontactoDTO);
                var concontactoList = CON_CONTACTOBL.Instancia.GetById(concontacto);
                if (concontactoList != null)
                {
                    var catpagoDTOList = MapperHelper.Map<IEnumerable<CON_CONTACTO>, IEnumerable<CON_CONTACTODTO>>(concontactoList);
                    jsonResponse.Data = catpagoDTOList;
                }
                else
                {
                    jsonResponse.Warning = true;
                    jsonResponse.Message = Mensajes.RegistroNoExiste;
                }
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
        public JsonResponse GetAllFilters(CON_CONTACTODTO concontactoDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var concontacto = MapperHelper.Map<CON_CONTACTODTO, CON_CONTACTO>(concontactoDTO);

                var concontactoList = CON_CONTACTOBL.Instancia.GetAllFilters(concontacto);
                var concontactoDTOList = MapperHelper.Map<IEnumerable<CON_CONTACTO>, IEnumerable<CON_CONTACTODTO>>(concontactoList);
                jsonResponse.Data = concontactoDTOList;
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
