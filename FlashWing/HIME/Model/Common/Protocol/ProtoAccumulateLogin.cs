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
    public class ProtoAccumulateLogin : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int LoginDaysInActivity;
        [ProtoMember(3)]
        public Dictionary<int, RewardGetState> AwardSequence;
        [ProtoMember(4)]
        public long LastGetAwardTime;
        [ProtoMember(5)]
        public bool IsPlayedAnimation;
    }
}
