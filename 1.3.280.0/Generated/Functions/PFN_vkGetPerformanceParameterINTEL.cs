using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetPerformanceParameterINTEL : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, ref VkPerformanceValueINTEL, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, ref VkPerformanceValueINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPerformanceParameterINTEL(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, ref VkPerformanceValueINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetPerformanceParameterINTEL(delegate *unmanaged[Cdecl]<VkDevice, VkPerformanceParameterTypeINTEL, ref VkPerformanceValueINTEL, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetPerformanceParameterINTEL v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPerformanceParameterINTEL(VkFunctionPointer v) => new PFN_vkGetPerformanceParameterINTEL(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetPerformanceParameterINTEL v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetPerformanceParameterINTEL(void* v) => new PFN_vkGetPerformanceParameterINTEL(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkPerformanceParameterTypeINTEL parameter, ref VkPerformanceValueINTEL pValue)
        {
            return this.ptr(device, parameter, ref pValue);
        }
    }
}
