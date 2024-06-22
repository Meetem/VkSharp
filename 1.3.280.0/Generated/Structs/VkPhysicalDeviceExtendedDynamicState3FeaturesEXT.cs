using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace VkSharp
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe partial struct VkPhysicalDeviceExtendedDynamicState3FeaturesEXT
    {
        public VkStructureType sType;
        public void* pNext;
        public VkBool32 extendedDynamicState3TessellationDomainOrigin;
        public VkBool32 extendedDynamicState3DepthClampEnable;
        public VkBool32 extendedDynamicState3PolygonMode;
        public VkBool32 extendedDynamicState3RasterizationSamples;
        public VkBool32 extendedDynamicState3SampleMask;
        public VkBool32 extendedDynamicState3AlphaToCoverageEnable;
        public VkBool32 extendedDynamicState3AlphaToOneEnable;
        public VkBool32 extendedDynamicState3LogicOpEnable;
        public VkBool32 extendedDynamicState3ColorBlendEnable;
        public VkBool32 extendedDynamicState3ColorBlendEquation;
        public VkBool32 extendedDynamicState3ColorWriteMask;
        public VkBool32 extendedDynamicState3RasterizationStream;
        public VkBool32 extendedDynamicState3ConservativeRasterizationMode;
        public VkBool32 extendedDynamicState3ExtraPrimitiveOverestimationSize;
        public VkBool32 extendedDynamicState3DepthClipEnable;
        public VkBool32 extendedDynamicState3SampleLocationsEnable;
        public VkBool32 extendedDynamicState3ColorBlendAdvanced;
        public VkBool32 extendedDynamicState3ProvokingVertexMode;
        public VkBool32 extendedDynamicState3LineRasterizationMode;
        public VkBool32 extendedDynamicState3LineStippleEnable;
        public VkBool32 extendedDynamicState3DepthClipNegativeOneToOne;
        public VkBool32 extendedDynamicState3ViewportWScalingEnable;
        public VkBool32 extendedDynamicState3ViewportSwizzle;
        public VkBool32 extendedDynamicState3CoverageToColorEnable;
        public VkBool32 extendedDynamicState3CoverageToColorLocation;
        public VkBool32 extendedDynamicState3CoverageModulationMode;
        public VkBool32 extendedDynamicState3CoverageModulationTableEnable;
        public VkBool32 extendedDynamicState3CoverageModulationTable;
        public VkBool32 extendedDynamicState3CoverageReductionMode;
        public VkBool32 extendedDynamicState3RepresentativeFragmentTestEnable;
        public VkBool32 extendedDynamicState3ShadingRateImageEnable;
        
        // --- generated members
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static VkPhysicalDeviceExtendedDynamicState3FeaturesEXT Create()
        {
            return default;
        }
        
    }
}
