using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLL
{
    interface IOutputDestination
    {
        void WriteOutput(string message);
    }
}
