using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_GRUPO_SANGUINEO;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_GRUPO_SANGUINEO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_GRUPO_SANGUINEOController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var gsanguineoList = ADM_GRUPO_SANGUINEOBL.Instancia.GetAllActives();
                var gsanguineoDTOList = MapperHelper.Map<IEnumerable<ADM_GRUPO_SANGUINEO>, IEnumerable<ADM_GRUPO_SANGUINEODTO>>(gsanguineoList);
                jsonResponse.Data = gsanguineoDTOList;
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
