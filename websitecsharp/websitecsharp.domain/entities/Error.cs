using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitecsharp.domain.entities
{
    public class Error
    {
        [Key]
       public Guid Id { get; set; }
       public DateTime ErrorDateTime { get; set; }
       public String ErrorMessage { get; set; }
       public String StackTrack { get; set; }
       public String InnerExceptions { get; set; }
    }
}
