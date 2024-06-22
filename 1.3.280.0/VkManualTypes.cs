using System.Runtime.InteropServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public struct VkRemoteAddressNV
    {
        public unsafe void* address;
    }
}