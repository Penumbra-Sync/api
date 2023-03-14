﻿using MareSynchronos.API.Data.Enum;
using MessagePack;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text;
using System.Security.Cryptography;

namespace MareSynchronos.API.Data;

[MessagePackObject(keyAsPropertyName: true)]
public class CharacterData
{
    public CharacterData()
    {
        DataHash = new(() =>
        {
            var json = JsonSerializer.Serialize(this);
#pragma warning disable SYSLIB0021 // Type or member is obsolete
            using SHA256CryptoServiceProvider cryptoProvider = new();
#pragma warning restore SYSLIB0021 // Type or member is obsolete
            return BitConverter.ToString(cryptoProvider.ComputeHash(Encoding.UTF8.GetBytes(json))).Replace("-", "", StringComparison.Ordinal);
        });
    }

    [JsonIgnore]
    public Lazy<string> DataHash { get; }

    public Dictionary<ObjectKind, List<FileReplacementData>> FileReplacements { get; set; } = new();
    public Dictionary<ObjectKind, string> GlamourerData { get; set; } = new();
    public string ManipulationData { get; set; } = string.Empty;
    public string CustomizePlusData { get; set; } = string.Empty;
    public string PalettePlusData { get; set; } = string.Empty;
    public float HeelsOffset { get; set; } = 0.0f;
}