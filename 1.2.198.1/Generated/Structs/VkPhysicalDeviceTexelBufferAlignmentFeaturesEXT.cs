using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 texelBufferAlignment;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TEXEL_BUFFER_ALIGNMENT_FEATURES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT Create()
        {
            VkPhysicalDeviceTexelBufferAlignmentFeaturesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T GetNextRef<T>(out bool isNull)
        	where T: unmanaged
        {
            isNull = pNext == null;
            return ref VkUnsafe.PtrToRef<T>(pNext);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T* GetNext<T>()
        	where T: unmanaged
        {
            return (T*)pNext;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetNext<T>(ref T next)
        	where T: unmanaged
        {
            pNext = VkUnsafe.RefToPtr<T>(ref next);
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetNextNull()
        {
            pNext = null;
        }
    }
}
