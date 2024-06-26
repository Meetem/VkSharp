using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdBindShadersEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkShaderStageFlags*, in VkShaderEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkShaderStageFlags*, in VkShaderEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBindShadersEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkShaderStageFlags*, in VkShaderEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdBindShadersEXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, uint, VkShaderStageFlags*, in VkShaderEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdBindShadersEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBindShadersEXT(VkFunctionPointer v) => new PFN_vkCmdBindShadersEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdBindShadersEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdBindShadersEXT(void* v) => new PFN_vkCmdBindShadersEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, uint stageCount, VkShaderStageFlags* pStages, in VkShaderEXT pShaders)
        {
            this.ptr(commandBuffer, stageCount, pStages, in pShaders);
        }
    }
}
