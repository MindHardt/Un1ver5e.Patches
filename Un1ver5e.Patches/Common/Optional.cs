namespace Un1ver5e.Patches.Common;

public readonly record struct Optional<T>
{
    private readonly T _value;
    
    /// <summary>
    /// Determines whether this <see cref="Optional{T}"/> contains actual value.
    /// </summary>
    public bool HasValue { get; }
    
    /// <summary>
    /// This <see cref="Optional{T}"/>s value. This property throws
    /// <see cref="InvalidOperationException"/> if there is no value.
    /// </summary>
    /// <exception cref="InvalidOperationException"></exception>
    public T Value => HasValue ? _value : throw new InvalidOperationException("Attempted to get non existent value");

    /// <inheritdoc cref="Create"/>
    public Optional(T value)
    {
        _value = value;
        HasValue = true;
    }
    
    /// <summary>
    /// Constructs new <see cref="Optional{T}"/> that contains <paramref name="value"/>.
    /// </summary>
    /// <param name="value">The value contained in <see cref="Optional{T}"/>.</param>
    public static Optional<T> Create(T value)
        => new(value);

    /// <inheritdoc cref="Create"/>
    public static implicit operator Optional<T>(T value)
        => new(value);

    /// <summary>
    /// The default <see cref="Optional{T}"/> with no value.
    /// </summary>
    public static Optional<T> Empty 
        => default;

    /// <summary>
    /// Constructs new <see cref="Optional{T}"/> from <paramref name="value"/>.
    /// If <paramref name="value"/> is <see langword="null"/> then <see cref="Optional{T}"/>
    /// is created empty.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Optional<T> FromNullable(T? value)
        => value is null ? Empty : new Optional<T>(value);

    /// <summary>
    /// Gets <see cref="Value"/> of this <see cref="Optional{T}"/> or
    /// <see langword="default"/> if there is no value.
    /// </summary>
    /// <returns></returns>
    public T? GetValueOrDefault()
        => HasValue ? _value : default;

    /// <summary>
    /// Gets <see cref="Value"/> of this <see cref="Optional{T}"/> or
    /// <paramref name="defaultValue"/> if there is no value.
    /// </summary>
    /// <returns></returns>
    public T GetValueOrDefault(T defaultValue)
        => HasValue ? _value : defaultValue;
}

public static class Optional
{
    /// <inheritdoc cref="Optional{T}.Create"/>
    public static Optional<T> Create<T>(T value)
        => new(value);
    
    /// <inheritdoc cref="Optional{T}.FromNullable"/>
    public static Optional<T> FromNullable<T>(T? value)
        => value is null ? Optional<T>.Empty : Optional<T>.Create(value);
}