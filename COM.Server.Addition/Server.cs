using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace COM.Server.Addition
{
    [ComVisible(true)]
    [Guid(ContractGuids.ServerClass)]
    public class Server : IServer
    {
        public double Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
