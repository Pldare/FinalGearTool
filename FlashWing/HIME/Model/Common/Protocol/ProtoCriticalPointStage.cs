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
    public class ProtoCriticalPointStage : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<int, ProtoCriticalPointMission> ActivityMissions;
        [ProtoMember(3)]
        public int ChallengeTimes;
        [ProtoMember(4)]
        public long ChallengeRefreshTime;
        [ProtoMember(9)]
        public long ActivityOpenTime;
        [ProtoMember(10)]
        public long ActivityCloseTime;
    }
}
