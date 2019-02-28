using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.shared.Interface
{
    interface iErrorOrchestrator
    {
        Task<int> AddErrorRecord(ErrorViewModel ErrorToAdd);
        Task GenerateError();
        Task RecordErrorAsync(Exception ex);
    }
}
