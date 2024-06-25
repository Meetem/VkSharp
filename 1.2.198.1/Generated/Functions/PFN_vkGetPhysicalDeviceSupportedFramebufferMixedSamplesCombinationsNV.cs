using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Unknown)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkFramebufferMixedSamplesCombinationNV*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkFramebufferMixedSamplesCombinationNV*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkFramebufferMixedSamplesCombinationNV*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(delegate *unmanaged[Cdecl]<VkPhysicalDevice, ref uint, VkFramebufferMixedSamplesCombinationNV*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(VkFunctionPointer v) => new PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(void* v) => new PFN_vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkPhysicalDevice physicalDevice, ref uint pCombinationCount, VkFramebufferMixedSamplesCombinationNV* pCombinations)
        {
            return this.ptr(physicalDevice, ref pCombinationCount, pCombinations);
        }
    }
}
