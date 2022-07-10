using System.Runtime.InteropServices;
using System.Text;

namespace calc {
    internal static class NativeMethods {


        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern uint GetPrivateProfileString(
            [In] string lpAppName,
            [In] string lpKeyName,
            [In] string lpDefault,
            [Out] /*[MarshalAs(UnmanagedType.LPTStr)] string */ StringBuilder lpReturnedString,
            [In] uint Size,
            [In] string lpFilePath
        );

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        internal static extern bool WritePrivateProfileString(
            [In] string lpAppName,
            [In] string lpKeyName,
            [In] string lpString,
            [In] string lpFileName
        );

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr LoadCursor(
            [In, Optional] IntPtr hInstance,
            [In] IntPtr lpCursorName
        );

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        internal static extern IntPtr SetCursor(
            [In, Optional] IntPtr hCursor
        );

    }
}
