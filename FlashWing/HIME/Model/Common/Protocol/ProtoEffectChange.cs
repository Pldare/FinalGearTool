using FlashWing.HIME.Model.Common.Enum;
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
    public class ProtoEffectChange
    {
        [ProtoMember(1)]
        public int BuffId;
        [ProtoMember(2)]
        public BuffType EffectChangeType;
        [ProtoMember(3)]
        public int ChangeValue;
        [ProtoMember(4)]
        public BuffExclusionStatus BuffExclusionStatus;
        [ProtoMember(5)]
        public AddBuffTiming BuffTiming;
    }
}
