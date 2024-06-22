using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateMicromapEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapCreateInfoEXT, in VkAllocationCallbacks, ref VkMicromapEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapCreateInfoEXT, in VkAllocationCallbacks, ref VkMicromapEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateMicromapEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapCreateInfoEXT, in VkAllocationCallbacks, ref VkMicromapEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateMicromapEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkMicromapCreateInfoEXT, in VkAllocationCallbacks, ref VkMicromapEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateMicromapEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateMicromapEXT(VkFunctionPointer v) => new PFN_vkCreateMicromapEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateMicromapEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateMicromapEXT(void* v) => new PFN_vkCreateMicromapEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkMicromapCreateInfoEXT pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkMicromapEXT pMicromap)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pMicromap);
        }
    }
}
