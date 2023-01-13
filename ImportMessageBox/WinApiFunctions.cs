using System;
using System.Runtime.InteropServices;


namespace ImportMessageBox
{
    internal static class WinApiFunctions
    {
        internal class Constants
        {
            public const uint MB_YESNO = (uint)0x00000004L;
            public const uint MB_ICONQUESTION = (uint)0x00000020L;
            public const int IDYES = 6;
        }
        
        
        //Опишем функцию, которую будем вызывать из DLL
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr hWnd, string message, string caption, uint decoration);

    }
}
