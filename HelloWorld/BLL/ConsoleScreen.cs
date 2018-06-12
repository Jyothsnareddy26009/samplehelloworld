using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.BLL
{
    public class ConsoleScreen : IOutputDestination
    {
        public void WriteOutput(string messageToPrint)
        {
            Console.WriteLine(messageToPrint);
            Console.Read();
        }
    }
}
