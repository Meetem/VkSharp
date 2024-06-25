using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateCuModuleNVX : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkCuModuleCreateInfoNVX, in VkAllocationCallbacks, ref VkCuModuleNVX, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCuModuleCreateInfoNVX, in VkAllocationCallbacks, ref VkCuModuleNVX, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCuModuleNVX(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCuModuleCreateInfoNVX, in VkAllocationCallbacks, ref VkCuModuleNVX, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCuModuleNVX(delegate *unmanaged[Cdecl]<VkDevice, in VkCuModuleCreateInfoNVX, in VkAllocationCallbacks, ref VkCuModuleNVX, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateCuModuleNVX v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCuModuleNVX(VkFunctionPointer v) => new PFN_vkCreateCuModuleNVX(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateCuModuleNVX v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCuModuleNVX(void* v) => new PFN_vkCreateCuModuleNVX(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkCuModuleCreateInfoNVX pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCuModuleNVX pModule)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pModule);
        }
    }
}
