using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkImageDrmFormatModifierExplicitCreateInfoEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public ulong drmFormatModifier;
        public uint drmFormatModifierPlaneCount;
        public VkSubresourceLayout* pPlaneLayouts;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_IMAGE_DRM_FORMAT_MODIFIER_EXPLICIT_CREATE_INFO_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkImageDrmFormatModifierExplicitCreateInfoEXT Create()
        {
            VkImageDrmFormatModifierExplicitCreateInfoEXT ret = default;
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
