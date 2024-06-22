using System.Runtime.InteropServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential, Size = 4, Pack = 4)]
    public struct VkBool32
    {
        public uint value;

        public VkBool32(uint v)
        {
            value = v;
        }

        public VkBool32(bool v)
        {
            value = v ? 1u : 0u;
        }
        
        public static implicit operator VkBool32(bool v)
        {
            return new VkBool32(v);
        }
        
        public static implicit operator bool(VkBool32 v)
        {
            return v.value != 0;
        }
    }
}