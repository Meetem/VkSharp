using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkDestroyShaderModule : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkShaderModule, in VkAllocationCallbacks, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkShaderModule, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyShaderModule(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkShaderModule, in VkAllocationCallbacks, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkDestroyShaderModule(delegate *unmanaged[Cdecl]<VkDevice, VkShaderModule, in VkAllocationCallbacks, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkDestroyShaderModule v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyShaderModule(VkFunctionPointer v) => new PFN_vkDestroyShaderModule(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkDestroyShaderModule v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkDestroyShaderModule(void* v) => new PFN_vkDestroyShaderModule(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkShaderModule shaderModule, in VkAllocationCallbacks pAllocator)
        {
            this.ptr(device, shaderModule, in pAllocator);
        }
    }
}
