using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetBindingReferenceVALVE, ref VkDescriptorSetLayoutHostMappingInfoVALVE, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetBindingReferenceVALVE, ref VkDescriptorSetLayoutHostMappingInfoVALVE, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetBindingReferenceVALVE, ref VkDescriptorSetLayoutHostMappingInfoVALVE, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE(delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetBindingReferenceVALVE, ref VkDescriptorSetLayoutHostMappingInfoVALVE, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE(VkFunctionPointer v) => new PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE(void* v) => new PFN_vkGetDescriptorSetLayoutHostMappingInfoVALVE(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkDescriptorSetBindingReferenceVALVE pBindingReference, ref VkDescriptorSetLayoutHostMappingInfoVALVE pHostMapping)
        {
            this.ptr(device, in pBindingReference, ref pHostMapping);
        }
    }
}
