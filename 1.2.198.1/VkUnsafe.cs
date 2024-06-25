using System;
using System.Runtime.CompilerServices;
#if UNITY_2019_1_OR_NEWER
using Unity.Collections.LowLevel.Unsafe;
#endif

namespace VkSharp
{
    public static class VkUnsafe
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe T* RefToPtr<T>(ref T s)
            where T : unmanaged
        {
#if UNITY_2019_1_OR_NEWER
            return (T*)UnsafeUtility.AddressOf(ref s);
#else
            return (T*)Unsafe.AsPointer<T>(ref s);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ref T PtrToRef<T>(T* s)
            where T : unmanaged
        {
#if UNITY_2019_1_OR_NEWER
            return ref UnsafeUtility.AsRef<T>(s);
#else
            return ref Unsafe.AsRef<T>(s);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ref T PtrToRef<T>(void* s)
            where T : unmanaged
        {
#if UNITY_2019_1_OR_NEWER
            return ref UnsafeUtility.AsRef<T>(s);
#else
            return ref Unsafe.AsRef<T>(s);
#endif
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe ref T NullRef<T>()
            where T : unmanaged
        {
            return ref PtrToRef<T>(null);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe bool IsNullRef<T>(ref T s)
            where T : unmanaged
        {
#if UNITY_2019_1_OR_NEWER
            return UnsafeUtility.AddressOf(ref s) == null;
#else
            return Unsafe.IsNullRef(ref s);
#endif
        }
    }
}