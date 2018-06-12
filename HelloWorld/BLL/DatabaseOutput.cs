using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLL
{
 
    public class DatabaseOutput : IOutputDestination
    {
        public void WriteOutput(string messageToPrint)
        {
            return;
            //Methods to write to database
            //DAL.Write(messageToPrint) : //DAL tbd
        }
    }
}
