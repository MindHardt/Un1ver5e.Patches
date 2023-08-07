using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace Un1ver5e.Patches.Generator;

[Generator(LanguageNames.CSharp)]
public class PatchGenerator : IIncrementalGenerator
{
    public void Initialize(
        IncrementalGeneratorInitializationContext context)
    {
        Debug.WriteLine($"Running {nameof(PatchGenerator)} generator");
    }
}