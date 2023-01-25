﻿using System;
using System.Collections.Generic;
using MareSynchronos.API.Dto.User;

namespace MareSynchronos.API.Data.Comparer;

public class UserDtoComparer : IEqualityComparer<UserDto>
{
    public bool Equals(UserDto? x, UserDto? y)
    {
        if (x == null || y == null) return false;
        return x.User.UID.Equals(y.User.UID, StringComparison.Ordinal);
    }

    public int GetHashCode(UserDto obj)
    {
        return obj.User.UID.GetHashCode();
    }
}