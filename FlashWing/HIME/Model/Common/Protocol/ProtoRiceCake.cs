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
    public class ProtoRiceCake : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int HighestScore;
        [ProtoMember(3)]
        public Dictionary<int, int> ScoreReward;
        [ProtoMember(4)]
        public bool GotTodayReward;
        [ProtoMember(5)]
        public long FirstPlayTime;
        [ProtoMember(6)]
        public long LastPlayTime;
        [ProtoMember(7)]
        public int PlayTimes;
        [ProtoMember(8)]
        public int VerNo;
        [ProtoMember(9)]
        public int LastScore;
    }
}
