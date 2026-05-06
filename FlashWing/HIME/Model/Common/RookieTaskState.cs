using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Model.Common
{
    public enum RookieTaskState : byte
    {
        WaitAccept,
        Progress,
        Completed,
        Received
    }
}
