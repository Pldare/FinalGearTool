using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlashWing.HIME.Script.Model.Common.Protocol;

namespace FlashWing.HIME.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class DailyStageCount : ProtoBase
    {
        [ProtoMember(1)]
        public int UsedCount;
        [ProtoMember(2)]
        public int LeftCount;
    }
}
