using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigServiceDomain.Eto
{
    public class StockSummaryEto
    {
        public int CopiesStocked { get; set; }
        public int CopiesLeft { get; set; }
        public DateTime LastRestock { get; set; }
    }
}
