using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateShadersEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, VkShaderCreateInfoEXT*, in VkAllocationCallbacks, ref VkShaderEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkShaderCreateInfoEXT*, in VkAllocationCallbacks, ref VkShaderEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateShadersEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkShaderCreateInfoEXT*, in VkAllocationCallbacks, ref VkShaderEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateShadersEXT(delegate *unmanaged[Cdecl]<VkDevice, uint, VkShaderCreateInfoEXT*, in VkAllocationCallbacks, ref VkShaderEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateShadersEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateShadersEXT(VkFunctionPointer v) => new PFN_vkCreateShadersEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateShadersEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateShadersEXT(void* v) => new PFN_vkCreateShadersEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint createInfoCount, VkShaderCreateInfoEXT* pCreateInfos, in VkAllocationCallbacks pAllocator, ref VkShaderEXT pShaders)
        {
            return this.ptr(device, createInfoCount, pCreateInfos, in pAllocator, ref pShaders);
        }
    }
}
