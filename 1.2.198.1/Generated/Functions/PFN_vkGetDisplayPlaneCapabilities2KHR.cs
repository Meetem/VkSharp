using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDisplayPlaneCapabilities2KHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDisplayPlaneCapabilities2KHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDisplayPlaneCapabilities2KHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, in VkDisplayPlaneInfo2KHR, ref VkDisplayPlaneCapabilities2KHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDisplayPlaneCapabilities2KHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDisplayPlaneCapabilities2KHR(VkFunctionPointer v) => new PFN_vkGetDisplayPlaneCapabilities2KHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDisplayPlaneCapabilities2KHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDisplayPlaneCapabilities2KHR(void* v) => new PFN_vkGetDisplayPlaneCapabilities2KHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, in VkDisplayPlaneInfo2KHR pDisplayPlaneInfo, ref VkDisplayPlaneCapabilities2KHR pCapabilities)
        {
            return this.ptr(physicalDevice, in pDisplayPlaneInfo, ref pCapabilities);
        }
    }
}
