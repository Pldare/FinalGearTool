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
    public class ProtoBikiniSeaFloor : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CurFloor;
        [ProtoMember(3)]
        public Dictionary<int, FloorInfo> Floors;
        [ProtoMember(4)]
        public List<int> DeadGirls;
        [ProtoMember(5)]
        public List<ProtoBattleMonsterStatus> Monster;
        [ProtoMember(6)]
        public Dictionary<int, ProtoRoleBattleGroup> BattleGroup;
        [ProtoMember(15)]
        public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus;
        [ProtoMember(7)]
        public Dictionary<int, int> Treasure;
        [ProtoMember(8)]
        public long LastWeek;
        [ProtoMember(9)]
        public int WeekNum;
        [ProtoMember(10)]
        public int Revive;
        [ProtoMember(11)]
        public int Bless;
        [ProtoMember(12)]
        public long NextWeek;
        [ProtoMember(13)]
        public List<int> PassStageIds;
        [ProtoMember(14)]
        public bool UseBless;
    }
}
