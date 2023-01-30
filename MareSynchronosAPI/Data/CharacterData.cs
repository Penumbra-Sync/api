using MareSynchronos.API.Data.Enum;

namespace MareSynchronos.API.Data;

public class CharacterData : HashableDataBase
{
    public Dictionary<ObjectKind, List<FileReplacementData>> FileReplacements { get; set; } = new();
    public Dictionary<ObjectKind, string> GlamourerData { get; set; } = new();
    public string ManipulationData { get; set; } = string.Empty;
    public string CustomizePlusData { get; set; } = string.Empty;
    public string PalettePlusData { get; set; } = string.Empty;
    public float HeelsOffset { get; set; } = 0.0f;
}