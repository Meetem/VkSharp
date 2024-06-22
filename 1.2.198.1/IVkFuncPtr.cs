namespace VkSharp
{
    public interface IVkFuncPtr
    {
        unsafe void* Pointer { get; set; }
    }
}