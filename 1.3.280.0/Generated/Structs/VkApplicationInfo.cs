using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkApplicationInfo
    {
        public VkStructureType sType;
        public void* pNext;
        public byte* pApplicationName;
        public uint applicationVersion;
        public byte* pEngineName;
        public uint engineVersion;
        public uint apiVersion;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_APPLICATION_INFO;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkApplicationInfo Create()
        {
            VkApplicationInfo ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
