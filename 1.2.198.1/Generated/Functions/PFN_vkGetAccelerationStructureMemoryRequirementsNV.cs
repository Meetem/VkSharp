using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetAccelerationStructureMemoryRequirementsNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureMemoryRequirementsNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetAccelerationStructureMemoryRequirementsNV(delegate *unmanaged[Cdecl]<VkDevice, in VkAccelerationStructureMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetAccelerationStructureMemoryRequirementsNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureMemoryRequirementsNV(VkFunctionPointer v) => new PFN_vkGetAccelerationStructureMemoryRequirementsNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetAccelerationStructureMemoryRequirementsNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetAccelerationStructureMemoryRequirementsNV(void* v) => new PFN_vkGetAccelerationStructureMemoryRequirementsNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkAccelerationStructureMemoryRequirementsInfoNV pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            this.ptr(device, in pInfo, ref pMemoryRequirements);
        }
    }
}
