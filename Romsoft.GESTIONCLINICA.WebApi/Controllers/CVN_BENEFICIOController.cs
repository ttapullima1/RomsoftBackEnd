using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_BENEFICIO;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_BENEFICIO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class CVN_BENEFICIOController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                //var tarifario = MapperHelper.Map<CVN_TARIFARIO_SEGUSDTO, CVN_TARIFARIO_SEGUS>(listatarifarioDTO);

                var beneficioList = CVN_BENEFICIOBL.Instancia.GetAllActives();
                var beneficioDTOList = MapperHelper.Map<IEnumerable<CVN_BENEFICIO>, IEnumerable<CVN_BENEFICIODTO>>(beneficioList);
                jsonResponse.Data = beneficioDTOList;
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
