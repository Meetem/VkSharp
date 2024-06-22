using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateShaderModule : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, in VkAllocationCallbacks, ref VkShaderModule, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, in VkAllocationCallbacks, ref VkShaderModule, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateShaderModule(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, in VkAllocationCallbacks, ref VkShaderModule, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateShaderModule(delegate *unmanaged[Cdecl]<VkDevice, in VkShaderModuleCreateInfo, in VkAllocationCallbacks, ref VkShaderModule, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateShaderModule v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateShaderModule(VkFunctionPointer v) => new PFN_vkCreateShaderModule(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateShaderModule v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateShaderModule(void* v) => new PFN_vkCreateShaderModule(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkShaderModuleCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkShaderModule pShaderModule)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pShaderModule);
        }
    }
}
