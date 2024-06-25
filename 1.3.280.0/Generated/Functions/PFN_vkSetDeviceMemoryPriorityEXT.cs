using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkSetDeviceMemoryPriorityEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetDeviceMemoryPriorityEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkSetDeviceMemoryPriorityEXT(delegate *unmanaged[Cdecl]<VkDevice, VkDeviceMemory, float, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkSetDeviceMemoryPriorityEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetDeviceMemoryPriorityEXT(VkFunctionPointer v) => new PFN_vkSetDeviceMemoryPriorityEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkSetDeviceMemoryPriorityEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkSetDeviceMemoryPriorityEXT(void* v) => new PFN_vkSetDeviceMemoryPriorityEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, VkDeviceMemory memory, float priority)
        {
            this.ptr(device, memory, priority);
        }
    }
}
