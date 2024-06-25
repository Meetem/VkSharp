using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPipelineIndirectMemoryRequirementsNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkComputePipelineCreateInfo, ref VkMemoryRequirements2, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkComputePipelineCreateInfo, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPipelineIndirectMemoryRequirementsNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkComputePipelineCreateInfo, ref VkMemoryRequirements2, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPipelineIndirectMemoryRequirementsNV(delegate *unmanaged[Cdecl]<VkDevice, in VkComputePipelineCreateInfo, ref VkMemoryRequirements2, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPipelineIndirectMemoryRequirementsNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPipelineIndirectMemoryRequirementsNV(VkFunctionPointer v) => new PFN_vkGetPipelineIndirectMemoryRequirementsNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPipelineIndirectMemoryRequirementsNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPipelineIndirectMemoryRequirementsNV(void* v) => new PFN_vkGetPipelineIndirectMemoryRequirementsNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkComputePipelineCreateInfo pCreateInfo, ref VkMemoryRequirements2 pMemoryRequirements)
        {
            this.ptr(device, in pCreateInfo, ref pMemoryRequirements);
        }
    }
}
