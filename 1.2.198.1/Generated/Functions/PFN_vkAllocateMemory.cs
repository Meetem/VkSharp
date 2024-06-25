using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkAllocateMemory : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryAllocateInfo, in VkAllocationCallbacks, ref VkDeviceMemory, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryAllocateInfo, in VkAllocationCallbacks, ref VkDeviceMemory, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAllocateMemory(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryAllocateInfo, in VkAllocationCallbacks, ref VkDeviceMemory, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAllocateMemory(delegate *unmanaged[Cdecl]<VkDevice, in VkMemoryAllocateInfo, in VkAllocationCallbacks, ref VkDeviceMemory, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkAllocateMemory v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAllocateMemory(VkFunctionPointer v) => new PFN_vkAllocateMemory(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkAllocateMemory v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAllocateMemory(void* v) => new PFN_vkAllocateMemory(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkMemoryAllocateInfo pAllocateInfo, in VkAllocationCallbacks pAllocator, ref VkDeviceMemory pMemory)
        {
            return this.ptr(device, in pAllocateInfo, in pAllocator, ref pMemory);
        }
    }
}
