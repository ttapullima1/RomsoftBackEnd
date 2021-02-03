using Newtonsoft.Json;
using Romsoft.GESTIONCLINICA.Business.Logic.Tablas;
using Romsoft.GESTIONCLINICA.Entidades;
using Romsoft.GESTIONCLINICA.Entidades.CON_TIPO_CONTACTO;
using Romsoft.GESTIONCLINICA.DTO.TABLAS.CON_TIPO_CONTACTO;
using Romsoft.GESTIONCLINICA.WebApi.Core;
using Romsoft.GESTIONCLINICA.Common;
using System;
using System.Collections.Generic;
using System.Web.Http;
using Romsoft.GESTIONCLINICA.DTO.AutoMapper;

namespace Romsoft.GESTIONCLINICA.WebApi.Controllers
{
    public class CON_TIPO_CONTACTOController : BaseController
    {
        //
        //Obtiene activos
        [HttpPost]
        public JsonResponse GetAllActives()
        {
            var jsonResponse = new JsonResponse { Success = true };

            try
            {
                //var tarifario = MapperHelper.Map<CVN_TARIFARIO_SEGUSDTO, CVN_TARIFARIO_SEGUS>(listatarifarioDTO);

                var tarifaList = CON_TIPO_CONTACTOBL.Instancia.GetAllActives();
                var tarifaDTOList = MapperHelper.Map<IEnumerable<CON_TIPO_CONTACTO>, IEnumerable<CON_TIPO_CONTACTODTO>>(tarifaList);
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

