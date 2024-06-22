using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDeviceAddressBindingCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDeviceAddressBindingFlagsEXT flags;
        public ulong baseAddress;
        public ulong size;
        public VkDeviceAddressBindingTypeEXT bindingType;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEVICE_ADDRESS_BINDING_CALLBACK_DATA_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDeviceAddressBindingCallbackDataEXT Create()
        {
            VkDeviceAddressBindingCallbackDataEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
