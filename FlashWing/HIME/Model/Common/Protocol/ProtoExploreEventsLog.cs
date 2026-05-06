using FlashWing.HIME.Model.Common.Enum;
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
    public class ProtoExploreEventsLog
    {
        [ProtoMember(1)]
        public ExploreEventType Type;
        [ProtoMember(2)]
        public long Time;
        [ProtoMember(3)]
        public string ItemStr;
        [ProtoMember(4)]
        public int Value;
    }
}
