using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDescriptorSetLayoutSupportKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDescriptorSetLayoutSupportKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDescriptorSetLayoutSupportKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDescriptorSetLayoutSupportKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDescriptorSetLayoutSupportKHR(VkFunctionPointer v) => new PFN_vkGetDescriptorSetLayoutSupportKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDescriptorSetLayoutSupportKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDescriptorSetLayoutSupportKHR(void* v) => new PFN_vkGetDescriptorSetLayoutSupportKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkDescriptorSetLayoutCreateInfo pCreateInfo, ref VkDescriptorSetLayoutSupport pSupport)
        {
            this.ptr(device, in pCreateInfo, ref pSupport);
        }
    }
}
