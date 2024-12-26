using MessagePack;

namespace MareSynchronos.API.Dto.CharaData;

[MessagePackObject(keyAsPropertyName: true)]
public record CharaDataUpdateDto(string Id) : CharaDataDto(Id)
{
    public string? Description { get; set; }
    public DateTime? ExpiryDate { get; set; }
    public string? GlamourerData { get; set; }
    public string? CustomizeData { get; set; }
    public List<string>? AllowedUsers { get; set; }
    public Dictionary<string, List<string>>? FileGamePaths { get; set; }
    public Dictionary<string, string>? FileSwaps { get; set; }
    public AccessTypeDto? AccessType { get; set; }
    public ShareTypeDto? ShareType { get; set; }
}
