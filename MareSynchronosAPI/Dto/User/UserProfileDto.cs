﻿using MareSynchronos.API.Data;
using MessagePack;

namespace MareSynchronos.API.Dto.User;

[MessagePackObject(keyAsPropertyName: true)]
public record UserProfileDto(UserData User, bool? IsNSFW, byte[]? ProfilePicture, string? Description) : UserDto(User);
