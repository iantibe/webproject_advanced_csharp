using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using websitecsharp.shared.orchestrators;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.web.api
{
    [Route ("api/v1/UpdateScore")]
    public class UpdateScoreController : ApiController
    {
        public HighScoreOrchestrator _highScoreOrchestrator;

        
        public UpdateScoreController(HighScoreOrchestrator highScoreOrchestrator)
        {
            _highScoreOrchestrator = highScoreOrchestrator;
        }

        [HttpGet]
        public void UpdateScores(Decimal score, Guid name)
        {
            HighScoreViewModel dummy;

          var Data=  _highScoreOrchestrator.UpdateScore(score, name, _highScoreOrchestrator.GetData(), out dummy);

            _highScoreOrchestrator.UpdateDatabase(Data);

            
        }

    }
}
