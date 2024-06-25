using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetMemoryFdPropertiesKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, int, ref VkMemoryFdPropertiesKHR, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, int, ref VkMemoryFdPropertiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMemoryFdPropertiesKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, int, ref VkMemoryFdPropertiesKHR, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMemoryFdPropertiesKHR(delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, int, ref VkMemoryFdPropertiesKHR, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetMemoryFdPropertiesKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMemoryFdPropertiesKHR(VkFunctionPointer v) => new PFN_vkGetMemoryFdPropertiesKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetMemoryFdPropertiesKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMemoryFdPropertiesKHR(void* v) => new PFN_vkGetMemoryFdPropertiesKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, int fd, ref VkMemoryFdPropertiesKHR pMemoryFdProperties)
        {
            return this.ptr(device, handleType, fd, ref pMemoryFdProperties);
        }
    }
}
