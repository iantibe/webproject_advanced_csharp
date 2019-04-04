using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using websitecsharp.shared.Interface;
using websitecsharp.shared.orchestrators;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.web.api
{
    [Route ("api/v1/highscore")]
    public class HighScoreApiController : ApiController
    {
        // private readonly iHighScore _highScoreOrchestrator;

        // public HighScoreApiController(iHighScore highScoreOrchestrator)
        //{
        //    _highScoreOrchestrator = highScoreOrchestrator;
        // }

        public HighScoreOrchestrator _highScoreOrchestrator = new HighScoreOrchestrator();
 
        [HttpGet]
        public List<HighScoreViewModel> GetHighScores()
        {
            var data = _highScoreOrchestrator.GetData();
            var scores = _highScoreOrchestrator.GetScores(data);

            return scores;
        }
    }

    
   
}
