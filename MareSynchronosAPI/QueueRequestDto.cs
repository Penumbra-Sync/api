using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MareSynchronos.API;

public record QueueRequestDto(Guid RequestId, QueueStatus QueueStatus);

public enum QueueStatus
{
    Ready,
    Waiting
}
