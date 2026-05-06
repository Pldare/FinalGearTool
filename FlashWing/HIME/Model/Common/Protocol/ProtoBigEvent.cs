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
    public class ProtoBigEvent : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public Dictionary<int, BigEventStage> StageList;
        [ProtoMember(3)]
        public Dictionary<int, BigEventMission> MissionList;
        [ProtoMember(4)]
        public long OpenTime;
        [ProtoMember(5)]
        public long CloseTime;
        [ProtoMember(6)]
        public List<int> EVAAreaStartsAward;
        [ProtoMember(7)]
        public long BigLstReTime;
    }
}
