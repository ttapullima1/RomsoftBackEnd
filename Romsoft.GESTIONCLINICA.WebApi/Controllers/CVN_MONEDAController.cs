using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_MONEDA;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_MONEDA;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class CVN_MONEDAController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                //var tarifario = MapperHelper.Map<CVN_TARIFARIO_SEGUSDTO, CVN_TARIFARIO_SEGUS>(listatarifarioDTO);

                var tarifaList = CVN_MONEDABL.Instancia.GetAllActives();
                var tarifaDTOList = MapperHelper.Map<IEnumerable<CVN_MONEDA>, IEnumerable<CVN_MONEDADTO>>(tarifaList);
                jsonResponse.Data = tarifaDTOList;
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
