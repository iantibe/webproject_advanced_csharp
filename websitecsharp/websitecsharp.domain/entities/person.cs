using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitecsharp.domain.entities
{
    public class person
    {
        public Guid personID { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime dateCreated { get; set; }
        public String email { get; set; }
    }
}
