
using System;
using System.Runtime.InteropServices;

namespace COM.Server.Addition
{

    [ComVisible(true)]
    [Guid(ContractGuids.ServerInterface)]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IServer
    {
        double Add(int num1,int num2);
    }
}
