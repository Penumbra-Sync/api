using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataFullDto(string Id, string UploaderUID) : CharaDataDto(Id)
{
    public DateTime CreatedDate { get; init; }
    public DateTime UpdatedDate { get; init; }
    public string Description { get; set; } = string.Empty;
    public DateTime ExpiryDate { get; set; }
    public string GlamourerData { get; set; } = string.Empty;
    public string CustomizeData { get; set; } = string.Empty;
    public string ManipulationData { get; set; } = string.Empty;
    public int DownloadCount { get; } = 0;
    public List<UserData> AllowedUsers { get; set; } = [];
    public List<GamePathEntry> FileGamePaths { get; set; } = [];
    public List<GamePathEntry> FileSwaps { get; set; } = [];
    public List<GamePathEntry> OriginalFiles { get; set; } = [];
    public AccessTypeDto AccessType { get; set; }
    public ShareTypeDto ShareType { get; set; }
}

[MessagePackObject(keyAsPropertyName: true)]
public record GamePathEntry(string HashOrFileSwap, string GamePath);