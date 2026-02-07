using System;
using System.Runtime.InteropServices;

namespace Fleck.Helpers
{
    internal static class FleckRuntime
    {
        public static bool IsRunningOnMono()
        {
            return !OperatingSystem.IsWindows();
        }

        public static bool IsRunningOnWindows()
        {
#if NET45 || NET40
            return true;
#else
            return (RuntimeInformation.IsOSPlatform(OSPlatform.Windows));
#endif
        }
    }
}