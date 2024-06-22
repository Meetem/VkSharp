using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetEncodedVideoSessionParametersKHR : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, in VkVideoEncodeSessionParametersGetInfoKHR, ref VkVideoEncodeSessionParametersFeedbackInfoKHR, ref ulong, void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkVideoEncodeSessionParametersGetInfoKHR, ref VkVideoEncodeSessionParametersFeedbackInfoKHR, ref ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetEncodedVideoSessionParametersKHR(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, in VkVideoEncodeSessionParametersGetInfoKHR, ref VkVideoEncodeSessionParametersFeedbackInfoKHR, ref ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetEncodedVideoSessionParametersKHR(delegate *unmanaged[Cdecl]<VkDevice, in VkVideoEncodeSessionParametersGetInfoKHR, ref VkVideoEncodeSessionParametersFeedbackInfoKHR, ref ulong, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetEncodedVideoSessionParametersKHR v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetEncodedVideoSessionParametersKHR(VkFunctionPointer v) => new PFN_vkGetEncodedVideoSessionParametersKHR(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetEncodedVideoSessionParametersKHR v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetEncodedVideoSessionParametersKHR(void* v) => new PFN_vkGetEncodedVideoSessionParametersKHR(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, in VkVideoEncodeSessionParametersGetInfoKHR pVideoSessionParametersInfo, ref VkVideoEncodeSessionParametersFeedbackInfoKHR pFeedbackInfo, ref ulong pDataSize, void* pData)
        {
            return this.ptr(device, in pVideoSessionParametersInfo, ref pFeedbackInfo, ref pDataSize, pData);
        }
    }
}
