using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDescriptorSetLayoutSupport : IVkFuncPtr
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
        public PFN_vkGetDescriptorSetLayoutSupport(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDescriptorSetLayoutSupport(delegate *unmanaged[Cdecl]<VkDevice, in VkDescriptorSetLayoutCreateInfo, ref VkDescriptorSetLayoutSupport, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDescriptorSetLayoutSupport v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDescriptorSetLayoutSupport(VkFunctionPointer v) => new PFN_vkGetDescriptorSetLayoutSupport(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDescriptorSetLayoutSupport v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDescriptorSetLayoutSupport(void* v) => new PFN_vkGetDescriptorSetLayoutSupport(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, in VkDescriptorSetLayoutCreateInfo pCreateInfo, ref VkDescriptorSetLayoutSupport pSupport)
        {
            this.ptr(device, in pCreateInfo, ref pSupport);
        }
    }
}
