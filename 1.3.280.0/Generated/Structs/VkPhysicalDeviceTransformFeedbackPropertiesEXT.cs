using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceTransformFeedbackPropertiesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public uint maxTransformFeedbackStreams;
        public uint maxTransformFeedbackBuffers;
        public ulong maxTransformFeedbackBufferSize;
        public uint maxTransformFeedbackStreamDataSize;
        public uint maxTransformFeedbackBufferDataSize;
        public uint maxTransformFeedbackBufferDataStride;
        public VkBool32 transformFeedbackQueries;
        public VkBool32 transformFeedbackStreamsLinesTriangles;
        public VkBool32 transformFeedbackRasterizationStreamSelect;
        public VkBool32 transformFeedbackDraw;
        
        // --- generated members
        
        public const VkStructureType StructureTypeId = VkStructureType.VK_STRUCTURE_TYPE_PHYSICAL_DEVICE_TRANSFORM_FEEDBACK_PROPERTIES_EXT;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceTransformFeedbackPropertiesEXT Create()
        {
            VkPhysicalDeviceTransformFeedbackPropertiesEXT ret = default;
            ret.sType = StructureTypeId;
            return ret;
        }
        
    }
}
