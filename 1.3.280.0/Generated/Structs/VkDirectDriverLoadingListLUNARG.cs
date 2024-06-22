using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDirectDriverLoadingListLUNARG
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDirectDriverLoadingModeLUNARG mode;
        public uint driverCount;
        public VkDirectDriverLoadingInfoLUNARG* pDrivers;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DIRECT_DRIVER_LOADING_LIST_LUNARG;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDirectDriverLoadingListLUNARG Create()
        {
            VkDirectDriverLoadingListLUNARG ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
