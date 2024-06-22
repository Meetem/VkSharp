using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdSetFragmentShadingRateKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkExtent2D, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkExtent2D, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetFragmentShadingRateKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkExtent2D, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetFragmentShadingRateKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkExtent2D, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdSetFragmentShadingRateKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetFragmentShadingRateKHR(VkFunctionPointer v) => new PFN_vkCmdSetFragmentShadingRateKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdSetFragmentShadingRateKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetFragmentShadingRateKHR(void* v) => new PFN_vkCmdSetFragmentShadingRateKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkExtent2D pFragmentSize, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps)
        {
            this.ptr(commandBuffer, in pFragmentSize, combinerOps);
        }
    }
}
