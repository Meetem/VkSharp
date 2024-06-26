using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateCuFunctionNVX : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkCuFunctionCreateInfoNVX, in VkAllocationCallbacks, ref VkCuFunctionNVX, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCuFunctionCreateInfoNVX, in VkAllocationCallbacks, ref VkCuFunctionNVX, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCuFunctionNVX(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkCuFunctionCreateInfoNVX, in VkAllocationCallbacks, ref VkCuFunctionNVX, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateCuFunctionNVX(delegate *unmanaged[Cdecl]<VkDevice, in VkCuFunctionCreateInfoNVX, in VkAllocationCallbacks, ref VkCuFunctionNVX, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateCuFunctionNVX v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCuFunctionNVX(VkFunctionPointer v) => new PFN_vkCreateCuFunctionNVX(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateCuFunctionNVX v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateCuFunctionNVX(void* v) => new PFN_vkCreateCuFunctionNVX(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkCuFunctionCreateInfoNVX pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkCuFunctionNVX pFunction)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pFunction);
        }
    }
}
