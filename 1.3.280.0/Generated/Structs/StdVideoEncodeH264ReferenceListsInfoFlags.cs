using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct StdVideoEncodeH264ReferenceListsInfoFlags
    {
        public uint ref_pic_list_modification_flag_l0;
        public uint ref_pic_list_modification_flag_l1;
        public uint reserved;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static StdVideoEncodeH264ReferenceListsInfoFlags Create()
        {
            return default;
        }
        
    }
}
