using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Instance)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateDisplayPlaneSurfaceKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkInstance, in VkDisplaySurfaceCreateInfoKHR, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, in VkDisplaySurfaceCreateInfoKHR, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDisplayPlaneSurfaceKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkInstance, in VkDisplaySurfaceCreateInfoKHR, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDisplayPlaneSurfaceKHR(delegate *unmanaged[Cdecl]<VkInstance, in VkDisplaySurfaceCreateInfoKHR, in VkAllocationCallbacks, ref VkSurfaceKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateDisplayPlaneSurfaceKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDisplayPlaneSurfaceKHR(VkFunctionPointer v) => new PFN_vkCreateDisplayPlaneSurfaceKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateDisplayPlaneSurfaceKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDisplayPlaneSurfaceKHR(void* v) => new PFN_vkCreateDisplayPlaneSurfaceKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkInstance instance, in VkDisplaySurfaceCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkSurfaceKHR pSurface)
        {
            return this.ptr(instance, in pCreateInfo, in pAllocator, ref pSurface);
        }
    }
}
