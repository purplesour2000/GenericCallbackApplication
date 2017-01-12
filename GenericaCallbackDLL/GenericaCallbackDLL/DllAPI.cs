using System;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace GenericaCallbackDLL
{
    delegate void CallBackFunction(int lpId, int iVal);

    [ComVisible(true)]
    [Guid("261527B6-A10A-4C93-92EB-D0AB98BD8FB9")]
    [ProgId("GenericaCallbackDLL")]
    [ClassInterface(ClassInterfaceType.None)]
    public class DllAPI : IDllAPI
    {
        private static CallBackFunction callbackFunction = null;
        private const int WM_USER = 0x0400;
        private const int DllEVENT = WM_USER;

        /// <summary>
        /// Registers callback function from c++
        /// </summary>
        [Browsable(true)]
        [ComVisible(true)]
        public void RegisterCallback(IntPtr CCallBack)
        {
            callbackFunction = (CallBackFunction)Marshal.GetDelegateForFunctionPointer(CCallBack, typeof(CallBackFunction));
        }

        /// <summary>
        /// Called from C++, displays a message and makes callback to C++.
        /// </summary>
        [Browsable(true)]
        [ComVisible(true)]
        public void DisplayMessage()
        {
            MessageBox.Show("Message from C# DLL");
            callbackFunction(DllEVENT, 1);
        }
    }
}
