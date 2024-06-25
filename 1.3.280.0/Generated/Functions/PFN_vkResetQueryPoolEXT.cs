using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkResetQueryPoolEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkResetQueryPoolEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkResetQueryPoolEXT(delegate *unmanaged[Cdecl]<VkDevice, VkQueryPool, uint, uint, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkResetQueryPoolEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkResetQueryPoolEXT(VkFunctionPointer v) => new PFN_vkResetQueryPoolEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkResetQueryPoolEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkResetQueryPoolEXT(void* v) => new PFN_vkResetQueryPoolEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkQueryPool queryPool, uint firstQuery, uint queryCount)
        {
            this.ptr(device, queryPool, firstQuery, queryCount);
        }
    }
}
