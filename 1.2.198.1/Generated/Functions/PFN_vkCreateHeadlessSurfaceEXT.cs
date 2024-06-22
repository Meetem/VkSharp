using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateHeadlessSurfaceEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, in VkHeadlessSurfaceCreateInfoEXT, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, in VkHeadlessSurfaceCreateInfoEXT, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateHeadlessSurfaceEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, in VkHeadlessSurfaceCreateInfoEXT, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateHeadlessSurfaceEXT(delegate *unmanaged[Cdecl]<VkInstance, in VkHeadlessSurfaceCreateInfoEXT, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateHeadlessSurfaceEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateHeadlessSurfaceEXT(VkFunctionPointer v) => new PFN_vkCreateHeadlessSurfaceEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateHeadlessSurfaceEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateHeadlessSurfaceEXT(void* v) => new PFN_vkCreateHeadlessSurfaceEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkInstance instance, in VkHeadlessSurfaceCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSurfaceKHR pSurface)
        {
            return this.ptr(instance, in pCreateInfo, in pAllocator, ref pSurface);
        }
    }
}
