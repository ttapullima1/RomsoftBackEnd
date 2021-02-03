using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades.CVN_PRODUCTO_PLAN;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CVN_PRODUCTO_PLAN;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class CVN_PRODUCTO_PLANController : BaseController
    {

        [HttpPost]
        public JsonResponse GetAllActivesFilters(CVN_PRODUCTO_PLANDTO productoplanDTO)
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                var productoplan = MapperHelper.Map<CVN_PRODUCTO_PLANDTO, CVN_PRODUCTO_PLAN>(productoplanDTO);

                var productoplanList = CVN_PRODUCTO_PLANBL.Instancia.GetAllActivesFilters(productoplan);
                var productoplanListDTOList = MapperHelper.Map<IEnumerable<CVN_PRODUCTO_PLAN>, IEnumerable<CVN_PRODUCTO_PLANDTO>>(productoplanList);
                jsonResponse.Data = productoplanListDTOList;
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
