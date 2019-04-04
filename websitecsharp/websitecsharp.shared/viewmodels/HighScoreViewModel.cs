using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace websitecsharp.shared.viewmodels
{
    public class HighScoreViewModel
    {
        public Decimal Score { get; set; }
        public DateTime DateOfScore { get; set; }
        public Guid HighScoreId { get; set; }
        public Guid PersonId { get; set; }

    }
}
