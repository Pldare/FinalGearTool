using FlashWing.HIME.Script.Model.Common.Protocol;
using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashWing.HIME.Model.Common.Protocol
{
    [ProtoContract]
    [Serializable]
    public class ProtoMCVLowCostInfo
    {
        [ProtoMember(1)]
        public bool IsLowCostStatus;
        [ProtoMember(2)]
        public long EnterLowCostTimestamp;
        [ProtoMember(3)]
        public long EnterHours;
        [ProtoMember(4)]
        public long HaveUsedHours;
    }
}
