using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataDownloadDto(string Id, string UploaderUID) : CharaDataDto(Id)
{
    public DateTime UpdatedDate { get; init; }
    public string? Description { get; init; }
    public string? GlamourerData { get; init; }
    public string? CustomizeData { get; init; }
    public List<GamePathEntry> FileGamePaths { get; init; } = [];
    public List<GamePathEntry> FileSwaps { get; init; } = [];
}