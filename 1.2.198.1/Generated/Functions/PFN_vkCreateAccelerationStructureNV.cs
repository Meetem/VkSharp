using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateAccelerationStructureNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoNV, in VkAllocationCallbacks, ref VkAccelerationStructureNV, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoNV, in VkAllocationCallbacks, ref VkAccelerationStructureNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateAccelerationStructureNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoNV, in VkAllocationCallbacks, ref VkAccelerationStructureNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateAccelerationStructureNV(delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureCreateInfoNV, in VkAllocationCallbacks, ref VkAccelerationStructureNV, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateAccelerationStructureNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateAccelerationStructureNV(VkFunctionPointer v) => new PFN_vkCreateAccelerationStructureNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateAccelerationStructureNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateAccelerationStructureNV(void* v) => new PFN_vkCreateAccelerationStructureNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkAccelerationStructureCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkAccelerationStructureNV pAccelerationStructure)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pAccelerationStructure);
        }
    }
}
