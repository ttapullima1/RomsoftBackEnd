using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_GENERO;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_GENERO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_GENEROController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var generoList = ADM_GENEROBL.Instancia.GetAllActives();
                var generoDTOList = MapperHelper.Map<IEnumerable<ADM_GENERO>, IEnumerable<ADM_GENERODTO>>(generoList);
                jsonResponse.Data = generoDTOList;
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
