using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [VkFunctionStruct(VkFunctionOwner.Device)]
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkCmdDebugMarkerInsertEXT : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkDebugMarkerMarkerInfoEXT, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkDebugMarkerMarkerInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdDebugMarkerInsertEXT(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkDebugMarkerMarkerInfoEXT, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkCmdDebugMarkerInsertEXT(delegate *unmanaged[Cdecl]<VkCommandBuffer, in VkDebugMarkerMarkerInfoEXT, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkCmdDebugMarkerInsertEXT v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdDebugMarkerInsertEXT(VkFunctionPointer v) => new PFN_vkCmdDebugMarkerInsertEXT(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkCmdDebugMarkerInsertEXT v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkCmdDebugMarkerInsertEXT(void* v) => new PFN_vkCmdDebugMarkerInsertEXT(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkCommandBuffer commandBuffer, in VkDebugMarkerMarkerInfoEXT pMarkerInfo)
        {
            this.ptr(commandBuffer, in pMarkerInfo);
        }
    }
}
