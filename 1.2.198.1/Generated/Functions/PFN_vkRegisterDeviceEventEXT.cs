using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkRegisterDeviceEventEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkRegisterDeviceEventEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkRegisterDeviceEventEXT(delegate *unmanaged[Cdecl]<VkDevice, in VkDeviceEventInfoEXT, in VkAllocationCallbacks, ref VkFence, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkRegisterDeviceEventEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkRegisterDeviceEventEXT(VkFunctionPointer v) => new PFN_vkRegisterDeviceEventEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkRegisterDeviceEventEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkRegisterDeviceEventEXT(void* v) => new PFN_vkRegisterDeviceEventEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkDeviceEventInfoEXT pDeviceEventInfo, in VkAllocationCallbacks pAllocator, ref VkFence pFence)
        {
            return this.ptr(device, in pDeviceEventInfo, in pAllocator, ref pFence);
        }
    }
}
