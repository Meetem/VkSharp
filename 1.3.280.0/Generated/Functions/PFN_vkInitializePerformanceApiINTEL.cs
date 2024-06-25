using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkInitializePerformanceApiINTEL : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkInitializePerformanceApiInfoINTEL, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkInitializePerformanceApiInfoINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkInitializePerformanceApiINTEL(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkInitializePerformanceApiInfoINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkInitializePerformanceApiINTEL(delegate *unmanaged[Cdecl]<VkDevice, in VkInitializePerformanceApiInfoINTEL, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkInitializePerformanceApiINTEL v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkInitializePerformanceApiINTEL(VkFunctionPointer v) => new PFN_vkInitializePerformanceApiINTEL(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkInitializePerformanceApiINTEL v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkInitializePerformanceApiINTEL(void* v) => new PFN_vkInitializePerformanceApiINTEL(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkInitializePerformanceApiInfoINTEL pInitializeInfo)
        {
            return this.ptr(device, in pInitializeInfo);
        }
    }
}
