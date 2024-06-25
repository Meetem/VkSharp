using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetValidationCacheDataEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, ref ulong, void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, ref ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetValidationCacheDataEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, ref ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetValidationCacheDataEXT(delegate *unmanaged[Cdecl]<VkDevice, VkValidationCacheEXT, ref ulong, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetValidationCacheDataEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetValidationCacheDataEXT(VkFunctionPointer v) => new PFN_vkGetValidationCacheDataEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetValidationCacheDataEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetValidationCacheDataEXT(void* v) => new PFN_vkGetValidationCacheDataEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkValidationCacheEXT validationCache, ref ulong pDataSize, void* pData)
        {
            return this.ptr(device, validationCache, ref pDataSize, pData);
        }
    }
}
