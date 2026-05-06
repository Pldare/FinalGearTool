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
    public class ProtoStage : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int StarMark;
        [ProtoMember(3)]
        public StageStatus Status;
        [ProtoMember(4)]
        public List<int> BattleIds;
        [ProtoMember(5)]
        public Dictionary<int, int> GirlsHp;
        [ProtoMember(6)]
        public int CompleteCount;
        [ProtoMember(7)]
        public ObjState State;
        [ProtoMember(8)]
        public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus;
        [ProtoMember(9)]
        public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup;
        [ProtoMember(10)]
        public int TotalExp;
        [ProtoMember(11)]
        public int TotalCoin;
        [ProtoMember(12)]
        public int DungeonDropCtrlCount;
        [ProtoMember(13)]
        public string AuthCode;
        [ProtoMember(14)]
        public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus;
    }
}
