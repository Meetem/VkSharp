using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCreateEvent : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkEventCreateInfo, in VkAllocationCallbacks, ref VkEvent, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkEventCreateInfo, in VkAllocationCallbacks, ref VkEvent, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateEvent(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkEventCreateInfo, in VkAllocationCallbacks, ref VkEvent, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCreateEvent(delegate *unmanaged[Cdecl]<VkDevice, in VkEventCreateInfo, in VkAllocationCallbacks, ref VkEvent, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCreateEvent v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateEvent(VkFunctionPointer v) => new PFN_vkCreateEvent(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCreateEvent v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCreateEvent(void* v) => new PFN_vkCreateEvent(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkEventCreateInfo pCreateInfo, in VkAllocationCallbacks pAllocator, ref VkEvent pEvent)
        {
            return this.ptr(device, in pCreateInfo, in pAllocator, ref pEvent);
        }
    }
}
