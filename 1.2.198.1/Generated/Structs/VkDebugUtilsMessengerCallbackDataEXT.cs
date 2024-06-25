using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkDebugUtilsMessengerCallbackDataEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkDebugUtilsMessengerCallbackDataFlagsEXT flags;
        public byte* pMessageIdName;
        public int messageIdNumber;
        public byte* pMessage;
        public uint queueLabelCount;
        public VkDebugUtilsLabelEXT* pQueueLabels;
        public uint cmdBufLabelCount;
        public VkDebugUtilsLabelEXT* pCmdBufLabels;
        public uint objectCount;
        public VkDebugUtilsObjectNameInfoEXT* pObjects;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkDebugUtilsMessengerCallbackDataEXT Create()
        {
            VkDebugUtilsMessengerCallbackDataEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
