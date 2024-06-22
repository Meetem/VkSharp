using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceProcAddr : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, byte*, VkFunctionPointer> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, byte*, VkFunctionPointer>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceProcAddr(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, byte*, VkFunctionPointer>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceProcAddr(delegate *unmanaged[Cdecl]<VkDevice, byte*, VkFunctionPointer> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceProcAddr v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceProcAddr(VkFunctionPointer v) => new PFN_vkGetDeviceProcAddr(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceProcAddr v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceProcAddr(void* v) => new PFN_vkGetDeviceProcAddr(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkFunctionPointer Call(VkDevice device, byte* pName)
        {
            return this.ptr(device, pName);
        }
    }
}
