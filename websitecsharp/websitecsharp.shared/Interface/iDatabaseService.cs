using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.shared.Interface
{
    public interface iDatabaseService
    {
        List<HighScoreViewModel> GenerateData();
        void AddToDataBase(HighScoreViewModel ItemToAdd);
    }
}
