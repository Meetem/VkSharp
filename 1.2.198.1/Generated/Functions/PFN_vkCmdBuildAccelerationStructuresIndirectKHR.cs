using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdBuildAccelerationStructuresIndirectKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, in ulong, in uint, in uint*, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, in ulong, in uint, in uint*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBuildAccelerationStructuresIndirectKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, in ulong, in uint, in uint*, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBuildAccelerationStructuresIndirectKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureBuildGeometryInfoKHR*, in ulong, in uint, in uint*, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdBuildAccelerationStructuresIndirectKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBuildAccelerationStructuresIndirectKHR(VkFunctionPointer v) => new PFN_vkCmdBuildAccelerationStructuresIndirectKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdBuildAccelerationStructuresIndirectKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBuildAccelerationStructuresIndirectKHR(void* v) => new PFN_vkCmdBuildAccelerationStructuresIndirectKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, uint infoCount, VkAccelerationStructureBuildGeometryInfoKHR* pInfos, in ulong pIndirectDeviceAddresses, in uint pIndirectStrides, in uint* ppMaxPrimitiveCounts)
        {
            this.ptr(commandBuffer, infoCount, pInfos, in pIndirectDeviceAddresses, in pIndirectStrides, in ppMaxPrimitiveCounts);
        }
    }
}
