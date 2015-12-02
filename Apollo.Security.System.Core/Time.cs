using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Apollo.Security.System.Core.Interface;

namespace Apollo.Security.System.Core
{
    public class Time : ITime
    {
        public void Delay(int milliSeconds)
        {
            Thread.Sleep(milliSeconds);
        }
    }
}
