using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct PFN_vkGetDeviceGroupPeerMemoryFeatures : IVkFuncPtr
    // Generated function pointer as structure
    {
        public delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void> ptr;
        public void* Pointer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (void*)this.ptr;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupPeerMemoryFeatures(void *value)
        {
            this.ptr = (delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void>)value;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PFN_vkGetDeviceGroupPeerMemoryFeatures(delegate *unmanaged[Cdecl]<VkDevice, uint, uint, uint, ref VkPeerMemoryFeatureFlags, void> funcPtr)
        {
            this.ptr = funcPtr;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator VkFunctionPointer(PFN_vkGetDeviceGroupPeerMemoryFeatures v) => new VkFunctionPointer(v.Pointer);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupPeerMemoryFeatures(VkFunctionPointer v) => new PFN_vkGetDeviceGroupPeerMemoryFeatures(v.ptr);
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator void*(PFN_vkGetDeviceGroupPeerMemoryFeatures v) => (void*)v.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator PFN_vkGetDeviceGroupPeerMemoryFeatures(void* v) => new PFN_vkGetDeviceGroupPeerMemoryFeatures(v);
        
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Call(VkDevice device, uint heapIndex, uint localDeviceIndex, uint remoteDeviceIndex, ref VkPeerMemoryFeatureFlags pPeerMemoryFeatures)
        {
            this.ptr(device, heapIndex, localDeviceIndex, remoteDeviceIndex, ref pPeerMemoryFeatures);
        }
    }
}
