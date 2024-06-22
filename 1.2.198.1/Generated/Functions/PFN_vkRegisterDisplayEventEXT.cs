using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkRegisterDisplayEventEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkDisplayKHR, in VkDisplayEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDisplayKHR, in VkDisplayEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkRegisterDisplayEventEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkDisplayKHR, in VkDisplayEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkRegisterDisplayEventEXT(delegate *unmanaged[Cdecl]<VkDevice, VkDisplayKHR, in VkDisplayEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkRegisterDisplayEventEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkRegisterDisplayEventEXT(VkFunctionPointer v) => new PFN_vkRegisterDisplayEventEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkRegisterDisplayEventEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkRegisterDisplayEventEXT(void* v) => new PFN_vkRegisterDisplayEventEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkDisplayKHR display, in VkDisplayEventInfoEXT pDisplayEventInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            return this.ptr(device, display, in pDisplayEventInfo, in pAllocator, ref pFence);
        }
    }
}
