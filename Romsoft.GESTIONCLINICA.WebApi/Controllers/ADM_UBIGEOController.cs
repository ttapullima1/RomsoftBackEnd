using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.ADM_UBIGEO;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.ADM_UBIGEO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;
using Romsoft.GESTIONCLINICA.Entidades;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class ADM_UBIGEOController : BaseController
    {
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {

                var ubigeoList = ADM_UBIGEOBL.Instancia.GetAllActives();
                var ubigeoDTOList = MapperHelper.Map<IEnumerable<ADM_UBIGEO>, IEnumerable<ADM_UBIGEODTO>>(ubigeoList);
                jsonResponse.Data = ubigeoDTOList;
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
        public JsonResponse GetAllFilters(ADM_UBIGEODTO ubigeoDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var ubigeo = MapperHelper.Map<ADM_UBIGEODTO, ADM_UBIGEO>(ubigeoDTO);

                var ubigeoList = ADM_UBIGEOBL.Instancia.GetAllFilters(ubigeo);
                var ubigeoDTOList = MapperHelper.Map<IEnumerable<ADM_UBIGEO>, IEnumerable<ADM_UBIGEODTO>>(ubigeoList);
                jsonResponse.Data = ubigeoDTOList;
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
