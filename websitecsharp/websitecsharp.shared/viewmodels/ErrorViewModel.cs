using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitecsharp.shared.viewmodels
{
    public class ErrorViewModel
    {
       public Guid ErrorId { get; set; }
       public DateTime ErrorTime { get; set; }
       public String StackTrace { get; set; }
       public String InnerException { get; set; }
       public String ErrorMessage { get; set; }
    }
}
