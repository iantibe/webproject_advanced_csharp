using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using websitecsharp.shared.orchestrators;

namespace websitecsharp.web.api
{
    [Route("api/getprojectmembers")]
    public class projectdataController : ApiController
    {
        public readonly webapiorchestrator _webapiorchestrator;

        public projectdataController()
        {
            _webapiorchestrator = new webapiorchestrator();
        }

        [HttpGet]
        public String GetProjectMembers()
        {
            String data = _webapiorchestrator.GetInformation();

            return data;

        }

    }
}
