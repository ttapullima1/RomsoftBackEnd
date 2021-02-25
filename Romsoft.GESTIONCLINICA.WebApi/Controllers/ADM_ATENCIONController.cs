using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ATENCION;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_ATENCION;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_ATENCIONController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllFilters(ADM_ATENCIONDTO atencionesDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var atenciones = MapperHelper.Map<ADM_ATENCIONDTO, ADM_ATENCION>(atencionesDTO);

                var pacienteList = ADM_ATENCIONBL.Instancia.GetAllFilters(atenciones);
                var pacienteDTOList = MapperHelper.Map<IEnumerable<ADM_ATENCION>, IEnumerable<ADM_ATENCIONDTO>>(pacienteList);
                jsonResponse.Data = pacienteDTOList;
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
        public JsonResponse GetAllPaciente(int idPaciente)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                
                var atencionesList = ADM_ATENCIONBL.Instancia.GetAllPaciente(idPaciente);
                var pacienteDTOList = MapperHelper.Map<IEnumerable<ADM_ATENCION>, IEnumerable<ADM_ATENCIONDTO>>(atencionesList);
                jsonResponse.Data = pacienteDTOList;
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
