using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetShaderInfoAMD : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, ref ulong, void*, VkResult> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, ref ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetShaderInfoAMD(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, ref ulong, void*, VkResult>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetShaderInfoAMD(delegate *unmanaged[Cdecl]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, ref ulong, void*, VkResult> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetShaderInfoAMD v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetShaderInfoAMD(VkFunctionPointer v) => new PFN_vkGetShaderInfoAMD(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetShaderInfoAMD v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetShaderInfoAMD(void* v) => new PFN_vkGetShaderInfoAMD(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public VkResult Call(VkDevice device, VkPipeline pipeline, VkShaderStageFlags shaderStage, VkShaderInfoTypeAMD infoType, ref ulong pInfoSize, void* pInfo)
        {
            return this.ptr(device, pipeline, shaderStage, infoType, ref pInfoSize, pInfo);
        }
    }
}
