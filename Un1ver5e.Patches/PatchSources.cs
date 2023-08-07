namespace Un1ver5e.Patches;

[Flags]
public enum PatchSources
{
    SetProperties = 1<<0,
    InitProperties = 1<<1,
    PublicFields = 1<<2,
    
    Default = SetProperties | InitProperties,
}