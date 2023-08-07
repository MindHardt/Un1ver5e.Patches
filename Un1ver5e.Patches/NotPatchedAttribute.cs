namespace Un1ver5e.Patches;

/// <summary>
/// Indicates that decorated property must not be patched with
/// code-generated <see cref="IPatch{T}"/> implementation.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class NotPatchedAttribute : Attribute
{ }