using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSC237_JMarshall_Bethanys.Models;

namespace CSC237_JMarshall_Bethanys.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
