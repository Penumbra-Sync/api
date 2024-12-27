using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataFullDto(string Id, string UploaderUID) : CharaDataDto(Id)
{
    public DateTime CreatedDate { get; init; }
    public DateTime UpdatedDate { get; init; }
    public string? Description { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? GlamourerData { get; set; }
    public string? CustomizeData { get; set; }
    public int DownloadCount { get; } = 0;
    public List<UserData> AllowedUsers { get; set; } = [];
    public Dictionary<string, List<string>>? FileGamePaths { get; set; }
    public Dictionary<string, string>? FileSwaps { get; set; }
    public Dictionary<string, string> HashToGamePath { get; set; } = [];
    public AccessTypeDto AccessType { get; set; }
    public ShareTypeDto ShareType { get; set; }
}
