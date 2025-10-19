using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prj
{
    public interface IRun
    {
        float IRunPrpSpeed { get; set; }

        void IRunMthDo();
    }
}