namespace MareSynchronos.API.Dto.CharaData;

public enum AccessTypeDto
{
    Individuals,
    ClosePairs,
    AllPairs,
    Public
}

public enum ShareTypeDto
{
    Private,
    Shared
}

public record CharaDataDto(string Id)
{
}

public record CharaDataMetaInfoDto(string Id, string UploaderUId) : CharaDataDto(Id)
{
    public string? Description { get; init; }
    public DateTime UpdatedDate { get; init; }
    public bool CanBeDownloaded { get; init; }
}

public record CharaDataUpdateDto(string Id) : CharaDataDto(Id)
{
    public string? Description { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? GlamourerData { get; set; }
    public string? CustomizeData { get; set; }
    public List<string>? AllowedUsers { get; set; } = [];
    public Dictionary<string, List<string>>? FileGamePaths { get; set; }
    public AccessTypeDto? AccessType { get; set; }
    public ShareTypeDto? ShareType { get; set; }
}

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

public record CharaDataDownloadDto(string Id, string UploaderUID) : CharaDataDto(Id)
{
    public DateTime UpdatedDate { get; init; }
    public string? Description { get; init; }
    public string? GlamourerData { get; init; }
    public string? CustomizeData { get; init; }
    public Dictionary<string, List<string>>? FileGamePaths { get; init; } = new(StringComparer.Ordinal);
}