using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataMetaInfoDto(string Id, UserData UploaderUID) : CharaDataDto(Id, UploaderUID)
{
    public bool CanBeDownloaded { get; init; }
    public List<PoseEntry> PoseData { get; set; } = [];
}
