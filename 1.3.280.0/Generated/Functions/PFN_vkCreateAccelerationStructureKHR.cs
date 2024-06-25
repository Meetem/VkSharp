using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateAccelerationStructureKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoKHR, in VkAllocationCallbacks, ref VkAccelerationStructureKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoKHR, in VkAllocationCallbacks, ref VkAccelerationStructureKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateAccelerationStructureKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoKHR, in VkAllocationCallbacks, ref VkAccelerationStructureKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateAccelerationStructureKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoKHR, in VkAllocationCallbacks, ref VkAccelerationStructureKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateAccelerationStructureKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateAccelerationStructureKHR(VkFunctionPointer v) => new PFN_vkCreateAccelerationStructureKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateAccelerationStructureKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateAccelerationStructureKHR(void* v) => new PFN_vkCreateAccelerationStructureKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkAccelerationStructureCreateInfoKHR pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkAccelerationStructureKHR pAccelerationStructure)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pAccelerationStructure);
        }
    }
}
