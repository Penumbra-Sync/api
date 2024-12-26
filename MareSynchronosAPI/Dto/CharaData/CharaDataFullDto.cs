using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataFullDto(string Id, string UploaderUID) : CharaDataDto(Id)
{
    public string UploaderUID { get; } = UploaderUID;
    public DateTime CreatedDate { get; }
    public DateTime UpdatedDate { get; }
    public string? Description { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? GlamourerData { get; set; }
    public string? CustomizeData { get; set; }
    public int DownloadCount { get; } = 0;
    public List<string> AllowedUsers { get; set; } = [];
    public Dictionary<string, List<string>>? FileGamePaths { get; set; }
    public List<string> ExpectedHashes { get; set; } = [];
    public AccessTypeDto AccessType { get; set; }
    public ShareTypeDto ShareType { get; set; }
}
