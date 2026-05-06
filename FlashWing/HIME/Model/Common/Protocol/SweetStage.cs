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
    public class SweetStage
    {
        [ProtoMember(1)]
        public int StageId;
        [ProtoMember(2)]
        public int CompleteCount;
        [ProtoMember(3)]
        public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus;
        [ProtoMember(4)]
        public string AuthCode;
        [ProtoMember(5)]
        public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus;
        [ProtoMember(6)]
        public Dictionary<int, ProtoRoleBattleGroup> PersonalStoryBattleGroup;
        [ProtoMember(7)]
        public StageStatus Status;
    }
}
