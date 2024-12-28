using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataMetaInfoDto(string Id, string UploaderUId) : CharaDataDto(Id)
{
    public string Description { get; init; } = string.Empty;
    public DateTime UpdatedDate { get; init; }
    public bool CanBeDownloaded { get; init; }
}
