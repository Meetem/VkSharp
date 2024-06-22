using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetCalibratedTimestampsKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, in VkCalibratedTimestampInfoKHR, ulong*, ref ulong, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, in VkCalibratedTimestampInfoKHR, ulong*, ref ulong, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetCalibratedTimestampsKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, in VkCalibratedTimestampInfoKHR, ulong*, ref ulong, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetCalibratedTimestampsKHR(delegate *unmanaged[Cdecl]<VkDevice, uint, in VkCalibratedTimestampInfoKHR, ulong*, ref ulong, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetCalibratedTimestampsKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetCalibratedTimestampsKHR(VkFunctionPointer v) => new PFN_vkGetCalibratedTimestampsKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetCalibratedTimestampsKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetCalibratedTimestampsKHR(void* v) => new PFN_vkGetCalibratedTimestampsKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, uint timestampCount, in VkCalibratedTimestampInfoKHR pTimestampInfos, ulong* pTimestamps, ref ulong pMaxDeviation)
        {
            return this.ptr(device, timestampCount, in pTimestampInfos, pTimestamps, ref pMaxDeviation);
        }
    }
}
