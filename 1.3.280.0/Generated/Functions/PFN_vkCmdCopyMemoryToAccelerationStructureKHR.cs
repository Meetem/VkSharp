using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdCopyMemoryToAccelerationStructureKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkCopyMemoryToAccelerationStructureInfoKHR, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkCopyMemoryToAccelerationStructureInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyMemoryToAccelerationStructureKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkCopyMemoryToAccelerationStructureInfoKHR, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdCopyMemoryToAccelerationStructureKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkCopyMemoryToAccelerationStructureInfoKHR, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdCopyMemoryToAccelerationStructureKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyMemoryToAccelerationStructureKHR(VkFunctionPointer v) => new PFN_vkCmdCopyMemoryToAccelerationStructureKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdCopyMemoryToAccelerationStructureKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdCopyMemoryToAccelerationStructureKHR(void* v) => new PFN_vkCmdCopyMemoryToAccelerationStructureKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkCopyMemoryToAccelerationStructureInfoKHR pInfo)
        {
            this.ptr(commandBuffer, in pInfo);
        }
    }
}
