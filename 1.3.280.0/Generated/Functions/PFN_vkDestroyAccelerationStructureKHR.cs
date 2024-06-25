using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDestroyAccelerationStructureKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, in VkAllocationCallbacks, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyAccelerationStructureKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyAccelerationStructureKHR(delegate *unmanaged[Cdecl]<VkDevice, VkAccelerationStructureKHR, in VkAllocationCallbacks, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDestroyAccelerationStructureKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyAccelerationStructureKHR(VkFunctionPointer v) => new PFN_vkDestroyAccelerationStructureKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDestroyAccelerationStructureKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyAccelerationStructureKHR(void* v) => new PFN_vkDestroyAccelerationStructureKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkAccelerationStructureKHR accelerationStructure, in VkAllocationCallbacks pAllocator)
        {
            this.ptr(device, accelerationStructure, in pAllocator);
        }
    }
}
