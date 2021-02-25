using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_ESTADO_CIVIL;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_ESTADO_CIVIL;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_ESTADO_CIVILController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var ecivilList = ADM_ESTADO_CIVILBL.Instancia.GetAllActives();
                var ecivilDTOList = MapperHelper.Map<IEnumerable<ADM_ESTADO_CIVIL>, IEnumerable<ADM_ESTADO_CIVILDTO>>(ecivilList);
                jsonResponse.Data = ecivilDTOList;
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
