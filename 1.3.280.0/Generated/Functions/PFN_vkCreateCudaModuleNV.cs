using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateCudaModuleNV : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkCudaModuleCreateInfoNV, in VkAllocationCallbacks, ref VkCudaModuleNV, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCudaModuleCreateInfoNV, in VkAllocationCallbacks, ref VkCudaModuleNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCudaModuleNV(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCudaModuleCreateInfoNV, in VkAllocationCallbacks, ref VkCudaModuleNV, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCudaModuleNV(delegate *unmanaged[Cdecl]<VkDevice, in VkCudaModuleCreateInfoNV, in VkAllocationCallbacks, ref VkCudaModuleNV, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateCudaModuleNV v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCudaModuleNV(VkFunctionPointer v) => new PFN_vkCreateCudaModuleNV(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateCudaModuleNV v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCudaModuleNV(void* v) => new PFN_vkCreateCudaModuleNV(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkCudaModuleCreateInfoNV pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCudaModuleNV pModule)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pModule);
        }
    }
}
