using Sabio.Web.Controllers.Attributes;
using Sabio.Web.Domain;
using Sabio.Web.Enums;
using Sabio.Web.Models.Requests;
using Sabio.Web.Models.Requests.EVA;
using Sabio.Web.Models.Responses;
using Sabio.Web.Services;
using Sabio.Web.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sabio.Web.Controllers.Api
{
    [RoutePrefix("api/eva/entity")]
    public class EVA_EntityApiController : ApiController
    {
        private IEntityServices _EntityServices { get; set; }

        public EVA_EntityApiController(IEntityServices EntityServices)
        {
            _EntityServices = EntityServices;
        }
        
        [Route(""), HttpPost]
        public HttpResponseMessage Add(EVA_EntityRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            ItemResponse<int> response = new ItemResponse<int>();

            response.Item = _EntityServices.Insert(model);

            return Request.CreateResponse(response);
        }

       

    }
}
