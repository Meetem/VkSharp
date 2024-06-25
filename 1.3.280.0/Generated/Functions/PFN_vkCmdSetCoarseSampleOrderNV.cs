using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdSetCoarseSampleOrderNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetCoarseSampleOrderNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdSetCoarseSampleOrderNV(delegate *unmanaged[Cdecl]<VkCommandBuffer, VkCoarseSampleOrderTypeNV, uint, VkCoarseSampleOrderCustomNV*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdSetCoarseSampleOrderNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetCoarseSampleOrderNV(VkFunctionPointer v) => new PFN_vkCmdSetCoarseSampleOrderNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdSetCoarseSampleOrderNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdSetCoarseSampleOrderNV(void* v) => new PFN_vkCmdSetCoarseSampleOrderNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, VkCoarseSampleOrderTypeNV sampleOrderType, uint customSampleOrderCount, VkCoarseSampleOrderCustomNV* pCustomSampleOrders)
        {
            this.ptr(commandBuffer, sampleOrderType, customSampleOrderCount, pCustomSampleOrders);
        }
    }
}
