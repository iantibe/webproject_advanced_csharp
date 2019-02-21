using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using websitecsharp.shared.enums;

namespace websitecsharp.shared.viewmodels
{
    public class UpdateUserViewModel
    {
        public Guid personID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Gender PersonGender { get; set; }
        public DateTime DateCreated { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
    }
}
