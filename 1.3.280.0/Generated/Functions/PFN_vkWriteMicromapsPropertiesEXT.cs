using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkWriteMicromapsPropertiesEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, VkMicromapEXT*, VkQueryType, ulong, void*, ulong, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkMicromapEXT*, VkQueryType, ulong, void*, ulong, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkWriteMicromapsPropertiesEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkMicromapEXT*, VkQueryType, ulong, void*, ulong, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkWriteMicromapsPropertiesEXT(delegate *unmanaged[Cdecl]<VkDevice, uint, VkMicromapEXT*, VkQueryType, ulong, void*, ulong, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkWriteMicromapsPropertiesEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkWriteMicromapsPropertiesEXT(VkFunctionPointer v) => new PFN_vkWriteMicromapsPropertiesEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkWriteMicromapsPropertiesEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkWriteMicromapsPropertiesEXT(void* v) => new PFN_vkWriteMicromapsPropertiesEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint micromapCount, VkMicromapEXT* pMicromaps, VkQueryType queryType, ulong dataSize, void* pData, ulong stride)
        {
            return this.ptr(device, micromapCount, pMicromaps, queryType, dataSize, pData, stride);
        }
    }
}
