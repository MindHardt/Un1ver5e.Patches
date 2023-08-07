namespace Un1ver5e.Patches;

/// <summary>
/// Indicates that decorated class can be patched using <see cref="IPatch{T}"/>
/// and that a patch for it should be code-generated.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class PatchableAttribute : Attribute
{
    private readonly PatchSources _patchSources;

    /// <summary>
    /// Creates a new <see cref="PatchableAttribute"/> that indicates that an implementation
    /// of <see cref="IPatch{T}"/> should be code-generated for decorated class.
    /// </summary>
    /// <param name="patchSources">
    /// Indicates which what members should be stored in generated patch class.
    /// </param>
    public PatchableAttribute(PatchSources patchSources = PatchSources.Default)
    {
        _patchSources = patchSources;
    }
}