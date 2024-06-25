using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetGeneratedCommandsMemoryRequirementsNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkGeneratedCommandsMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkGeneratedCommandsMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetGeneratedCommandsMemoryRequirementsNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkGeneratedCommandsMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetGeneratedCommandsMemoryRequirementsNV(delegate *unmanaged[Cdecl]<VkDevice, in VkGeneratedCommandsMemoryRequirementsInfoNV, ref VkMemoryRequirements2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetGeneratedCommandsMemoryRequirementsNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetGeneratedCommandsMemoryRequirementsNV(VkFunctionPointer v) => new PFN_vkGetGeneratedCommandsMemoryRequirementsNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetGeneratedCommandsMemoryRequirementsNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetGeneratedCommandsMemoryRequirementsNV(void* v) => new PFN_vkGetGeneratedCommandsMemoryRequirementsNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkGeneratedCommandsMemoryRequirementsInfoNV pInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            this.ptr(device, in pInfo, ref pMemoryRequirements);
        }
    }
}
