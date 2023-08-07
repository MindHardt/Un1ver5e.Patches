namespace Un1ver5e.Patches;

/// <summary>
/// Exposes the functionality to update <typeparamref name="T"/> with
/// patches containing only different data.
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IPatch<T>
{
    /// <summary>
    /// Creates new <typeparamref name="T"/> with values of
    /// <paramref name="original"/> patched using this <see cref="IPatch{T}"/>.
    /// This affects <see langword="set"/>table and <see langword="init"/>table properties.
    /// </summary>
    /// <param name="original">The original <typeparamref name="T"/>.</param>
    /// <returns>A new instance of <typeparamref name="T"/>.</returns>
    public T CreatePatched(T original);

    /// <summary>
    /// Applies values of this <see cref="IPatch{T}"/> to the
    /// <paramref name="original"/>.
    /// This affects only <see langword="set"/>table properties.
    /// </summary>
    /// <param name="original">The updated <typeparamref name="T"/>.</param>
    /// <returns>Reference to <paramref name="original"/>.</returns>
    public T Patch(T original);
}