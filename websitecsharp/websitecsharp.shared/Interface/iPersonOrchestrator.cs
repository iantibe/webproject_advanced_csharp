using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.shared.viewmodels;

namespace websitecsharp.shared.Interface
{
    interface iPersonOrchestrator
    {
        Task<List<UpdateUserViewModel>> GetPeople();
        Task<int> CreatePerson(UpdateUserViewModel person);
        Task<bool> UpdatePerson(UpdateUserViewModel person);
        Task<UpdateUserViewModel> SearchStudent(string searchString);

    }
}
