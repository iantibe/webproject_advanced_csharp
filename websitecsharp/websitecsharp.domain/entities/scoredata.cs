using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitecsharp.domain.entities
{
    public class scoredata
    {
        [Key]
        public Guid highScoreId { get; set; }
        public Guid personId { get; set; }
        public int score { get; set; }
        public DateTime dateAttained { get; set; }
    }
}
