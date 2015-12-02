using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Apollo.Security.System.Core.Model;

namespace Apollo.Security.System.Core.DataLayer
{
    public static class ApolloLoggingData
    {
        public static List<Log> Logs { get; set; }

        static ApolloLoggingData()
        {
           Logs = new List<Log>(); 
        }
    }
}
