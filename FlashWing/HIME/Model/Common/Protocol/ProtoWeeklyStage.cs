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
    public class ProtoWeeklyStage
    {

        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int StarMark;
        [ProtoMember(3)]
        public int ExtCount;
        [ProtoMember(4)]
        public int CompleteCount;
        [ProtoMember(5)]
        public int Unlock;
        [ProtoMember(6)]
        public ObjState State;
        [ProtoMember(7)]
        public int TotalCompCount;
        [ProtoMember(8)]
        public int MaxStartCount;
        [ProtoMember(9)]
        public int CompleteSecond;
        [ProtoMember(10)]
        public long CompleteTime;
        [ProtoMember(11)]
        public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup;
    }
}
