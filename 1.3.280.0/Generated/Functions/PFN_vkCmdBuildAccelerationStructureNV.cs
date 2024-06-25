using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdBuildAccelerationStructureNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkAccelerationStructureInfoNV, VkBuffer, ulong, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkAccelerationStructureInfoNV, VkBuffer, ulong, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBuildAccelerationStructureNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkAccelerationStructureInfoNV, VkBuffer, ulong, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBuildAccelerationStructureNV(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkAccelerationStructureInfoNV, VkBuffer, ulong, VkBool32, VkAccelerationStructureNV, VkAccelerationStructureNV, VkBuffer, ulong, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdBuildAccelerationStructureNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBuildAccelerationStructureNV(VkFunctionPointer v) => new PFN_vkCmdBuildAccelerationStructureNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdBuildAccelerationStructureNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBuildAccelerationStructureNV(void* v) => new PFN_vkCmdBuildAccelerationStructureNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkAccelerationStructureInfoNV pInfo, VkBuffer instanceData, ulong instanceOffset, VkBool32 update, VkAccelerationStructureNV dst, VkAccelerationStructureNV src, VkBuffer scratch, ulong scratchOffset)
        {
            this.ptr(commandBuffer, in pInfo, instanceData, instanceOffset, update, dst, src, scratch, scratchOffset);
        }
    }
}
