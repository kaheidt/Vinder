using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AcceptVerbsAttribute = System.Web.Mvc.AcceptVerbsAttribute;

namespace Vinder.WebAPI.Controllers
{
    [RoutePrefix("api/likes")]
    public class LikesController : ApiController
    {
        [Route("")]
        [HttpGet]
        public bool SubmitLike(
            [FromUri] Guid? uid,
            [FromUri] decimal? distance,
            [FromUri] bool like)
        {
            return true;
        }
    }
}