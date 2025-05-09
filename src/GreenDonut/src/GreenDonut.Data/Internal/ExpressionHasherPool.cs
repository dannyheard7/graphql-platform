using Microsoft.Extensions.ObjectPool;

namespace GreenDonut.Data.Internal;

internal sealed class ExpressionHasherPool(int maximumRetained = 256)
    : DefaultObjectPool<ExpressionHasher>(new DefaultPooledObjectPolicy<ExpressionHasher>(), maximumRetained)
{
    public static ExpressionHasherPool Shared { get; } = new();
}
