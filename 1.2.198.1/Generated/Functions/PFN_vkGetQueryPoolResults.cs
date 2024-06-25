using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetQueryPoolResults : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, ulong, void*, ulong, VkQueryResultFlags, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, ulong, void*, ulong, VkQueryResultFlags, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetQueryPoolResults(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, ulong, void*, ulong, VkQueryResultFlags, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetQueryPoolResults(delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, ulong, void*, ulong, VkQueryResultFlags, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetQueryPoolResults v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetQueryPoolResults(VkFunctionPointer v) => new PFN_vkGetQueryPoolResults(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetQueryPoolResults v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetQueryPoolResults(void* v) => new PFN_vkGetQueryPoolResults(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount, ulong dataSize, void* pData, ulong stride, VkQueryResultFlags flags)
        {
            return this.ptr(device, queryPool, firstQuery, queryCount, dataSize, pData, stride, flags);
        }
    }
}
