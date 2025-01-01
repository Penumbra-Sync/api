using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataFullDto(string Id, UserData Uploader) : CharaDataDto(Id, Uploader)
{
    public DateTime CreatedDate { get; init; }
    public DateTime ExpiryDate { get; set; }
    public string GlamourerData { get; set; } = string.Empty;
    public string CustomizeData { get; set; } = string.Empty;
    public string ManipulationData { get; set; } = string.Empty;
    public int DownloadCount { get; set; } = 0;
    public List<UserData> AllowedUsers { get; set; } = [];
    public List<GamePathEntry> FileGamePaths { get; set; } = [];
    public List<GamePathEntry> FileSwaps { get; set; } = [];
    public List<GamePathEntry> OriginalFiles { get; set; } = [];
    public AccessTypeDto AccessType { get; set; }
    public ShareTypeDto ShareType { get; set; }
    public List<PoseEntry> PoseData { get; set; } = [];
}

[MessagePackObject(keyAsPropertyName: true)]
public record GamePathEntry(string HashOrFileSwap, string GamePath);

[MessagePackObject(keyAsPropertyName: true)]
public record PoseEntry(long? Id)
{
    public string? Description { get; set; } = string.Empty;
    public string? PoseData { get; set; } = string.Empty;
    public string? WorldData { get; set; } = string.Empty;
}