using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateDisplayModeKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, in VkDisplayModeCreateInfoKHR, in VkAllocationCallbacks, ref VkDisplayModeKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, in VkDisplayModeCreateInfoKHR, in VkAllocationCallbacks, ref VkDisplayModeKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDisplayModeKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, in VkDisplayModeCreateInfoKHR, in VkAllocationCallbacks, ref VkDisplayModeKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDisplayModeKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, VkDisplayKHR, in VkDisplayModeCreateInfoKHR, in VkAllocationCallbacks, ref VkDisplayModeKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateDisplayModeKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDisplayModeKHR(VkFunctionPointer v) => new PFN_vkCreateDisplayModeKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateDisplayModeKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDisplayModeKHR(void* v) => new PFN_vkCreateDisplayModeKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, VkDisplayKHR display, in VkDisplayModeCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDisplayModeKHR pMode)
        {
            return this.ptr(physicalDevice, display, in pCreateInfo, in pAllocator, ref pMode);
        }
    }
}
