using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_AUTORIZACION;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_DOCUMENTO_AUTORIZACION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_DOCUMENTO_AUTORIZACIONController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllFilters(ADM_DOCUMENTO_AUTORIZACIONDTO autorizacionlDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var autorizacion = MapperHelper.Map<ADM_DOCUMENTO_AUTORIZACIONDTO, ADM_DOCUMENTO_AUTORIZACION>(autorizacionlDTO);

                var autorizacionlList = ADM_DOCUMENTO_AUTORIZACIONBL.Instancia.GetAllFilters(autorizacion);
                var autorizacionDTOList = MapperHelper.Map<IEnumerable<ADM_DOCUMENTO_AUTORIZACION>, IEnumerable<ADM_DOCUMENTO_AUTORIZACIONDTO>>(autorizacionlList);
                jsonResponse.Data = autorizacionDTOList;

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
        public JsonResponse Add(ADM_DOCUMENTO_AUTORIZACIONDTO autorizacionlDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var autorizacion = MapperHelper.Map<ADM_DOCUMENTO_AUTORIZACIONDTO, ADM_DOCUMENTO_AUTORIZACION>(autorizacionlDTO);
                var resultado = ADM_DOCUMENTO_AUTORIZACIONBL.Instancia.Add(autorizacion);

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
                    Usuario = autorizacionlDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(autorizacionlDTO)
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
                    Usuario = autorizacionlDTO.UsuarioModificacion,
                    Objeto = JsonConvert.SerializeObject(autorizacionlDTO)
                });
            }

            return jsonResponse;
        }
    }
}
