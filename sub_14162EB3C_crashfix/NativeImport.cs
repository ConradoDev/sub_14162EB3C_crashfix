namespace sub_14166072C_crashfix
{
    using System.Runtime.InteropServices;

    public static class NativeImport
    {
        const string Library = "kernel32.dll";

        [DllImport(Library)]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport(Library, SetLastError = true)]
        public static extern bool WriteProcessMemory(int hProcess, nint lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

        [DllImport(Library)]
        public static extern bool CloseHandle(IntPtr hObject);
    }
}