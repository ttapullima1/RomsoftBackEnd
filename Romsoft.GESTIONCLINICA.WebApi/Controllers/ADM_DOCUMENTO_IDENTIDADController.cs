using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_DOCUMENTO_IDENTIDAD;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_DOCUMENTO_IDENTIDAD;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;
namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_DOCUMENTO_IDENTIDADController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var docidentidadList = ADM_DOCUMENTO_IDENTIDADBL.Instancia.GetAllActives();
                var docidentidadDTOList = MapperHelper.Map<IEnumerable<ADM_DOCUMENTO_IDENTIDAD>, IEnumerable<ADM_DOCUMENTO_IDENTIDADDTO>>(docidentidadList);
                jsonResponse.Data = docidentidadDTOList;
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
