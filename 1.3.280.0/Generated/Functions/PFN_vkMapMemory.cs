using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkMapMemory : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlags, ref void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlags, ref void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkMapMemory(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlags, ref void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkMapMemory(delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, ulong, ulong, VkMemoryMapFlags, ref void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkMapMemory v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkMapMemory(VkFunctionPointer v) => new PFN_vkMapMemory(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkMapMemory v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkMapMemory(void* v) => new PFN_vkMapMemory(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkDeviceMemory memory, ulong offset, ulong size, VkMemoryMapFlags flags, ref void* ppData)
        {
            return this.ptr(device, memory, offset, size, flags, ref ppData);
        }
    }
}
