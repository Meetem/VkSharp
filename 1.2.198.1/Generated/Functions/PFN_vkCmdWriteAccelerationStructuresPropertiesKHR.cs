using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdWriteAccelerationStructuresPropertiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkAccelerationStructureKHR*, VkQueryType, VkQueryPool, uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdWriteAccelerationStructuresPropertiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(VkFunctionPointer v) => new PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdWriteAccelerationStructuresPropertiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(void* v) => new PFN_vkCmdWriteAccelerationStructuresPropertiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, uint accelerationStructureCount, VkAccelerationStructureKHR* pAccelerationStructures, VkQueryType queryType, VkQueryPool queryPool, uint firstQuery)
        {
            this.ptr(commandBuffer, accelerationStructureCount, pAccelerationStructures, queryType, queryPool, firstQuery);
        }
    }
}
