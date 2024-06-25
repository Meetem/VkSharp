using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateDescriptorSetLayout : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, in VkAllocationCallbacks, ref VkDescriptorSetLayout, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, in VkAllocationCallbacks, ref VkDescriptorSetLayout, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDescriptorSetLayout(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, in VkAllocationCallbacks, ref VkDescriptorSetLayout, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateDescriptorSetLayout(delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, in VkAllocationCallbacks, ref VkDescriptorSetLayout, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateDescriptorSetLayout v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDescriptorSetLayout(VkFunctionPointer v) => new PFN_vkCreateDescriptorSetLayout(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateDescriptorSetLayout v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateDescriptorSetLayout(void* v) => new PFN_vkCreateDescriptorSetLayout(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkDescriptorSetLayoutCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkDescriptorSetLayout pSetLayout)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pSetLayout);
        }
    }
}
