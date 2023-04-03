using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymophism_Parameters
{
    internal class CarIdInfo
    {
        public int IDNum { get; internal set; }
        public string Owner { get; internal set; }

        class CarIDInfo
        {
            public int IDNum { get; set; } = 0;
            public string Owner { get; set; } = "No owner";
        }
    }
}
