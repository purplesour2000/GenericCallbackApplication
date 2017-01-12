using System;
using System.Runtime.InteropServices;

namespace GenericaCallbackDLL
{
    [ComVisible(true)]
    [Guid("4469873B-F6E8-4EA4-BCEC-C55D639AD45D")]
    public interface IDllAPI
    {
        void RegisterCallback(IntPtr CCallBack);

        void DisplayMessage();
    }
}
