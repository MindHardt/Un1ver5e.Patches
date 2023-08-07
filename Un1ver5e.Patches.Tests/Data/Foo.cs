namespace Un1ver5e.Patches.Tests.Data;

[Patchable]
public class Foo
{
    public int Bar { get; set; }
    public string? Baz { get; init; }
    public double Quux;
    
    [NotPatched]
    public long Quuux { get; set; }
}