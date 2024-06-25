using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateDescriptorUpdateTemplate : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorUpdateTemplateCreateInfo, in VkAllocationCallbacks, ref VkDescriptorUpdateTemplate, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorUpdateTemplateCreateInfo, in VkAllocationCallbacks, ref VkDescriptorUpdateTemplate, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDescriptorUpdateTemplate(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorUpdateTemplateCreateInfo, in VkAllocationCallbacks, ref VkDescriptorUpdateTemplate, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDescriptorUpdateTemplate(delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorUpdateTemplateCreateInfo, in VkAllocationCallbacks, ref VkDescriptorUpdateTemplate, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateDescriptorUpdateTemplate v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDescriptorUpdateTemplate(VkFunctionPointer v) => new PFN_vkCreateDescriptorUpdateTemplate(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateDescriptorUpdateTemplate v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDescriptorUpdateTemplate(void* v) => new PFN_vkCreateDescriptorUpdateTemplate(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkDescriptorUpdateTemplateCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorUpdateTemplate pDescriptorUpdateTemplate)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pDescriptorUpdateTemplate);
        }
    }
}
