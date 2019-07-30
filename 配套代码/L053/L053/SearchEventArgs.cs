using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L053
{
    public class SearchEventArgs: EventArgs
    {
        public string SearchTerm { set; get; }
    }
}
