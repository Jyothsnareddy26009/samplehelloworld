using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample.BLL;
using System.Configuration;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            { 
                string currentDestination = ConfigurationManager.AppSettings["CurrentOutputDestination"];
            
                if(currentDestination.ToLower().Trim()=="console")
                { 
                ConsoleScreen console = new ConsoleScreen();
                console.WriteOutput("Hello World");
                }
            }
            catch(Exception e)
            {
                Console.Write("Unexpected Error : Please check configuration file or refer error details." + e.Message);
            }
            //Console.Read();
        }
    }
}
