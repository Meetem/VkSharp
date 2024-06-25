using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetMemoryHostPointerPropertiesEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, ref VkMemoryHostPointerPropertiesEXT, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, ref VkMemoryHostPointerPropertiesEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMemoryHostPointerPropertiesEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, ref VkMemoryHostPointerPropertiesEXT, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetMemoryHostPointerPropertiesEXT(delegate *unmanaged[Cdecl]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, ref VkMemoryHostPointerPropertiesEXT, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetMemoryHostPointerPropertiesEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMemoryHostPointerPropertiesEXT(VkFunctionPointer v) => new PFN_vkGetMemoryHostPointerPropertiesEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetMemoryHostPointerPropertiesEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetMemoryHostPointerPropertiesEXT(void* v) => new PFN_vkGetMemoryHostPointerPropertiesEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkExternalMemoryHandleTypeFlags handleType, void* pHostPointer, ref VkMemoryHostPointerPropertiesEXT pMemoryHostPointerProperties)
        {
            return this.ptr(device, handleType, pHostPointer, ref pMemoryHostPointerProperties);
        }
    }
}
