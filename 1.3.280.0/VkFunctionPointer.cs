using System;
using System.Runtime.InteropServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 8, Pack = 8)]
    public unsafe struct VkFunctionPointer : IVkFuncPtr
    {
        public void* ptr;
        public void* Pointer
        {
            get => ptr;
            set => ptr = value;
        }
        
        public VkFunctionPointer(void* ptr)
        {
            this.ptr = ptr;
        }

        public static implicit operator void*(VkFunctionPointer p)
        {
            return p.ptr;
        }
    }
}