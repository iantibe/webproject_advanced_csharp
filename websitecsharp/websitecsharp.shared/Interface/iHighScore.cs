using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.shared.Interface
{
    public interface iHighScore
    {
        List<HighScoreViewModel> GetScores(List<HighScoreViewModel> score);
        HighScoreViewModel UpdateScore(Decimal score, Guid name, List<HighScoreViewModel> Databaseresults, out HighScoreViewModel newperson);
        List<HighScoreViewModel> GetData();
    }
}
