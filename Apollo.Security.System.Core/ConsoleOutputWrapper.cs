using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apollo.Security.System.Core.Interface;

namespace Apollo.Security.System.Core
{
    public class ConsoleOutputWrapper : IConsoleOutputWrapper
    {
        public void WriteToConsole(string message)
        {
            Console.WriteLine(message);
        }
    }
}
