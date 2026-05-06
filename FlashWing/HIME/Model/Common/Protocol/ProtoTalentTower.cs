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
    public class ProtoTalentTower : ProtoBase
    {
        [ProtoMember(1)]
        public int Id;
        [ProtoMember(2)]
        public int CurDifficulty;
        [ProtoMember(3)]
        public int CurTier;
        [ProtoMember(4)]
        public int MaxDifficulty;
        [ProtoMember(5)]
        public Dictionary<int, ProtoRoleBattleGroup> CurGirls;
        [ProtoMember(6)]
        public Dictionary<int, ProtoGirlBattleStatus> GirlsStatus;
        [ProtoMember(7)]
        public List<ProtoBattleMonsterStatus> CurMonstersHP;
        [ProtoMember(8)]
        public Dictionary<int, ProtoCombinedMachineStatus> CombinedMachineStatus;
    }
}
