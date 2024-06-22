using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkMutableDescriptorTypeListVALVE
    {
        public uint descriptorTypeCount;
        public VkDescriptorType* pDescriptorTypes;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkMutableDescriptorTypeListVALVE Create()
        {
            return default;
        }
        
    }
}
