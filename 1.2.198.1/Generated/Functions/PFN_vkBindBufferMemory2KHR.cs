using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkBindBufferMemory2KHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBindBufferMemory2KHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkBindBufferMemory2KHR(delegate *unmanaged[Cdecl]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkBindBufferMemory2KHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBindBufferMemory2KHR(VkFunctionPointer v) => new PFN_vkBindBufferMemory2KHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkBindBufferMemory2KHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkBindBufferMemory2KHR(void* v) => new PFN_vkBindBufferMemory2KHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint bindInfoCount, VkBindBufferMemoryInfo* pBindInfos)
        {
            return this.ptr(device, bindInfoCount, pBindInfos);
        }
    }
}
