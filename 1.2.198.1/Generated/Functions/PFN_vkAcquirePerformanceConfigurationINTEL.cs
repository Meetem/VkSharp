using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkAcquirePerformanceConfigurationINTEL : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkPerformanceConfigurationAcquireInfoINTEL, ref VkPerformanceConfigurationINTEL, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPerformanceConfigurationAcquireInfoINTEL, ref VkPerformanceConfigurationINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAcquirePerformanceConfigurationINTEL(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkPerformanceConfigurationAcquireInfoINTEL, ref VkPerformanceConfigurationINTEL, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkAcquirePerformanceConfigurationINTEL(delegate *unmanaged[Cdecl]<VkDevice, in VkPerformanceConfigurationAcquireInfoINTEL, ref VkPerformanceConfigurationINTEL, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkAcquirePerformanceConfigurationINTEL v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAcquirePerformanceConfigurationINTEL(VkFunctionPointer v) => new PFN_vkAcquirePerformanceConfigurationINTEL(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkAcquirePerformanceConfigurationINTEL v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkAcquirePerformanceConfigurationINTEL(void* v) => new PFN_vkAcquirePerformanceConfigurationINTEL(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkPerformanceConfigurationAcquireInfoINTEL pAcquireInfo, ref VkPerformanceConfigurationINTEL pConfiguration)
        {
            return this.ptr(device, in pAcquireInfo, ref pConfiguration);
        }
    }
}
