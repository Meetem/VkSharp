using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDisplayPlaneSupportedDisplaysKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkDisplayKHR*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkDisplayKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDisplayPlaneSupportedDisplaysKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkDisplayKHR*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDisplayPlaneSupportedDisplaysKHR(delegate *unmanaged[Cdecl]<VkPhysicalDevice, uint, ref uint, VkDisplayKHR*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDisplayPlaneSupportedDisplaysKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDisplayPlaneSupportedDisplaysKHR(VkFunctionPointer v) => new PFN_vkGetDisplayPlaneSupportedDisplaysKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDisplayPlaneSupportedDisplaysKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDisplayPlaneSupportedDisplaysKHR(void* v) => new PFN_vkGetDisplayPlaneSupportedDisplaysKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, uint planeIndex, ref uint pDisplayCount, VkDisplayKHR* pDisplays)
        {
            return this.ptr(physicalDevice, planeIndex, ref pDisplayCount, pDisplays);
        }
    }
}
