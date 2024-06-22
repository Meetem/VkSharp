using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateValidationCacheEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkValidationCacheCreateInfoEXT, in VkAllocationCallbacks, ref VkValidationCacheEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkValidationCacheCreateInfoEXT, in VkAllocationCallbacks, ref VkValidationCacheEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateValidationCacheEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkValidationCacheCreateInfoEXT, in VkAllocationCallbacks, ref VkValidationCacheEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateValidationCacheEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkValidationCacheCreateInfoEXT, in VkAllocationCallbacks, ref VkValidationCacheEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateValidationCacheEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateValidationCacheEXT(VkFunctionPointer v) => new PFN_vkCreateValidationCacheEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateValidationCacheEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateValidationCacheEXT(void* v) => new PFN_vkCreateValidationCacheEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkValidationCacheCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkValidationCacheEXT pValidationCache)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pValidationCache);
        }
    }
}
