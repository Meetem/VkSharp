using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdSetFragmentShadingRateEnumNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkFragmentShadingRateNV, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkFragmentShadingRateNV, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetFragmentShadingRateEnumNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkFragmentShadingRateNV, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetFragmentShadingRateEnumNV(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkFragmentShadingRateNV, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdSetFragmentShadingRateEnumNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetFragmentShadingRateEnumNV(VkFunctionPointer v) => new PFN_vkCmdSetFragmentShadingRateEnumNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdSetFragmentShadingRateEnumNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetFragmentShadingRateEnumNV(void* v) => new PFN_vkCmdSetFragmentShadingRateEnumNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkFragmentShadingRateNV shadingRate, FixedArrayVkFragmentShadingRateCombinerOpKHRSize2 combinerOps)
        {
            this.ptr(commandBuffer, shadingRate, combinerOps);
        }
    }
}
